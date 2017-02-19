using Application.Customers.Commands;

namespace VehicleMaintenance.DataAccess.Customers.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        void Execute(CreateCustomerModel model);
    }
}
