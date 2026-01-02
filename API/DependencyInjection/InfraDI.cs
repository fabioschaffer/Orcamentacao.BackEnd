using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.Services;
using Infra.Data;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.DependencyInjection;

public static class InfraDI {

    public static IServiceCollection AddRepositories(this IServiceCollection services) {

        services.AddScoped<IPecaRepository, PecaRepository>();

        return services;
    }

    public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration configuration) {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(
                configuration.GetConnectionString("DefaultConnection")
            )
        );

        return services;
    }
}