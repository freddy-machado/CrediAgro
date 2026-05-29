namespace CrediAgro.Contracts.Dtos.Clientes;

public sealed class ClienteTabDto
{
    // Nota: En el modelo actual (keyless/tab) estos campos vienen como string.
    // Se puede normalizar a DateOnly/DateTime más adelante cuando el origen lo permita.
    public string? FechaNacimiento { get; init; }

    public string? Cedula { get; init; }

    public string? Sexo { get; init; }

    public string? Municipio { get; init; }

    public string? Direccion { get; init; }

    public string? EstadoCivil { get; init; }

    public string? Profesion { get; init; }

    public byte[]? Foto { get; init; }
}
