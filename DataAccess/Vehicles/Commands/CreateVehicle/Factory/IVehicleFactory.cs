using System;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.DataAccess.Vehicles.Commands.CreateVehicle.Factory
{
    public interface IVehicleFactory
    {
        Vehicle Create(string registrationNumber, Brand brand, DateTime registrationDate);
    }
}
