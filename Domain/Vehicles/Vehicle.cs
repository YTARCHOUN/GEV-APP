using System;
using VehicleMaintenance.Domain.Common.Entities;

namespace VehicleMaintenance.Domain.Vehicles
{
    public class Vehicle : IEntity
    {
        public int Id { get; set; }

        public string RegistrationNumber { get; set; }

        public Brand Brand { get; set; }

        public DateTime RegistrationDate { get; set; }

    }
}
