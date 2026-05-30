namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class RolAplicacionDto
{
    public int AplicacionId { get; init; }

    public int RolId { get; init; }

    public string Aplicacion { get; init; } = string.Empty;

    public string Rol { get; init; } = string.Empty;
}
