using AutoMapper;
using CrediAgro.Application.Pagos.Interfaces;
using CrediAgro.Contracts.Dtos.Pagos;
using CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

namespace CrediAgro.Application.Pagos.Services;

public sealed class PagoCuotaService : IPagoCuotaService
{
    private readonly IPagoCuotaRepository _pagoCuotaRepository;
    private readonly IMapper _mapper;

    public PagoCuotaService(IPagoCuotaRepository pagoCuotaRepository, IMapper mapper)
    {
        _pagoCuotaRepository = pagoCuotaRepository;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<PagoCuotaDto>> ListaPagosCuotasPrestamoAsync(int creditoId, CancellationToken cancellationToken = default)
    {
        if (creditoId <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(creditoId), "creditoId debe ser mayor que 0.");
        }

        var entities = await _pagoCuotaRepository.ListaPagosCuotasPrestamoAsync(creditoId);
        return entities
            .Select(e => _mapper.Map<PagoCuotaDto>(e))
            .ToList();
    }

    public async Task<IReadOnlyList<CuotaPendientePagoDto>> CuotasPendientePagoAsync(
        int creditoId,
        DateTime fechaPago,
        decimal monto,
        CancellationToken cancellationToken = default)
    {
        if (creditoId <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(creditoId), "creditoId debe ser mayor que 0.");
        }

        if (monto < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(monto), "monto no puede ser negativo.");
        }

        // fechaPago: permitimos cualquier DateTime válido; la regla de negocio se puede refinar luego.
        var entities = await _pagoCuotaRepository.CuotasPendientePagoAsync(creditoId, fechaPago, monto);
        return entities
            .Select(e => _mapper.Map<CuotaPendientePagoDto>(e))
            .ToList();
    }
}
