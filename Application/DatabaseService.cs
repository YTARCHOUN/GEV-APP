using Microsoft.EntityFrameworkCore;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Employees;
using VehicleMaintenance.Domain.MaintenanceBookings;
using VehicleMaintenance.Domain.Maintenances;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;


namespace VehicleMaintenance.DataAccess
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

        private DatabaseService() {  }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public void Save()
        {
            SaveChanges();
        }
    }
}
