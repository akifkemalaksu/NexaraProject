using Microsoft.EntityFrameworkCore;
using NexaraProject.DataAccess.EntityFramework.EntityConfigurations;
using NexaraProject.Entities.Concretes;
using System;

namespace NexaraProject.DataAccess.EntityFramework
{
    public class NexaraContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfigurations());
            modelBuilder.ApplyConfiguration(new OrderDetailConfigurations());
            modelBuilder.ApplyConfiguration(new SizeSetSizeConfigurations());
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SizeSet> SizeSets { get; set; }
        public DbSet<SizeSetSize> SizeSetSizes { get; set; }
    }
}