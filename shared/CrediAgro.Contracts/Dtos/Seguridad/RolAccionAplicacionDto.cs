namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class RolAccionAplicacionDto
{
    public string Servicio { get; init; } = string.Empty;

    public string Modulo { get; init; } = string.Empty;

    public string Accion { get; init; } = string.Empty;

    public int AccionId { get; init; }

    public bool Activa { get; init; }
}
