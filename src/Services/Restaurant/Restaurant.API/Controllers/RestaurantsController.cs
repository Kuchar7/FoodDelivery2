using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.DTOs.Restaurant;
using Restaurant.Application.Features.Restaurants.Requests.Commands;
using Restaurant.Application.Features.Restaurants.Requests.Queries;
using System.Net;

namespace Restaurant.API.Controllers
{
    [Route("api/restaurants")]
    [ApiController]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public class RestaurantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/restaurants
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<RestaurantDto>>> Get()
        {
            var restaurants = await _mediator.Send(new GetRestaurantsRequest());
            return Ok(restaurants);
        }

        // GET: api/restaurants/id
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult<RestaurantDto>> Get(int id)
        {
            var restaurant = await _mediator.Send(new GetRestaurantRequest(id));
            return Ok(restaurant);
        }

        // POST: api/restaurants
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.UnprocessableEntity)]
        public async Task<ActionResult> Post([FromBody] CreateRestaurantDto restaurantDto)
        {
            var newRestaurantId = await _mediator.Send(new CreateRestaurantCommand(restaurantDto));
            return Created($"api/restaurants/{newRestaurantId}", null);
        }

        // PUT: api/restaurants
        [HttpPut()]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> Put([FromBody] UpdateRestaurantDto updateRestaurantDto)
        {
            await _mediator.Send(new UpdateRestaurantCommand(updateRestaurantDto));
            return NoContent();
        }
    }
}
