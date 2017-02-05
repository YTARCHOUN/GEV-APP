using Application.Customers.Commands;

namespace VehicleMaintenance.Application.Customers.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        void Execute(CreateCustomerModel model);
    }
}
