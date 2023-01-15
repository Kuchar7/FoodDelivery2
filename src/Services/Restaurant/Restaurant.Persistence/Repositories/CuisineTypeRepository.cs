using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> Exist(int id)
        {
            return await _dbContext.CuisineTypes.AnyAsync(x => x.Id == id);
        }
    }
}
