using Application.Customers.Commands;
using Application.Interfaces;
using Application.Reservations.Commands.CreateReservation;
using System;
using VehicleMaintenance.Application.Customers.Commands.CreateCustomer;
using VehicleMaintenance.Application.Reservations.Commands.CreateReservation;
using VehicleMaintenance.Application.Reservations.Commands.CreateReservation.Factory;
using VehicleMaintenance.Application.Vehicles.Commands;
using VehicleMaintenance.Application.Vehicles.Commands.CreateVehicle;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.Application.Reservations.Commands
{
    public class CreateReservationCommand : ICreateReservationCommand
    {

        private readonly IDatabaseService _database;
        private readonly IReservationFactory _factory;
        private readonly ICreateCustomerCommand _customerCommand;
        private readonly ICreateVehicleCommand _vehicleCommand;
        private CreateReservationModel _model;

        public CreateReservationCommand(IDatabaseService database, IReservationFactory factory)
        {
            _database = database;
            _factory = factory;
        }
        public void Execute(CreateReservationModel model)
        {
            _model = model;

            var customer = GetOrCreateCustomer();

            var vehicle = GetOrCreateVehicle();

            var dateTime = DateTime.Now.AddDays(1);

            var workshop = _database.Workshops.Find("WorkshopId");

            var reservation = _factory.Create(dateTime, customer, vehicle, workshop);

            _database.Reservations.Add(reservation);

            _database.Save();
                       
        }

        private Customer GetOrCreateCustomer()
        {
            var customer = _database.Customers.Find(_model.CustomerFirstName, _model.CustomerLastName);
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
                createVehicleModel.RegistrationDate = _model.ReservationDateTime;
                createVehicleModel.BrandId = _model.BrandId;
                _vehicleCommand.Create(createVehicleModel);
            }
            return vehicle;
        }

    }
}
