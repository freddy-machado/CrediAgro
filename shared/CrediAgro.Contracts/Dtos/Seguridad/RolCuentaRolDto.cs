namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class RolCuentaRolDto
{
    public int CuentaId { get; init; }

    public string Cuenta { get; init; } = string.Empty;

    public int CuentaRolId { get; init; }
}
