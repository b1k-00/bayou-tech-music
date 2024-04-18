using Application.Interfaces;
using Application.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServicesRegistration
{
    /// <summary>
    /// Extension method to register anything needed from this Application layer with the ServiceCollection
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        //Registers the DbContext with our DI container
        services.AddDbContext<BayouTechDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("BayouTechMusicDb"))
        );

        //Registers the Generic Repository. Registering this way allows us to use the GenericRepository
        //with any type in our code that doesn't have a specific repository implementation.
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        //Register all of the other repositories here
        //services.AddScoped<IDadJokeRepository, DadJokeRepository>();




        return services;
    }
}
