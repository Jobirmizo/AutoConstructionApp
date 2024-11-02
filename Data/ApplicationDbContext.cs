using AutoConstructionApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoConstructionApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Payment>  Payments { get; set; }
    public DbSet<SuperAdmin> SuperAdmins { get; set; }
    public DbSet<ConstructionVehicle> ConstructionVehicles { get; set; }
    public DbSet<DeliveryVehicle> DeliveryVehicles { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Role> Roles { get; set; }  
}