using CarStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Context
{
    public class CarStoreDbContext : DbContext
    {
        public CarStoreDbContext(DbContextOptions<CarStoreDbContext> options) : base(options) { }
    
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }

    }
}
