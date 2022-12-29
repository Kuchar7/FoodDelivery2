using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Contracts
{
    public interface IRestaurantRepository
    {
        Task<RestaurantEntity> GetRestaurant(int restaurantId);
        Task CreateRestaurant(RestaurantEntity restaurantEntity);
        Task UpdateRestaurant(RestaurantEntity restaurantEntity);
    }
}
