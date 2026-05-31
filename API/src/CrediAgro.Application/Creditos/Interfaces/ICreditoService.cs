using CrediAgro.Contracts.Dtos.Creditos;

namespace CrediAgro.Application.Creditos.Interfaces;

public interface ICreditoService
{
    Task<IReadOnlyList<CreditoListItemDto>> ListadoCreditosAsync(CancellationToken cancellationToken = default);
}
