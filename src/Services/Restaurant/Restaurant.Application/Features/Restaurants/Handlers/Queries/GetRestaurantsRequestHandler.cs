using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts;
using Restaurant.Application.DTOs.Restaurant;
using Restaurant.Application.Features.Restaurants.Requests.Queries;

namespace Restaurant.Application.Features.Restaurants.NewFolder.Handlers.Queries
{
    public class GetRestaurantsRequestHandler : IRequestHandler<GetRestaurantsRequest, List<RestaurantDto>>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantsRequestHandler(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<List<RestaurantDto>> Handle(GetRestaurantsRequest request, CancellationToken cancellationToken)
        {
            var restaurants = await _restaurantRepository.GetAllRestaurants();
            return _mapper.Map<List<RestaurantDto>>(restaurants);
        }
    }
}
