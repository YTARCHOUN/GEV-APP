using Application.Customers.Commands;
using VehicleMaintenance.Domain.Customers;

namespace VehicleMaintenance.DataAccess.Customers.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        Customer Execute(CreateCustomerModel model);
    }
}
