using VehicleMaintenance.Domain.Customers;

namespace VehicleMaintenance.DataAccess.Customers.Factory
{
    public interface ICustomerFactory
    {
        Customer Create(string firstName, string lastName);
    }
}
