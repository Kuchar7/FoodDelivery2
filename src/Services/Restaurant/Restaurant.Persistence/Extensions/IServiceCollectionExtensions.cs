using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Application.Contracts;
using Restaurant.Persistence.Repositories;

namespace Restaurant.Persistence.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<ICuisineTypeRepository, CuisineTypeRepository>();
            services.AddDbContext<RestaurantDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RestaurantConnectionString")
            ));

            return services;
        }
    }
}
