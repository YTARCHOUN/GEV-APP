using VehicleMaintenance.Domain.Common;

namespace VehicleMaintenance.Domain.Maintenances
{
    public class MaintenanceOption : IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

    }
}
