using Restaurant.Application.Contracts;
using Restaurant.Domain.Entities;

namespace Restaurant.Persistence.Repositories
{
    public class CuisineTypeRepository : ICuisineTypeRepository
    {
        private readonly RestaurantDbContext _dbContext;

        public CuisineTypeRepository(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddCuisineTypesToRestaurant(string restaurantId, int[] cuisineTypeIds)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CuisineTypeEntity>> GetCuisineTypesByRestaurantId(string restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCuisineTypesFromRestaurant(string restaurantId, int[] cuisineTypeIds)
        {
            throw new NotImplementedException();
        }
    }
}
