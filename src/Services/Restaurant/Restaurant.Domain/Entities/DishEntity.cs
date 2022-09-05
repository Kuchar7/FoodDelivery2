using Restaurant.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
    public class DishEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? DishTypeId { get; set; }
        public DishTypeEntity DishType { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get; set; }
        public RestaurantEntity Restaurant { get; set; }
    }
}
