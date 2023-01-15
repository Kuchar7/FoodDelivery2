﻿using FluentValidation;
using Restaurant.Application.Contracts;

namespace Restaurant.Application.DTOs.Restaurant.Validators
{
    internal class CommonRestaurantDtoValidator : AbstractValidator<IRestaurantDto>
    {
        private readonly ICuisineTypeRepository _cuisineTypeRepository;

        public CommonRestaurantDtoValidator(ICuisineTypeRepository cuisineTypeRepository)
        {
            _cuisineTypeRepository = cuisineTypeRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Province)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Street)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.PostalCode)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Matches("[0-9]{2}-[0-9]{3}").WithMessage("Wrong format for postal code.");

            RuleFor(p => p.CuisineTypesIds)
                .NotNull().WithMessage("{PropertyName} is required.");

            RuleForEach(p => p.CuisineTypesIds)
                .MustAsync(async (id, token) =>
                {
                    var exist = await _cuisineTypeRepository.Exist(id);
                    return exist;
                }).WithMessage("Cuisine type doesn't exist for the given ID ({PropertyValue}).");
        }
    }
}
