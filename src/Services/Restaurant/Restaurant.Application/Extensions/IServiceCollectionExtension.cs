using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Restaurant.Application.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
