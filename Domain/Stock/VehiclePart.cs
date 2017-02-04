
using VehicleMaintenance.Domain.Common;

namespace VehicleMaintenance.Domain.Stock
{
    public class VehiclePart : IEntity
    {
        public int Id { get; set; }

        public string Label { get; set; }
    }
}
