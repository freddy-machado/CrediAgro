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

        var entities = await _pagoCuotaRepository.CuotasPendientePagoAsync(creditoId, fechaPago, monto);
        return entities
            .Select(e => _mapper.Map<CuotaPendientePagoDto>(e))
            .ToList();
    }

    public async Task<CreatePagoCuotaResponseDto> PagarCuotaPrestamoAsync(
        int creditoId,
        CreatePagoCuotaRequestDto request,
        string usuario,
        CancellationToken cancellationToken = default)
    {
        if (creditoId <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(creditoId), "creditoId debe ser mayor que 0.");
        }

        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        if (request.CreditoId != 0 && request.CreditoId != creditoId)
        {
            throw new ArgumentException("El creditoId de la ruta no coincide con el request.", nameof(request));
        }

        if (request.MontoPago <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(request.MontoPago), "MontoPago debe ser mayor que 0.");
        }

        if (request.MonedaId <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(request.MonedaId), "MonedaId debe ser mayor que 0.");
        }

        if (request.TipoCambio <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(request.TipoCambio), "TipoCambio debe ser mayor que 0.");
        }

        var numeroRecibo = request.NumeroRecibo;
        if (string.IsNullOrWhiteSpace(numeroRecibo))
        {
            numeroRecibo = await _pagoCuotaRepository.ObtenerNumeroPagoCuotaAsync();
        }

        var pagoId = await _pagoCuotaRepository.PagarCuotaPrestamoAsync(
            creditoId,
            request.FechaPago,
            request.MontoPago,
            request.ConceptoPago,
            numeroRecibo,
            request.MonedaId,
            usuario,
            request.CondonaMora,
            request.MontoExoneraIC,
            request.MontoExoneraMmto,
            request.MotivoExoneracion,
            request.TipoCambio);

        return new CreatePagoCuotaResponseDto
        {
            PagoId = pagoId,
            NumeroRecibo = numeroRecibo,
        };
    }
}
