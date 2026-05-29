namespace CrediAgro.Contracts.Dtos.Creditos;

public sealed class CreditoCreateRequestDto
{
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

    // Auditoría (en el modelo actual es requerido). En API se puede tomar del usuario autenticado,
    // pero lo dejamos en el contrato para no acoplar todavía el mecanismo.
    public string UsuarioCreacion { get; init; } = string.Empty;
}
