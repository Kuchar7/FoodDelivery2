﻿using FluentValidation;
using Restaurant.Application.Contracts;

namespace Restaurant.Application.DTOs.Restaurant.Validators
{
    public class CreateRestaurantDtoValidator : AbstractValidator<CreateRestaurantDto>
    {
        private readonly ICuisineTypeRepository _cuisineTypeRepository;

        public CreateRestaurantDtoValidator(ICuisineTypeRepository cuisineTypeRepository)
        {
            _cuisineTypeRepository = cuisineTypeRepository;

            Include(new CommonRestaurantDtoValidator(_cuisineTypeRepository));
        }
    }
}
