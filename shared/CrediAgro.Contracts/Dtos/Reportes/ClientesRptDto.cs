namespace CrediAgro.Contracts.Dtos.Reportes;

public sealed class ClientesRptDto
{
    public int ClienteId { get; init; }

    public string? CodigoCliente { get; init; }

    public int PersonaId { get; init; }

    public string NombresApellidos { get; init; } = string.Empty;

    public string? Sexo { get; init; }

    public string? Direccion { get; init; }

    public bool Trabaja { get; init; }

    public string? LugarTrabajo { get; init; }

    public string? DireccionTrabajo { get; init; }

    public string? Puesto { get; init; }

    public decimal SueldoMensual { get; init; }

    public string? Observaciones { get; init; }

    public string? PrestamoActivo { get; init; }

    public DateTime FechaDesdeDireccion { get; init; }

    public DateTime FechaHastaDireccion { get; init; }

    public DateTime FechaNacApertura { get; init; }

    public string? Telefono1 { get; init; }

    public string? Celular1 { get; init; }

    public string? NumeroCedula { get; init; }

    public string? Siglas { get; init; }

    public string? NumeroRuc { get; init; }

    public string? Email { get; init; }

    public byte[]? Foto { get; init; }

    public int Edad { get; init; }

    public string? EstadoCivil { get; init; }

    public string? Escolaridad { get; init; }

    public string? Profesion { get; init; }

    public string? TipoVivienda { get; init; }

    public string? Municipio { get; init; }

    public string? PeriodoDireccion { get; init; }
}
