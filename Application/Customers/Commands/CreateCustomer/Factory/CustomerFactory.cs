using System;
using VehicleMaintenance.Application.Customers.Factory;
using VehicleMaintenance.Domain.Customers;

namespace VehicleMaintenance.Application.Customers.Commands.CreateCustomer.Factory
{
    public class CustomerFactory : ICustomerFactory
    {
        public Customer Create(string firstName, string lastName)
        {
            var customer = new Customer();

            customer.FirstName = firstName;

            customer.LastName = lastName;

            return customer;
        }
    }
}
