using CrediAgro.Contracts.Dtos.Clientes;

namespace CrediAgro.Application.Clientes.Interfaces;

public interface IClienteService
{
    Task<IReadOnlyList<ClienteListItemDto>> ListadoClientesAsync(CancellationToken cancellationToken = default);
}
