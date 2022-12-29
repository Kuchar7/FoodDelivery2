using Restaurant.Application.Contracts;

namespace Restaurant.Persistence.Repositories
{
    public class CuisineTypeRepository : ICuisineTypeRepository
    {
        private readonly RestaurantDbContext _dbContext;

        public CuisineTypeRepository(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
