using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace YellowAdvert.Cqrs.Registration;

public static class Setup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddMediatR(x => {
            x.Lifetime = ServiceLifetime.Scoped;
            x.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
        });
    }
}
