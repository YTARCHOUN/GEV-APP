using Microsoft.EntityFrameworkCore;
using VehicleMaintenance.Domain;

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
