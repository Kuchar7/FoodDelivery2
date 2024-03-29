﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Persistence.Configurations.Entities
{
    public class RestaurantCuisineTypeEntityConfiguration : IEntityTypeConfiguration<RestaurantCuisineTypeEntity>
    {
        public void Configure(EntityTypeBuilder<RestaurantCuisineTypeEntity> builder)
        {
            builder.HasKey(x => new { x.RestaurantId, x.CuisineTypeId });

            builder.HasOne(x => x.Restaurant)
                .WithMany(x => x.RestaurantCuisineTypes)
                .HasForeignKey(x => x.RestaurantId);

            builder.HasOne(x => x.CuisineType)
                .WithMany(x => x.RestaurantCuisineTypes)
                .HasForeignKey(x => x.CuisineTypeId);

            #region SeedData
            builder.HasData(new RestaurantCuisineTypeEntity
            {
                RestaurantId = 1,
                CuisineTypeId = 2
            });
            #endregion
        }
    }
}
