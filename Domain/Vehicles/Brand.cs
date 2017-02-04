using System;
using VehicleMaintenance.Domain.Common;

namespace VehicleMaintenance.Domain.Vehicles
{
    public class Brand : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
