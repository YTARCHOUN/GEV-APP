using System;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.DataAccess.Vehicles.Commands.CreateVehicle.Factory
{
    public class VehicleFactory : IVehicleFactory
    {
        private readonly IDatabaseService _database;

        public VehicleFactory(IDatabaseService database)
        {
            _database = database;
        }

        public Vehicle Create(string registrationNumber, Brand brand, DateTime registrationDate)
        {
            var vehicle = new Vehicle();

            vehicle.RegistrationNumber = registrationNumber;
            vehicle.RegistrationDate = registrationDate;
            vehicle.Brand = brand;


            _database.Vehicles.Add(vehicle);

            _database.Save();

            return vehicle;
        }
    }
}
