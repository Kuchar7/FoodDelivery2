using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Persistence.Configurations.Entities
{
    public class DishEntityConfiguration : IEntityTypeConfiguration<DishEntity>
    {
        public void Configure(EntityTypeBuilder<DishEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasPrecision(9, 2);

            builder.Property(x => x.RestaurantId)
                .IsRequired();

            #region SeedData
            builder.HasData(new DishEntity
            {
                Id = 1,
                Name = "Big Pepperoni",
                Description = "Description",
                DishTypeId = 2,
                Price = 40.9M,
                RestaurantId = 1,
                DateCreated = DateTime.MinValue,
                LastDateModified = DateTime.MinValue,
            });
            #endregion
        }
    }
}
