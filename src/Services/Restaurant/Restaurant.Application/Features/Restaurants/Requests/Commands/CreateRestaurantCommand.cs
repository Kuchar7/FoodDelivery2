using MediatR;
using Restaurant.Application.DTOs.Restaurant;

namespace Restaurant.Application.Features.Restaurants.Requests.Commands
{
    public class CreateRestaurantCommand : IRequest<int>
    {
        public CreateRestaurantDto CreateRestaurantDto { get; init; }

        public CreateRestaurantCommand(CreateRestaurantDto createRestaurantDto)
        {
            CreateRestaurantDto = createRestaurantDto;
        }
    }
}
