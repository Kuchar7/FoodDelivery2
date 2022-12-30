using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.DTOs.Restaurant;
using Restaurant.Application.Features.Restaurants.Requests.Queries;

namespace Restaurant.API.Controllers
{
    [Route("api/restaurants")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/restaurants
        [HttpGet]
        public async Task<ActionResult<List<RestaurantDto>>> Get()
        {
            var restaurants = await _mediator.Send(new GetRestaurantsRequest());
            return Ok(restaurants);
        }

        // GET: api/restaurants/id
        [HttpGet("{restaurantId}")]
        public async Task<ActionResult<RestaurantDto>> Get(int restaurantId)
        {
            var restaurant = await _mediator.Send(new GetRestaurantRequest(restaurantId));
            return Ok(restaurant);
        }
    }
}
