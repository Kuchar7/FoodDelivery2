using Restaurant.Domain.Common;

namespace Restaurant.Domain.Entities
{
    public class RestaurantEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public IList<RestaurantCuisineTypeEntity> RestaurantCuisineTypes { get; set; }
        public IList<DishEntity> Dishes { get; set; }
    }
}
