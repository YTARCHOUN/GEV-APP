using VehicleMaintenance.Domain.Common;

namespace VehicleMaintenance.Domain
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        public string FullName { get; set; }
    }
}
