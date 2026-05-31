using AutoMapper;
using CrediAgro.Application.Creditos.Interfaces;
using CrediAgro.Contracts.Dtos.Creditos;
using CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

namespace CrediAgro.Application.Creditos.Services;

public sealed class CreditoService : ICreditoService
{
    private readonly ICreditoRepository _creditoRepository;
    private readonly IMapper _mapper;

    public CreditoService(ICreditoRepository creditoRepository, IMapper mapper)
    {
        _creditoRepository = creditoRepository;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<CreditoListItemDto>> ListadoCreditosAsync(CancellationToken cancellationToken = default)
    {
        var entities = await _creditoRepository.ListadoCreditosAsync();
        return entities
            .Select(e => _mapper.Map<CreditoListItemDto>(e))
            .ToList();
    }
}
