namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class TablaPagoRptDto
{
    public int SolicitudId { get; init; }

    public int ClienteId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public decimal MontoCor { get; init; }

    public decimal MontoUsd { get; init; }

    public decimal TasaInteres { get; init; }

    public byte Plazo { get; init; }

    public byte NumPagos { get; init; }

    public string Frecuencia { get; init; } = string.Empty;

    public DateTime FechaEntrega { get; init; }

    public DateTime FechaVence { get; init; }

    public decimal TipoCambio { get; init; }

    public decimal PorDeslizamiento { get; init; }

    public byte NoCuota { get; init; }

    public DateTime FechaPago { get; init; }

    public decimal Principal { get; init; }

    public decimal Mmto { get; init; }

    public decimal MontoInteres { get; init; }

    public decimal Total { get; init; }

    public decimal Saldo { get; init; }
}
