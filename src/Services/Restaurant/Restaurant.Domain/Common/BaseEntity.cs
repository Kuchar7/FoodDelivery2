namespace Restaurant.Domain.Common
{
    public abstract class BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime LastDateModified { get; set; }
    }
}
