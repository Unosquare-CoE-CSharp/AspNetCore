using AngelaValdez.Training.Data.Configurations;
using AngelaValdez.Training.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace AngelaValdez.Training.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfiguration(new FluentItemConfig());
            modelBuilder.ApplyConfiguration(new FluentWarehouseConfig());
        }
    }
}
