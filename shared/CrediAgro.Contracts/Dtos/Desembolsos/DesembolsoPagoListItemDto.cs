namespace CrediAgro.Contracts.Dtos.Desembolsos;

public sealed class DesembolsoPagoListItemDto
{
    public int DesembolsoPagoId { get; init; }

    public int DesembolsoId { get; init; }

    // En el origen viene como string (formateado). Se puede normalizar luego.
    public string? Fecha { get; init; }

    public decimal Monto { get; init; }

    public string TipoPago { get; init; } = string.Empty;

    public int TipoPagoId { get; init; }
}
