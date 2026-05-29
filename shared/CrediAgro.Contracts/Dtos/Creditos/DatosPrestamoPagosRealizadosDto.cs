namespace CrediAgro.Contracts.Dtos.Creditos;

public sealed class DatosPrestamoPagosRealizadosDto
{
    public int SolicitudId { get; init; }

    public string Rubro { get; init; } = string.Empty;

    public DateTime FechaInicia { get; init; }

    public DateTime FechaFin { get; init; }

    public decimal Interes { get; init; }

    public byte NoPagos { get; init; }

    public byte Plazo { get; init; }

    public decimal MontoAprobado { get; init; }

    public decimal MontoPagado { get; init; }
}
