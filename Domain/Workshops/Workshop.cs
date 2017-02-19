using VehicleMaintenance.Domain.Common.Entities;
using VehicleMaintenance.Domain.Common.Entities.Location;

namespace VehicleMaintenance.Domain.Workshops
{
    public class Workshop : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }
    }
}
