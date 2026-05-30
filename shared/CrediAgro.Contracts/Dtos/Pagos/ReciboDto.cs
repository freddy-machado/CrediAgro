namespace CrediAgro.Contracts.Dtos.Pagos;

public sealed class ReciboDto
{
    public int CuotaId { get; init; }

    public string NoRecibo { get; init; } = string.Empty;

    public string Cliente { get; init; } = string.Empty;

    public decimal MontoPagado { get; init; }

    public string Moneda { get; init; } = string.Empty;

    public string Concepto { get; init; } = string.Empty;

    public decimal TipoCambio { get; init; }

    public decimal Principal { get; init; }

    public decimal Mantenimiento { get; init; }

    public decimal Interes { get; init; }

    public DateTime FechaPago { get; init; }

    public string NoPrestamo { get; init; } = string.Empty;

    public string Rubro { get; init; } = string.Empty;

    public decimal Saldo { get; init; }

    public string MontoLetras { get; init; } = string.Empty;

    public string Fondo { get; init; } = string.Empty;
}
