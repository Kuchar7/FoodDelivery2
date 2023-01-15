namespace Restaurant.Application.DTOs.Restaurant
{
    public class UpdateRestaurantDto : IRestaurantDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public List<int> CuisineTypesIds { get; set; }
    }
}
