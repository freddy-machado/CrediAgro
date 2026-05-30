namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class ServicioUsuarioModuloDto
{
    public int ServicioUsuarioId { get; init; }

    public int ModuloId { get; init; }

    public string ServicioUsuario { get; init; } = string.Empty;

    public string Modulo { get; init; } = string.Empty;
}
