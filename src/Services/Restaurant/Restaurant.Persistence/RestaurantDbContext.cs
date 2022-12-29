using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Common;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Persistence
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantEntity> Restaurants { get; set; }
        public DbSet<CuisineTypeEntity> CuisineTypes { get; set; }
        public DbSet<RestaurantCuisineTypeEntity> RestaurantCuisineTypes { get; set; }
        public DbSet<DishEntity> Dishes { get; set; }
        public DbSet<DishTypeEntity> DishTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RestaurantDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in ChangeTracker.Entries<BaseEntity>())
            {
                entry.Entity.LastDateModified = DateTime.Now;
                if(entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }   
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
