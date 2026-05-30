namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class ModuloAplicacionDto
{
    public int AplicacionId { get; init; }

    public int ModuloId { get; init; }

    public string Aplicacion { get; init; } = string.Empty;

    public string Modulo { get; init; } = string.Empty;
}
