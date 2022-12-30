using Restaurant.Domain.Common;

namespace Restaurant.Domain.Entities
{
    public class CuisineTypeEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<RestaurantCuisineTypeEntity> RestaurantCuisineTypes { get; set; }
    }
}
