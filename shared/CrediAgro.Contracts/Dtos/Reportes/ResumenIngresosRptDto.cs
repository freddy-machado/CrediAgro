namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class ResumenIngresosRptDto
{
    public DateTime FechaPago { get; init; }

    public string NoRecibo { get; init; } = string.Empty;

    public string Rubro { get; init; } = string.Empty;

    public decimal TipoCambio { get; init; }

    public int SolicitudId { get; init; }

    public int ClienteId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public decimal PrincipalCor { get; init; }

    public decimal MmtoCor { get; init; }

    public decimal InteresCor { get; init; }

    public decimal TotalCor { get; init; }

    public decimal PrincipalDol { get; init; }

    public decimal MmtoDol { get; init; }

    public decimal InteresDol { get; init; }

    public decimal TotalDol { get; init; }

    public int FondoId { get; init; }

    public int RubroId { get; init; }

    public int ComarcaId { get; init; }
}
