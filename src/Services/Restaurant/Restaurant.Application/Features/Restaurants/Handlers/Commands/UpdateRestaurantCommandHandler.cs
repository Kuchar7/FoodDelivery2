using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts;
using Restaurant.Application.DTOs.Restaurant.Validators;
using Restaurant.Application.Exceptions;
using Restaurant.Application.Features.Restaurants.Requests.Commands;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Features.Restaurants.Handlers.Commands
{
    public class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly ICuisineTypeRepository _cuisineTypeRepository;

        public UpdateRestaurantCommandHandler(IMapper mapper, IRestaurantRepository restaurantRepository, ICuisineTypeRepository cuisineTypeRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _cuisineTypeRepository = cuisineTypeRepository;
        }

        public async Task<Unit> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateRestaurantDtoValidator(_cuisineTypeRepository);
            var validatorResult = await validator.ValidateAsync(request.UpdateRestaurantDto);
            if (!validatorResult.IsValid)
                throw new ValidationException(validatorResult);

            var restaurant = await _restaurantRepository.GetRestaurant(request.UpdateRestaurantDto.Id);
            if (restaurant == null)
                throw new NotFoundException(nameof(restaurant), request.UpdateRestaurantDto.Id);

            _mapper.Map(request.UpdateRestaurantDto, restaurant);
            restaurant.RestaurantCuisineTypes.Clear();
            foreach (var typeId in request.UpdateRestaurantDto.CuisineTypesIds)
            {
                restaurant.RestaurantCuisineTypes.Add(new RestaurantCuisineTypeEntity { CuisineTypeId = typeId });
            }
            await _restaurantRepository.UpdateRestaurant(restaurant);
            return Unit.Value;
        }
    }
}
