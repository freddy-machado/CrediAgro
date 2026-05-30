namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class CarteraRptDto
{
    public int SolicitudId { get; init; }

    public int ClienteId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public decimal MontoCor { get; init; }

    public decimal MontoUsd { get; init; }

    public DateTime FechaEntrega { get; init; }

    public DateTime FechaVence { get; init; }

    public decimal InteresCor { get; init; }

    public decimal InteresDol { get; init; }

    public decimal MmtoCor { get; init; }

    public decimal MmtoDol { get; init; }

    public decimal PrincipalCor { get; init; }

    public decimal PrincipalDol { get; init; }

    public decimal SaldoCor { get; init; }

    public decimal SaldoDol { get; init; }

    public int FondoId { get; init; }

    public int RubroId { get; init; }

    public int ComarcaId { get; init; }

    public decimal SaldoInteresCor { get; init; }

    public decimal SaldoInteresDol { get; init; }

    public decimal SaldoAmCor { get; init; }

    public decimal SaldoAmDol { get; init; }
}
