using AutoMapper;
using CrediAgro.Application.Clientes.Interfaces;
using CrediAgro.Contracts.Dtos.Clientes;
using CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

namespace CrediAgro.Application.Clientes.Services;

public sealed class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IMapper _mapper;

    public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
    {
        _clienteRepository = clienteRepository;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<ClienteListItemDto>> ListadoClientesAsync(CancellationToken cancellationToken = default)
    {
        // Regla/validación de negocio: por ahora solo listar.
        // (Más adelante aquí se agregan filtros/seguridad/paginación)

        var entities = await _clienteRepository.ListadoClientesAsync();
        return entities
            .Select(e => _mapper.Map<ClienteListItemDto>(e))
            .ToList();
    }

    public async Task<IReadOnlyList<ClienteComboItemDto>> ListadoClientesComboAsync(CancellationToken cancellationToken = default)
    {
        var entities = await _clienteRepository.ListadoClientesComboAsync();
        return entities
            .Select(e => _mapper.Map<ClienteComboItemDto>(e))
            .ToList();
    }
}
