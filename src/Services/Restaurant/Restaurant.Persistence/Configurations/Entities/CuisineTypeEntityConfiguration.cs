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

            builder.Property(x => x.ExternalId)
                .IsRequired();

            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            #region SeedData


            builder.HasData(
                new CuisineTypeEntity
                {
                    Id = 1,
                    ExternalId = new Guid("faa62a6c-4359-49cc-86ac-db63003c0e01"),
                    Name = "Polish",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 2,
                    ExternalId = new Guid("ffa5ccd3-b9a8-435a-9ea9-5512a7fb2944"),
                    Name = "Indian",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 3,
                    ExternalId = new Guid("6463af4a-a7c7-4f8d-ba9c-9a571368a2bf"),
                    Name = "Italian",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 4,
                    ExternalId = new Guid("d65e672e-10c3-45d1-b59a-aa03cf8914fd"),
                    Name = "Thai",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 5,
                    ExternalId = new Guid("cbabaadc-530d-40a9-8773-171ff916f976"),
                    Name = "Turkish",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 6,
                    ExternalId = new Guid("7be6888e-7436-4e22-aec4-556170a7895d"),
                    Name = "Georgian",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 7,
                    ExternalId = new Guid("5d1369e9-ff12-4591-b656-21ec9bcfdc03"),
                    Name = "Czech",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 8,
                    ExternalId = new Guid("26ce796a-2824-4c3c-8725-3081385424fb"),
                    Name = "French",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                },
                new CuisineTypeEntity
                {
                    Id = 9,
                    ExternalId = new Guid("6df47f57-7dcd-4053-98ad-9b123fe7d569"),
                    Name = "Mexican",
                    DateCreated = DateTime.MinValue,
                    LastDateModified = DateTime.MinValue,
                }
                );
            #endregion
        }
    }
}
