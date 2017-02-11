using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Employees;
using VehicleMaintenance.Domain.MaintenanceBookings;
using VehicleMaintenance.Domain.Maintenances;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;
using VehicleMaintenance.Persistance.MaintenanceBookings;
using VehicleMaintenance.Persistance.Vehicles;

namespace VehicleMaintenance.Persistance
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        private readonly string _connectionString;

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<MaintenanceBooking> MaintenanceBookings { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Workshop> Workshops { get; set; }

        public DbSet<MaintenanceOption> MaintenanceOptions { get; set; }

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BrandConfiguration(modelBuilder.Entity<Brand>());
            new MaintenanceOptionConfiguration(modelBuilder.Entity<MaintenanceOption>());
        }

        public void Save()
        {
            SaveChanges();
        }
    }
}
