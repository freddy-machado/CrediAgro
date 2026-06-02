namespace CrediAgro.Contracts.Dtos.Pagos;

public sealed class CreatePagoCuotaRequestDto
{
    // Se envía en ruta, pero lo duplicamos en el request para trazabilidad.
    public int CreditoId { get; init; }

    public DateTime FechaPago { get; init; }

    public decimal MontoPago { get; init; }

    public string ConceptoPago { get; init; } = string.Empty;

    // Si viene vacío, el backend puede generar el número/recibo.
    public string? NumeroRecibo { get; init; }

    public int MonedaId { get; init; }

    public bool CondonaMora { get; init; }

    public decimal MontoExoneraIC { get; init; }

    public decimal MontoExoneraMmto { get; init; }

    public string MotivoExoneracion { get; init; } = string.Empty;

    public decimal TipoCambio { get; init; }
}
