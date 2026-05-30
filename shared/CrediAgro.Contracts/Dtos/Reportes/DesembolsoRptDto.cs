namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class DesembolsoRptDto
{
    public int SolicitudId { get; init; }

    public int ClienteId { get; init; }

    public int DesembolsoId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public decimal MontoCor { get; init; }

    public decimal MontoUsd { get; init; }

    public string Rubro { get; init; } = string.Empty;

    public decimal TipoCambio { get; init; }
}
