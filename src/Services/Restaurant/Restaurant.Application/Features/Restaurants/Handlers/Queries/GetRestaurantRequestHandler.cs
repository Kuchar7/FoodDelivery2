using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts;
using Restaurant.Application.DTOs.Restaurant;
using Restaurant.Application.Exceptions;
using Restaurant.Application.Features.Restaurants.Requests.Queries;

namespace Restaurant.Application.Features.Restaurants.Handlers.Queries
{
    public class GetRestaurantRequestHandler : IRequestHandler<GetRestaurantRequest, RestaurantDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantRequestHandler(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<RestaurantDto> Handle(GetRestaurantRequest request, CancellationToken cancellationToken)
        {
            var restaurant = await _restaurantRepository.GetRestaurant(request.Id);
            if (restaurant == null)
                throw new NotFoundException(nameof(restaurant), request.Id);
            return _mapper.Map<RestaurantDto>(restaurant);
        }
    }
}
