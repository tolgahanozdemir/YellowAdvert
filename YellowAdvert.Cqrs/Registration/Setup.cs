using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YellowAdvert.Cqrs.Handler;

namespace YellowAdvert.Cqrs.Registration
{
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
}
