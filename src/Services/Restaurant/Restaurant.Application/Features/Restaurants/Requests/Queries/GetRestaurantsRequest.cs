using MediatR;
using Restaurant.Application.DTOs.Restaurant;

namespace Restaurant.Application.Features.Restaurants.Requests.Queries
{
    public class GetRestaurantsRequest : IRequest<List<RestaurantDto>>
    {
    }
}
