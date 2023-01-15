using AutoMapper;
using Restaurant.Application.DTOs.CuisineType;
using Restaurant.Application.DTOs.Dish;
using Restaurant.Application.DTOs.DishType;
using Restaurant.Application.DTOs.Restaurant;
using Restaurant.Domain.Entities;

namespace Restaurant.Application.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Restaurant
            CreateMap<RestaurantEntity, RestaurantDto>()
                .ForMember(x => x.CuisinesTypes, opt => opt.MapFrom(x => x.RestaurantCuisineTypes.Select(y => y.CuisineType).ToList()))
                .ReverseMap();

            CreateMap<CreateRestaurantDto, RestaurantEntity>();
            CreateMap<UpdateRestaurantDto, RestaurantEntity>();
            #endregion

            #region CuisineType
            CreateMap<CuisineTypeEntity, CuisineTypeDto>().ReverseMap();
            #endregion

            #region Dish
            CreateMap<DishEntity, DishDto>().ReverseMap();
            #endregion

            #region DishType
            CreateMap<DishTypeEntity, DishTypeDto>().ReverseMap();
            #endregion
        }
    }
}
