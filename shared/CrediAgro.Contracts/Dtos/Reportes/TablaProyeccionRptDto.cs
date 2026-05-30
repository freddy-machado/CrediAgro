namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class TablaProyeccionRptDto
{
    public int TablaProyeccionPagoId { get; init; }

    public int SolicitudId { get; init; }

    public byte NumeroCuota { get; init; }

    public DateTime FechaPago { get; init; }

    public decimal MontoPrincipal { get; init; }

    public decimal MontoPrincipalAbonado { get; init; }

    public decimal MontoMantenimientoPrincipal { get; init; }

    public decimal MontoMantenimientoAbonadoPrincipal { get; init; }

    public decimal MontoInteres { get; init; }

    public decimal MontoInteresAbonado { get; init; }

    public decimal MontoMora { get; init; }

    public decimal MontoMoraAbonado { get; init; }

    public decimal MontoMantenimientoInteres { get; init; }

    public decimal MontoMantenimientoInteresAbonado { get; init; }

    public decimal MontoTotal { get; init; }

    public decimal MontoPagado { get; init; }

    public decimal MontoSaldo { get; init; }
}
