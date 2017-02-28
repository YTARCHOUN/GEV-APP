using System;
using Application.Customers.Commands;
using VehicleMaintenance.DataAccess.Customers.Factory;
using VehicleMaintenance.Domain.Customers;

namespace VehicleMaintenance.DataAccess.Customers.Commands.CreateCustomer
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

        public Customer Execute(CreateCustomerModel model)
        {
            var customer = _factory.Create(model.FirstName, model.LastName);

            _database.Customers.Add(customer);

            _database.Save();

            return customer;
        }
    }
}
