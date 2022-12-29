using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Entities;

namespace Restaurant.Persistence.Configurations.Entities
{
    public class RestaurantEntityConfiguration : IEntityTypeConfiguration<RestaurantEntity>
    {
        public void Configure(EntityTypeBuilder<RestaurantEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(r => r.Province)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.City).IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.PostalCode).IsRequired()
                .HasMaxLength(30);

            builder.Property(r => r.Street).IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.HouseNumber).IsRequired()
                .HasMaxLength(30);

            #region SeedData
            builder.HasData(new RestaurantEntity
            {
                Id = 1,
                Name = "Super Pizzeria",
                Description = "Description",
                Province = "mazowieckie",
                City = "Warszawa",
                PostalCode = "00-006",
                Street = "Piękna",
                HouseNumber = "22"
            });
            #endregion
        }
    }
    
}
