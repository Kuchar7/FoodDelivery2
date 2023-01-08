using Restaurant.Application.DTOs.DishType;

namespace Restaurant.Application.DTOs.Dish
{
    public class DishDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DishTypeDto DishType { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get; set; }
    }
}
