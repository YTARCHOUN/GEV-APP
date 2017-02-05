using Application.Interfaces;
using Application.Customers.Commands;
using VehicleMaintenance.Application.Customers.Factory;

namespace VehicleMaintenance.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : ICreateCustomerCommand
    {
        private readonly IDatabaseService _database;
        private readonly ICustomerFactory _factory;

        public CreateCustomerCommand(IDatabaseService database, ICustomerFactory factory)
        {
            _database = database;
            _factory = factory;
        }

        public void Execute(CreateCustomerModel model)
        {
            var customer = _factory.Create(model.FirstName, model.LastName);

            _database.Customers.Add(customer);

            _database.Save();
        }
    }
}
