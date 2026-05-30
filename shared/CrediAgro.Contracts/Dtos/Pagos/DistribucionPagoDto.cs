namespace CrediAgro.Contracts.Dtos.Pagos;

public sealed class DistribucionPagoDto
{
    public int Indice { get; init; }

    public int SolicitudId { get; init; }

    public int PagoId { get; init; }

    public int NumeroCuota { get; init; }

    public DateTime FechaCorte { get; init; }

    public decimal TipoCambio { get; init; }

    public short DiasEntreFecha { get; init; }

    public decimal SaldoTotal { get; init; }

    public decimal DesembolsoActualizado { get; init; }

    public decimal PrincipalPagado { get; init; }

    public decimal SaldoDolares { get; init; }

    public decimal SaldoAmortizacion { get; init; }

    public decimal MontoPago { get; init; }

    public decimal MontoPagoAcumulado { get; init; }

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

    public decimal SaldoEres { get; init; }

    public decimal InteresDevengado { get; init; }

    public decimal InteresDevengadoAcumulado { get; init; }

    public decimal InteresAbonado { get; init; }

    public decimal InteresAbonadoAcumulado { get; init; }

    public decimal InteresPendiente { get; init; }

    public decimal InteresPendienteAcumulado { get; init; }

    public decimal MantenimientoDevengadoIc { get; init; }

    public decimal MantenimientoDevengadoAcumuladoIc { get; init; }

    public decimal MantenimientoAbonadoIc { get; init; }

    public decimal MantenimientoAbonadoAcumuladoIc { get; init; }

    public decimal MantenimientoPendienteIc { get; init; }

    public decimal MantenimientoPendienteAcumuladoIc { get; init; }

    public decimal AmortizacionTotal { get; init; }
}
