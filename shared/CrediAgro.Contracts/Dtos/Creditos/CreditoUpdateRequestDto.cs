namespace CrediAgro.Contracts.Dtos.Creditos;

public sealed class CreditoUpdateRequestDto
{
    // nScrSolicitudID
    public int SolicitudId { get; init; }

    public int ClienteId { get; init; }

    public int MonedaId { get; init; }

    public string? NumeroSolicitud { get; init; }

    public DateTime FechaSolicitud { get; init; }

    public DateTime? FechaAprobacion { get; init; }

    public DateTime? FechaLiquidacion { get; init; }

    public int ParidadCambiariaId { get; init; }

    public int RubroDetalleId { get; init; }

    public int? NegocioClienteId { get; init; }

    public decimal? MontoSolicitaC { get; init; }

    public decimal? MontoSolicitaU { get; init; }

    public decimal? MontoApruebaC { get; init; }

    public decimal? MontoApruebaU { get; init; }

    public int EstadoSolicitudId { get; init; }

    public int? FondoId { get; init; }

    // Auditoría
    public string? UsuarioModificacion { get; init; }
}
