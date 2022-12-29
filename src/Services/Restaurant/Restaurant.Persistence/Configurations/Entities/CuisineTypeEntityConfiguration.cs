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
    public class CuisineTypeEntityConfiguration : IEntityTypeConfiguration<CuisineTypeEntity>
    {
        public void Configure(EntityTypeBuilder<CuisineTypeEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            #region SeedData


            builder.HasData(
                new CuisineTypeEntity
                {
                    Id = 1,
                    Name = "Polish",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 2,
                    Name = "Indian",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 3,
                    Name = "Italian",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 4,
                    Name = "Thai",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 5,
                    Name = "Turkish",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 6,
                    Name = "Georgian",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 7,
                    Name = "Czech",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 8,
                    Name = "French",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 9,
                    Name = "Mexican",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                }
                );
            #endregion
        }
    }
}
