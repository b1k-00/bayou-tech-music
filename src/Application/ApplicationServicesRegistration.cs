using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationServicesRegistration
{
    /// <summary>
    /// Extension method to register anything needed from this Application layer with the ServiceCollection
    /// </summary>
    /// <param name="services"></param>
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        //registers the AutoMapper profiles
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //registers Mediatr
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
