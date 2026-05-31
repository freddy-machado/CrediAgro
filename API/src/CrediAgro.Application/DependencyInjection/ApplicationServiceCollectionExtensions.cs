using CrediAgro.Application.Clientes.Interfaces;
using CrediAgro.Application.Clientes.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CrediAgro.Application.DependencyInjection;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Application services
        services.AddScoped<IClienteService, ClienteService>();

        // AutoMapper profiles in this assembly
        services.AddAutoMapper(typeof(ApplicationServiceCollectionExtensions).Assembly);

        return services;
    }
}
