using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Persistence.Configurations.Entities
{
    public class DishTypeEntityConfiguration : IEntityTypeConfiguration<DishTypeEntity>
    {
        public void Configure(EntityTypeBuilder<DishTypeEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            #region SeedData
            builder.HasData(
                new DishTypeEntity
                {
                    Id = 1,
                    Name = "Kebab",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new DishTypeEntity
                {
                    Id = 2,
                    Name = "Pizza",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                }
                );
            #endregion
        }
    }
}
