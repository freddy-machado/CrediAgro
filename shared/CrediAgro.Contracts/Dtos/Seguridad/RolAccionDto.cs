namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class RolAccionDto
{
    public int RolAccionId { get; init; }

    public int RolId { get; init; }

    public int AccionId { get; init; }

    public string Rol { get; init; } = string.Empty;

    public string Accion { get; init; } = string.Empty;
}
