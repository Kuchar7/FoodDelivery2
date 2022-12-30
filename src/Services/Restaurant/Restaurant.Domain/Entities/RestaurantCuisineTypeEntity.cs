namespace Restaurant.Domain.Entities
{
    public class RestaurantCuisineTypeEntity
    {
        public int RestaurantId { get; set; }
        public RestaurantEntity Restaurant { get; set; }
        public int CuisineTypeId { get; set; }
        public CuisineTypeEntity CuisineType { get; set; }
    }
}
