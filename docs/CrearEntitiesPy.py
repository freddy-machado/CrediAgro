import re
from pathlib import Path

# ========= Config =========
INPUT_TXT = r"EntidadesNetCore.txt"   # archivo grande (puedes usar otro nombre)
OUTPUT_ROOT = Path(r"./Persistence")  # raíz de salida (creará subcarpetas)
BASE_NS = "CrediAgro.Infrastructure.Persistence"

# Carpeta destino por namespace "lógico" detectado en el archivo grande
# (si en tu TXT aparecen otros namespaces, agrégalos aquí)
NS_TO_SUBFOLDER = {
    "Entities.CustomEntities": "CustomEntities",
    "Entities.CustomEntities.Reportes": "Reportes",
    "Entities.CustomEntities.Seguridad": "Seguridad",
    "Entities.CustomEntities.CustomTabEntities": "CustomTabEntities",

    # si aparecen clases con este namespace (por tu snippet anterior)
    "Persistence.CustomEntities": "CustomEntities",
}

# Namespace final por subcarpeta
SUBFOLDER_TO_NEW_NS = {
    "CustomEntities": f"{BASE_NS}.CustomEntities",
    "Reportes": f"{BASE_NS}.Reportes",
    "Seguridad": f"{BASE_NS}.Seguridad",
    "CustomTabEntities": f"{BASE_NS}.CustomTabEntities",
}

# ========= Regex =========
# Tus separadores tienen este formato:
# ==================================================
#  ARCHIVO: Nombre.cs
# ==================================================
FILE_HEADER_RE = re.compile(r"^\s*ARCHIVO:\s*(?P<fname>.+?)\s*$", re.IGNORECASE)

# Detecta "namespace X"
NAMESPACE_RE = re.compile(r"^\s*namespace\s+(?P<ns>[\w\.]+)\s*$", re.MULTILINE)


def normalize_newlines(s: str) -> str:
    return s.replace("\r\n", "\n").replace("\r", "\n")


def detect_old_namespace(code: str) -> str | None:
    m = NAMESPACE_RE.search(code)
    return m.group("ns") if m else None


def rewrite_namespace(code: str, new_ns: str) -> str:
    # Reemplaza el PRIMER namespace encontrado (lo normal en estas clases)
    def _repl(match: re.Match) -> str:
        return f"namespace {new_ns}"
    return NAMESPACE_RE.sub(_repl, code, count=1)


def split_into_files(text: str):
    """
    Devuelve lista de (filename, content) detectados por líneas "ARCHIVO: X"
    """
    lines = text.split("\n")
    files = []

    current_name = None
    current_buf = []

    def flush():
        nonlocal current_name, current_buf
        if current_name and current_buf:
            content = "\n".join(current_buf).strip() + "\n"
            files.append((current_name.strip(), content))
        current_name = None
        current_buf = []

    for line in lines:
        m = FILE_HEADER_RE.match(line)
        if m:
            flush()
            current_name = m.group("fname")
            continue

        # Ignorar líneas separadoras visuales del txt
        if line.strip().startswith("====="):
            continue

        # Acumular contenido
        if current_name is not None:
            current_buf.append(line)

    flush()
    return files


def main():
    raw = Path(INPUT_TXT).read_text(encoding="utf-8", errors="replace")
    raw = normalize_newlines(raw)

    file_entries = split_into_files(raw)
    if not file_entries:
        raise SystemExit("No se encontraron entradas 'ARCHIVO: X.cs' en el input.")

    written = 0
    unknown_ns = set()

    for fname, code in file_entries:
        old_ns = detect_old_namespace(code)

        # Determinar subcarpeta destino
        subfolder = None
        if old_ns and old_ns in NS_TO_SUBFOLDER:
            subfolder = NS_TO_SUBFOLDER[old_ns]
        else:
            # fallback: si no detecta namespace, o es desconocido, lo mandamos a CustomEntities
            # (puedes cambiar esta regla si quieres que falle duro)
            subfolder = "CustomEntities"
            if old_ns:
                unknown_ns.add(old_ns)

        new_ns = SUBFOLDER_TO_NEW_NS[subfolder]

        # Reescribir namespace
        if old_ns:
            code_out = rewrite_namespace(code, new_ns)
        else:
            # Si no hay namespace, no invento uno automáticamente porque puede romper el archivo.
            # Pero normalmente TODAS tus clases tienen namespace.
            code_out = code

        out_dir = OUTPUT_ROOT / subfolder
        out_dir.mkdir(parents=True, exist_ok=True)

        out_path = out_dir / fname
        out_path.write_text(code_out, encoding="utf-8")
        written += 1

    print(f"OK - Archivos generados: {written}")
    if unknown_ns:
        print("Namespaces no mapeados (se enviaron por defecto a CustomEntities):")
        for ns in sorted(unknown_ns):
            print(f" - {ns}")


if __name__ == "__main__":
    main()