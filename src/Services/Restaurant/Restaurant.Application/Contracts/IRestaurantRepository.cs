using Restaurant.Domain.Entities;

namespace Restaurant.Application.Contracts
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<RestaurantEntity>> GetAllRestaurants();
        Task<RestaurantEntity> GetRestaurant(int restaurantId);
        Task<RestaurantEntity> CreateRestaurant(RestaurantEntity restaurantEntity);
        Task UpdateRestaurant(RestaurantEntity restaurantEntity);
    }
}
