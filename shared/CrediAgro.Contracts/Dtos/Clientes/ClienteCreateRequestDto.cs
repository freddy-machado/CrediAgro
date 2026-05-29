namespace CrediAgro.Contracts.Dtos.Clientes;

public sealed class ClienteCreateRequestDto
{
    public string? CodigoCliente { get; init; }

    public int PersonaId { get; init; }

    public bool? Trabaja { get; init; }

    public string? LugarTrabajo { get; init; }

    public string? DireccionTrabajo { get; init; }

    public int? PuestoId { get; init; }

    public decimal? SueldoMensual { get; init; }

    public int? ViviendaId { get; init; }

    public int? PromotorId { get; init; }

    public string? Observaciones { get; init; }
}
