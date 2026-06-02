namespace CrediAgro.Contracts.Dtos.Pagos;

public sealed class CreatePagoCuotaResponseDto
{
    public int PagoId { get; init; }

    public string NumeroRecibo { get; init; } = string.Empty;
}
