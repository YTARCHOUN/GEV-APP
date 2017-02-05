using VehicleMaintenance.Domain.Customers;

namespace VehicleMaintenance.Application.Customers.Factory
{
    public interface ICustomerFactory
    {
        Customer Create(string firstName, string lastName);
    }
}
