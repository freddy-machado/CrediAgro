namespace CrediAgro.Contracts.Dtos.Documentos;

public sealed class DocumentoDto
{
    public int DocumentoId { get; init; }

    public string TipoDocumento { get; init; } = string.Empty;

    public string NombreDocumento { get; init; } = string.Empty;

    public byte[]? Foto { get; init; }
}
