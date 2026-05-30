namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class AccionServicioUsuarioDto
{
    public int AccionId { get; init; }

    public int ServicioUsuarioId { get; init; }

    public string Accion { get; init; } = string.Empty;

    public string ServicioUsuario { get; init; } = string.Empty;

    public bool Activo { get; init; }
}
