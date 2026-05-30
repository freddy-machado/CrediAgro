namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class RptDatosPrestamoClienteDto
{
    public int SolicitudId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public decimal MontoApruebaCor { get; init; }

    public string Deslizamiento { get; init; } = string.Empty;

    public DateTime FechaPagado { get; init; }

    public byte PlazoMeses { get; init; }

    public decimal TasaInteres { get; init; }

    public DateTime Vence { get; init; }

    public byte Frecuencia { get; init; }

    public byte NumPagos { get; init; }

    public decimal MontoTipoCambio { get; init; }

    public string Rubro { get; init; } = string.Empty;
}
