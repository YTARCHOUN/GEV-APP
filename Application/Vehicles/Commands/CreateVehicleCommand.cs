using Application.Interfaces;
using System;
using VehicleMaintenance.Application.Vehicles.Commands.CreateVehicle;
using VehicleMaintenance.Application.Vehicles.Commands.CreateVehicle.Factory;

namespace VehicleMaintenance.Application.Vehicles.Commands
{
    public class CreateVehicleCommand : ICreateVehicleCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IVehicleFactory _factory;
        public CreateVehicleCommand(IDatabaseService databaseService, IVehicleFactory factory)
        {
            _databaseService = databaseService;
            _factory = factory;
        }
        public void Create(CreateVehicleModel model)
        {

            var brand = _databaseService.Brands.Find(model.BrandId);


            var vehicle = _factory.Create(model.RegistrationNumber, brand, model.RegistrationDate);


            _databaseService.Vehicles.Add(vehicle);
        }
    }
}
