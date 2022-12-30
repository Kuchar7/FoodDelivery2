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

        public async Task<RestaurantEntity> CreateRestaurant(RestaurantEntity restaurantEntity)
        {
            await _dbContext.AddAsync(restaurantEntity);
            await _dbContext.SaveChangesAsync();
            return restaurantEntity;
        }

        public async Task<IEnumerable<RestaurantEntity>> GetAllRestaurants()
        {
            return await _dbContext.Restaurants
                .Include(x => x.Dishes)
                .ThenInclude(x => x.DishType)
                .Include(x => x.RestaurantCuisineTypes)
                .ThenInclude(x => x.CuisineType)
                .ToListAsync();
        }

        public async Task<RestaurantEntity> GetRestaurant(int restaurantId)
        {
            return await _dbContext.Restaurants
                .Include(x => x.Dishes)
                .ThenInclude(x => x.DishType)
                .Include(x => x.RestaurantCuisineTypes)
                .ThenInclude(x => x.CuisineType)
                .FirstOrDefaultAsync(x => x.Id == restaurantId);
        }

        public async Task UpdateRestaurant(RestaurantEntity restaurantEntity)
        {
            _dbContext.Entry(restaurantEntity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
