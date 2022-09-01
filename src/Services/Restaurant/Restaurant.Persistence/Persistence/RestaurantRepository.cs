using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Restaurant.Application.Contracts;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly IConfiguration _configuration;

        public RestaurantRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<RestaurantEntity> GetRestaurant(string restaurantId)
        {
            using var connection = GetConnection();
            var x = await connection.QueryFirstOrDefaultAsync<RestaurantEntity>("SELECT * FROM restaurant where restaurantId = @restaurantId", new {restaurantId});
            return x;
        }

        public Task CreateRestaurant(RestaurantEntity restaurantEntity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRestaurant(RestaurantEntity restaurantEntity)
        {
            throw new NotImplementedException();
        }

        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        }
    }
}
