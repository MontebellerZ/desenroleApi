using desenroleApi.Data.Repositories.Interfaces;
using desenroleApi.Data.Repositories;
using desenroleApi.Services.Interfaces;
using desenroleApi.Services;

namespace desenroleApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Registro dos Repositories
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IFaturaRepository, FaturaRepository>();

        // Registro dos Services
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<IFaturaService, FaturaService>();

        return services;
    }
}
