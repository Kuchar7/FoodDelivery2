using Restaurant.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
    public class DishTypeEntity : BaseEntity
    {
        public string Name { get; set; }
        public List<DishEntity> Dishes { get; set; }
    }
}
