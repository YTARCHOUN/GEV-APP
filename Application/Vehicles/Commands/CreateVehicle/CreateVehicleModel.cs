using System;

namespace VehicleMaintenance.Application.Vehicles.Commands.CreateVehicle
{
    public class CreateVehicleModel
    {
        public string RegistrationNumber { get; set; }

        public int BrandId { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
