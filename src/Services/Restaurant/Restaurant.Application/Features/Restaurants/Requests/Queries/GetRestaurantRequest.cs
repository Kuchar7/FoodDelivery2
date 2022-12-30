using MediatR;
using Restaurant.Application.DTOs.Restaurant;

namespace Restaurant.Application.Features.Restaurants.Requests.Queries
{
    public class GetRestaurantRequest : IRequest<RestaurantDto>
    {
        public GetRestaurantRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
