using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Installers
{
    public class MediatorInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(Startup).Assembly);

            var classTypes = typeof(Startup).Assembly.ExportedTypes.Select(x => x.GetTypeInfo()).Where(x => x.IsClass && !x.IsAbstract);

            foreach (var type in classTypes)
            {
                var interfaces = type.ImplementedInterfaces
                    .Select(x => x.GetTypeInfo())
                    .Where(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IRequestHandler<,>));

                foreach (var handlerType in interfaces)
                    services.AddTransient(handlerType.AsType(), type.AsType());
            }
        }
    }
}
