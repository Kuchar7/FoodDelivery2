using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Contracts
{
    public interface ICuisineTypeRepository
    {
        Task<IEnumerable<CuisineTypeEntity>> GetCuisineTypesByRestaurantId(string restaurantId);
        Task AddCuisineTypesToRestaurant(string restaurantId, int[] cuisineTypeIds);
        Task RemoveCuisineTypesFromRestaurant(string restaurantId, int[] cuisineTypeIds);
    }
}
