using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.Services;
using Infra.Repositories;

namespace API.DependencyInjection;

public static class InfraDI {

    public static IServiceCollection AddRepositories(this IServiceCollection services) {

        services.AddScoped<IPecaRepository, PecaRepository>();

        return services;
    }
}
