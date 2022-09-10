using Restaurant.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
    public class RestaurantCuisineTypeEntity
    {
        public int RestaurantId { get; set; }
        public int CuisineTypeId { get; set; }
    }
}
