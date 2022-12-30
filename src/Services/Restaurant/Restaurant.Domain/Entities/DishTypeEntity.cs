using Restaurant.Domain.Common;

namespace Restaurant.Domain.Entities
{
    public class DishTypeEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<DishEntity> Dishes { get; set; }
    }
}
