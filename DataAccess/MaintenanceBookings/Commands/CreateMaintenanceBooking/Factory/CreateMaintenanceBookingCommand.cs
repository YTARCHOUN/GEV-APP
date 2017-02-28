using Application.Customers.Commands;
using Application.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using System;
using VehicleMaintenance.DataAccess.Customers.Commands.CreateCustomer;
using VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking.Factory;
using VehicleMaintenance.DataAccess.Vehicles.Commands;
using VehicleMaintenance.DataAccess.Vehicles.Commands.CreateVehicle;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Vehicles;
using System.Linq;
using VehicleMaintenance.Domain.Common.Constants;

namespace VehicleMaintenance.DataAccess.MaintenanceBookings.Commands
{
    public class CreateMaintenanceBookingCommand : ICreateMaintenanceBookingCommand
    {

        private readonly IDatabaseService _database;
        private readonly IMaintenanceBookingFactory _factory;
        private readonly ICreateCustomerCommand _customerCommand;
        private readonly ICreateVehicleCommand _vehicleCommand;
        private CreateMaintenanceBookingModel _model;

        public CreateMaintenanceBookingCommand(IDatabaseService database, 
            IMaintenanceBookingFactory factory,
            ICreateCustomerCommand customerCommand,
            ICreateVehicleCommand vehicleCommand)
        {
            _database = database;
            _factory = factory;
            _customerCommand = customerCommand;
            _vehicleCommand = vehicleCommand;
        }
        public void Execute(CreateMaintenanceBookingModel model)
        {
            _model = model;
            
            var customer = GetOrCreateCustomer();

            var vehicle = GetOrCreateVehicle();

            var dateTime = DateTime.Now.AddDays(1);

            var workshop = _database.Workshops.Find(1);

            var state = _database.States.Find(States.MAINTENANCE_BOOKING_CREATED);

            var MaintenanceBooking = _factory.Create(dateTime, customer, vehicle, workshop,state);

            _database.MaintenanceBookings.Add(MaintenanceBooking);

            _database.Save();
                       
        }

        private Customer GetOrCreateCustomer()
        {
            var customer = _database.Customers.Where(c=>c.FirstName == _model.CustomerFirstName && c.LastName == _model.CustomerLastName).FirstOrDefault();
            if (customer == null)
            {
                var createCustomerModel = new CreateCustomerModel();
                createCustomerModel.FirstName = _model.CustomerFirstName;
                createCustomerModel.LastName = _model.CustomerLastName;
                customer = _customerCommand.Execute(createCustomerModel);
            }
            return customer;
        }

        private Vehicle GetOrCreateVehicle()
        {
            var vehicle = _database.Vehicles.Where(v => v.RegistrationNumber == _model.VehicleRegistrationNumber).FirstOrDefault();
            if (vehicle == null)
            {
                var createVehicleModel = new CreateVehicleModel();
                createVehicleModel.RegistrationNumber = _model.VehicleRegistrationNumber;
                createVehicleModel.RegistrationDate = _model.VehicleRegistrationDate;
                createVehicleModel.BrandId = _model.BrandId;
                vehicle = _vehicleCommand.Create(createVehicleModel);
            }
            return vehicle;
        }

    }
}
