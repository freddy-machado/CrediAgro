namespace CrediAgro.Contracts.Dtos.Pagos;

public sealed class CuotaPendientePagoDto
{
    public int Cuota { get; init; }

    public int AmortizacionId { get; init; }

    public DateTime FechaPago { get; init; }

    public int DiasVencidos { get; init; }

    public decimal SaldoAmortizacion { get; init; }

    public decimal AbonoAmortizacion { get; init; }

    public decimal SaldoMantenimiento { get; init; }

    public decimal AbonoMantenimiento { get; init; }

    public decimal SaldoInteres { get; init; }

    public decimal AbonoInteres { get; init; }

    public decimal Mora { get; init; }

    public decimal AbonoMora { get; init; }

    public decimal MontoPago { get; init; }

    public decimal MontoExhoneraMr { get; init; }

    public string Estatus { get; init; } = string.Empty;
}
