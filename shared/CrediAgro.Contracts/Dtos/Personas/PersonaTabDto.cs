namespace CrediAgro.Contracts.Dtos.Personas;

public sealed class PersonaTabDto
{
    // Nota: en el origen (tab) estos campos vienen como string.
    public string? FechaNacimiento { get; init; }

    public string? Cedula { get; init; }

    public string? Sexo { get; init; }

    public string? Municipio { get; init; }

    public string? Direccion { get; init; }

    public string? EstadoCivil { get; init; }

    public string? Profesion { get; init; }

    public byte[]? Foto { get; init; }
}
