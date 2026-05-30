namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class RptDistribucionPagoDto
{
    public int SolicitudId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public decimal MontoAprueba { get; init; }

    public string Deslizamiento { get; init; } = string.Empty;

    public DateTime FechaPagado { get; init; }

    public byte PlazoMeses { get; init; }

    public decimal TasaInteres { get; init; }

    public DateTime Vence { get; init; }

    public byte Frecuencia { get; init; }

    public byte NumPagos { get; init; }

    public decimal MontoTipoCambio { get; init; }

    public string Rubro { get; init; } = string.Empty;

    public int Indice { get; init; }

    public DateTime FechaCorte { get; init; }

    public decimal TipoCambio { get; init; }

    public short DiasEntreFecha { get; init; }

    public decimal SaldoTotal { get; init; }

    public decimal DesembolsoActualizado { get; init; }

    public decimal SaldoAmortizacion { get; init; }

    public decimal MantenimientoDevengadoAm { get; init; }

    public decimal MantenimientoDevengadoAcumuladoAm { get; init; }

    public decimal MantenimientoAbonadoAm { get; init; }

    public decimal MantenimientoAbonadoAcumuladoAm { get; init; }

    public decimal MantenimientoPendienteAm { get; init; }

    public decimal MantenimientoPendienteAcumuladoAm { get; init; }

    public decimal AmortizacionDevengada { get; init; }

    public decimal AmortizacionDevengadaAcumulada { get; init; }

    public decimal AmortizacionAbonada { get; init; }

    public decimal AmortizacionAbonadaAcumulada { get; init; }

    public decimal AmortizacionPendiente { get; init; }

    public decimal AmortizacionPendienteAcumulado { get; init; }

    public decimal InteresDevengado { get; init; }

    public decimal InteresDevengadoAcumulado { get; init; }

    public decimal InteresAbonado { get; init; }

    public decimal InteresAbonadoAcumulado { get; init; }

    public decimal InteresPendiente { get; init; }

    public decimal InteresPendienteAcumulado { get; init; }
}
