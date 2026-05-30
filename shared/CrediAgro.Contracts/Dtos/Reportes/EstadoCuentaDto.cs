namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class EstadoCuentaDto
{
    public int SolicitudId { get; init; }

    public int ClienteId { get; init; }

    public string Nombre1 { get; init; } = string.Empty;

    public string Nombre2 { get; init; } = string.Empty;

    public string Apellido1 { get; init; } = string.Empty;

    public string Apellido2 { get; init; } = string.Empty;

    public decimal MontoApruebaCor { get; init; }

    public DateTime FechaPagado { get; init; }

    public DateTime FechaPago { get; init; }

    public string Rubro { get; init; } = string.Empty;

    public decimal TasaInteres { get; init; }

    public byte Plazo { get; init; }

    public byte PlazoMeses { get; init; }

    public byte PagosAnios { get; init; }

    public int Indice { get; init; }

    public DateTime FechaCorte { get; init; }

    public int PagoId { get; init; }

    public decimal TipoCambio { get; init; }

    public decimal MantenimientoDevengadoAm { get; init; }

    public decimal MantenimientoAbonadoAm { get; init; }

    public decimal AmortizacionAbonada { get; init; }

    public decimal DesembolsoActualizado { get; init; }

    public short DiasEntreFecha { get; init; }

    public decimal InteresDevengadoAcumulado { get; init; }

    public decimal InteresAbonado { get; init; }

    public decimal SaldoTotal { get; init; }

    public decimal MontoPago { get; init; }
}
