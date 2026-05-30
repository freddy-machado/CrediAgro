namespace CrediAgro.Contracts.Dtos.Seguridad;

public sealed class CuentaRolAplicacionDto
{
    public int CuentaId { get; init; }

    public int RolId { get; init; }

    public string Rol { get; init; } = string.Empty;

    public string Cuenta { get; init; } = string.Empty;

    public string Aplicacion { get; init; } = string.Empty;

    public bool Activa { get; init; }
}
