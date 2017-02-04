using Microsoft.EntityFrameworkCore;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Employees;
using VehicleMaintenance.Domain.Reservations;

namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Customer> Customers { get; set; }

        DbSet<Employee> Employees { get; set; }

        DbSet<Reservation> Reservations { get; set; }

        void Save();
    }
}
