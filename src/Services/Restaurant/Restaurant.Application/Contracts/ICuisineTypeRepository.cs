namespace Restaurant.Application.Contracts
{
    public interface ICuisineTypeRepository
    {
        //Task<IEnumerable<CuisineTypeEntity>> GetCuisineTypesByRestaurantId(string restaurantId);
        //Task AddCuisineTypesToRestaurant(string restaurantId, int[] cuisineTypeIds);
        //Task RemoveCuisineTypesFromRestaurant(string restaurantId, int[] cuisineTypeIds);
        Task<bool> Exist(int id);

    }
}
