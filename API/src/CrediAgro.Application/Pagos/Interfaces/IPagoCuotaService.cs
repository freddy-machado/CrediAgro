using CrediAgro.Contracts.Dtos.Pagos;

namespace CrediAgro.Application.Pagos.Interfaces;

public interface IPagoCuotaService
{
    Task<IReadOnlyList<PagoCuotaDto>> ListaPagosCuotasPrestamoAsync(int creditoId, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<CuotaPendientePagoDto>> CuotasPendientePagoAsync(
        int creditoId,
        DateTime fechaPago,
        decimal monto,
        CancellationToken cancellationToken = default);

    Task<CreatePagoCuotaResponseDto> PagarCuotaPrestamoAsync(
        int creditoId,
        CreatePagoCuotaRequestDto request,
        string usuario,
        CancellationToken cancellationToken = default);
}
