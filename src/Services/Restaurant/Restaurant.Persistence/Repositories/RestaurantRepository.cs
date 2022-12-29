using Microsoft.EntityFrameworkCore;
using Restaurant.Application.Contracts;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Persistence.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantDbContext _dbContext;

        public RestaurantRepository(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateRestaurant(RestaurantEntity restaurantEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<RestaurantEntity> GetRestaurant(int restaurantId)
        {
            return await _dbContext.Restaurants
                .Include(x => x.Dishes)
                .Include(x => x.RestaurantCuisineTypes)
                .FirstOrDefaultAsync(x => x.Id == restaurantId);
        }

        public Task UpdateRestaurant(RestaurantEntity restaurantEntity)
        {
            throw new NotImplementedException();
        }
    }
}
