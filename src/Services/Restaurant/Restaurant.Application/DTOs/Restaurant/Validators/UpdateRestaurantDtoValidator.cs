using FluentValidation;
using Restaurant.Application.Contracts;

namespace Restaurant.Application.DTOs.Restaurant.Validators
{
    public class UpdateRestaurantDtoValidator : AbstractValidator<UpdateRestaurantDto>
    {
        private readonly ICuisineTypeRepository _cuisineTypeRepository;
        public UpdateRestaurantDtoValidator(ICuisineTypeRepository cuisineTypeRepository)
        {
            _cuisineTypeRepository = cuisineTypeRepository;

            Include(new CommonRestaurantDtoValidator(_cuisineTypeRepository));
            RuleFor(x => x.Id)
                .NotNull()
                .WithMessage("{PropertyName} is required.");
        }
    }
}