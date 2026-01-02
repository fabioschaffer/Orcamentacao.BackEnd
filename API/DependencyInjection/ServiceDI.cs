using Application.Interfaces.Service;
using Application.Services;

namespace API.DependencyInjection;

public static class ServiceDI {

        public static IServiceCollection AddServices(this IServiceCollection services) {

            services.AddScoped<IPecaService, PecaService>();

            return services;
        }
}