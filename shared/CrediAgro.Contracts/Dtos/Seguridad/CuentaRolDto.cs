namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class CuentaRolDto
{
    public int CuentaId { get; init; }

    public int RolId { get; init; }

    public string Rol { get; init; } = string.Empty;

    public string Cuenta { get; init; } = string.Empty;
}
