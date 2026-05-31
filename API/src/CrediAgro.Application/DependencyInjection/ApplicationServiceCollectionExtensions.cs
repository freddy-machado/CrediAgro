using CrediAgro.Application.Clientes.Interfaces;
using CrediAgro.Application.Clientes.Services;
using CrediAgro.Application.Creditos.Interfaces;
using CrediAgro.Application.Creditos.Services;
using CrediAgro.Application.Pagos.Interfaces;
using CrediAgro.Application.Pagos.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CrediAgro.Application.DependencyInjection;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Application services
        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<ICreditoService, CreditoService>();
        services.AddScoped<IPagoCuotaService, PagoCuotaService>();

        // AutoMapper profiles in this assembly
        services.AddAutoMapper(typeof(ApplicationServiceCollectionExtensions).Assembly);

        return services;
    }
}
