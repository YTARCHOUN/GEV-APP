using System;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.Application.Vehicles.Commands.CreateVehicle.Factory
{
    public interface IVehicleFactory
    {
        Vehicle Create(string registrationNumber, Brand brand, DateTime registrationDate);
    }
}
