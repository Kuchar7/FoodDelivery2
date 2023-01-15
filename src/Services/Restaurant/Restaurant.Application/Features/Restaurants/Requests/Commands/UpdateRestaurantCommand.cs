using MediatR;
using Restaurant.Application.DTOs.Restaurant;

namespace Restaurant.Application.Features.Restaurants.Requests.Commands
{
    public class UpdateRestaurantCommand : IRequest
    {
        public UpdateRestaurantDto UpdateRestaurantDto { get; set; }

        public UpdateRestaurantCommand(UpdateRestaurantDto updateRestaurantDto)
        {
            UpdateRestaurantDto = updateRestaurantDto;
        }
    }
}
