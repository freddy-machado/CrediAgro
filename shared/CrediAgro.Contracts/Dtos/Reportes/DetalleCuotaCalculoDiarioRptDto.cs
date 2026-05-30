namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class DetalleCuotaCalculoDiarioRptDto
{
    public int SolicitudId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public decimal TasaInteres { get; init; }

    public decimal Comision { get; init; }

    public short Frecuencia { get; init; }

    public short PlazoMeses { get; init; }

    public short PagosAnios { get; init; }

    public short NumPagos { get; init; }

    public string Moneda { get; init; } = string.Empty;

    public decimal MontoApruebaCor { get; init; }

    public DateTime FechaPagado { get; init; }

    public string Estado { get; init; } = string.Empty;

    public decimal MontoTipoCambio { get; init; }

    public string Rubro { get; init; } = string.Empty;

    public string Proceso { get; init; } = string.Empty;

    public DateTime Fecha { get; init; }

    public decimal TipoCambio { get; init; }

    public decimal MontoEntregado { get; init; }

    public decimal MmtoValor { get; init; }

    public decimal AmortizacionPrincipal { get; init; }

    public decimal MontoAcumuladoAntes { get; init; }

    public decimal MontoAcumulado { get; init; }

    public DateTime FechaDesde { get; init; }

    public DateTime FechaHasta { get; init; }

    public short Dias { get; init; }

    public decimal InteresCorriente { get; init; }

    public decimal Moratorios { get; init; }

    public decimal MmtoInteres { get; init; }

    public decimal AmortizacionInteres { get; init; }

    public decimal InteresAcumulado { get; init; }

    public decimal SaldoTotal { get; init; }

    public string FuenteSaldos { get; init; } = string.Empty;

    public short EstadoId { get; init; }

    public int PagoCuotaId { get; init; }
}
