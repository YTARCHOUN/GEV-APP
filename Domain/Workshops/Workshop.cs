using VehicleMaintenance.Domain.Common.Entities;

namespace VehicleMaintenance.Domain.Workshops
{
    public class Workshop : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }
    }
}
