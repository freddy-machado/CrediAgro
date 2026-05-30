namespace CrediAgro.Contracts.Dtos.Pagos;

public sealed class PagoCuotaDto
{
    public int PagoId { get; init; }

    public int SolicitudId { get; init; }

    public DateTime FechaPago { get; init; }

    public string NumeroDocumento { get; init; } = string.Empty;

    public int TablaPagoId { get; init; }

    public byte NumeroCuota { get; init; }

    public decimal Principal { get; init; }

    public decimal Interes { get; init; }

    public decimal Mora { get; init; }

    public decimal Mantenimiento { get; init; }

    public decimal Total { get; init; }
}
