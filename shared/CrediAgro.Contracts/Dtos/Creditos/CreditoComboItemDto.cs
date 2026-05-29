namespace CrediAgro.Contracts.Dtos.Creditos;

public sealed class CreditoComboItemDto
{
    public int CreditoId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    // En el origen actual viene como string (por ejemplo, formateado para UI). Se puede normalizar luego.
    public string? FechaSolicitud { get; init; }

    public string? Rubro { get; init; }

    public decimal MontoSolicitado { get; init; }

    public decimal MontoAprobado { get; init; }

    public string? EstadoSolicitud { get; init; }

    public string? Moneda { get; init; }
}
