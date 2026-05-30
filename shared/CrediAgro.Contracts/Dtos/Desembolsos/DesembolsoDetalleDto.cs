namespace CrediAgro.Contracts.Dtos.Desembolsos;

public sealed class DesembolsoDetalleDto
{
    public int DesembolsoId { get; init; }

    public string Cliente { get; init; } = string.Empty;

    public byte[]? Foto { get; init; }

    // En el origen viene como string (formateado). Se puede normalizar luego.
    public string? FechaDesembolso { get; init; }

    public decimal MontoDesembolso { get; init; }
}
