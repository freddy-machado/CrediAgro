namespace CrediAgro.Contracts.Dtos.Clientes;

public sealed class ClienteListItemDto
{
    public int ClienteId { get; init; }

    public int PersonaId { get; init; }

    public string ClienteName { get; init; } = string.Empty;

    public string? Municipio { get; init; }

    public string? LugarTrabajo { get; init; }

    public string? Puesto { get; init; }

    public string? Observacion { get; init; }
}
