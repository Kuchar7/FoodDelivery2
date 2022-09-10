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

            builder.Property(x => x.ExternalId)
                .IsRequired();

            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            #region SeedData
            builder.HasData(
                new DishTypeEntity
                {
                    Id = 1,
                    ExternalId = new Guid("b8d310a2-44c5-4aa6-baf6-fe9934f17e35"),
                    Name = "Kebab",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new DishTypeEntity
                {
                    Id = 2,
                    ExternalId = new Guid("5559f3b0-b1b3-445e-8e96-e36b8e2e22a0"),
                    Name = "Pizza",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                }
                );
            #endregion
        }
    }
}
