using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts;
using Restaurant.Application.DTOs.Restaurant.Validators;
using Restaurant.Application.Exceptions;
using Restaurant.Application.Features.Restaurants.Requests.Commands;
using Restaurant.Domain.Entities;

namespace Restaurant.Application.Features.Restaurants.Handlers.Commands
{
    public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly ICuisineTypeRepository _cuisineTypeRepository;

        public CreateRestaurantCommandHandler(IMapper mapper, IRestaurantRepository restaurantRepository, ICuisineTypeRepository cuisineTypeRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _cuisineTypeRepository = cuisineTypeRepository;
        }
        public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateRestaurantDtoValidator(_cuisineTypeRepository);

            var validationResult = await validator.ValidateAsync(request.CreateRestaurantDto);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult);

            var newRestaurant = _mapper.Map<RestaurantEntity>(request.CreateRestaurantDto);
            var cuisineTypes = new List<RestaurantCuisineTypeEntity>();
            foreach (var typeId in request.CreateRestaurantDto.CuisineTypesIds)
            {
                cuisineTypes.Add(new RestaurantCuisineTypeEntity { CuisineTypeId = typeId });
            }

            newRestaurant.RestaurantCuisineTypes = cuisineTypes;
            await _restaurantRepository.CreateRestaurant(newRestaurant);
            return newRestaurant.Id;
        }
    }
}
