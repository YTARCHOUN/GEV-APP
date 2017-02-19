using System;

namespace VehicleMaintenance.DataAccess.Vehicles.Commands.CreateVehicle
{
    public class CreateVehicleModel
    {
        public string RegistrationNumber { get; set; }

        public int BrandId { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
