using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimplyLogbook.Components;
using SimplyLogbook.Entities;
using System.Reflection.Emit;

namespace SimplyLogbook.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
    new Vehicle
    {
        VehicleId = 1,
        Brand = "VW",
        Type = "Golf",
        LicensePlate = "ABC123"
    },
    new Vehicle
    {
        VehicleId = 2,
        Brand = "BMW",
        Type = "X5",
        LicensePlate = "XYZ789"
    }
);
            base.OnModelCreating(modelBuilder);

        }
    }
}
