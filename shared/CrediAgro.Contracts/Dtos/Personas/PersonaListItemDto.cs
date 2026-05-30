namespace CrediAgro.Contracts.Dtos.Personas;

public sealed class PersonaListItemDto
{
    public int PersonaId { get; init; }

    public string? Nombre1 { get; init; }

    public string? Nombre2 { get; init; }

    public string? Apellido1 { get; init; }

    public string? Apellido2 { get; init; }

    public string? Direccion { get; init; }

    public bool Activo { get; init; }

    public string? Sexo { get; init; }

    public string? Municipio { get; init; }

    public string? Cedula { get; init; }

    // En el origen actual viene como string (formateado). Se puede normalizar luego.
    public string? FechaNacimiento { get; init; }

    public string? EstadoCivil { get; init; }

    public string? Profesion { get; init; }
}
