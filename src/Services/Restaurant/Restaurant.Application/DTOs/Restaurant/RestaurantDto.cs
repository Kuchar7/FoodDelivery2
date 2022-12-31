using Restaurant.Application.DTOs.CuisineType;
using Restaurant.Application.DTOs.Dish;

namespace Restaurant.Application.DTOs.Restaurant
{
    public class RestaurantDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public List<DishDto> Dishes { get; set; }
        public List<CuisineTypeDto> CuisinesTypes { get; set; }
    }
}
