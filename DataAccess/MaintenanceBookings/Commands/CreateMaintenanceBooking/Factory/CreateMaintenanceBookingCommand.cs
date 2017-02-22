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

            var workshop = _database.Workshops.Find("WorkshopId");

            var MaintenanceBooking = _factory.Create(dateTime, customer, vehicle, workshop);

            _database.MaintenanceBookings.Add(MaintenanceBooking);

            _database.Save();
                       
        }

        private Customer GetOrCreateCustomer()
        {
            var customer = _database.Customers.Where(x=>x.FirstName == _model.CustomerFirstName && x.LastName == _model.CustomerLastName).FirstOrDefault();
            if (customer == null)
            {
                var createCustomerModel = new CreateCustomerModel();
                createCustomerModel.FirstName = _model.CustomerFirstName;
                createCustomerModel.LastName = _model.CustomerLastName;
                _customerCommand.Execute(createCustomerModel);
            }
            return customer;
        }

        private Vehicle GetOrCreateVehicle()
        {
            var vehicle = _database.Vehicles.Find(_model.VehicleRegistrationNumber);
            if (vehicle == null)
            {
                var createVehicleModel = new CreateVehicleModel();
                createVehicleModel.RegistrationNumber = _model.VehicleRegistrationNumber;
                createVehicleModel.RegistrationDate = _model.MaintenanceBookingDateTime;
                createVehicleModel.BrandId = _model.BrandId;
                _vehicleCommand.Create(createVehicleModel);
            }
            return vehicle;
        }

    }
}
