using VehicleMaintenance.Domain.Employees;
using VehicleMaintenance.Domain.Common;
using System.Collections.Generic;

namespace VehicleMaintenance.Domain.Maintenances
{
    public class Maintenance:IEntity
    {
        public int Id { get; set; }

        public IList<MaintenanceOption> MaintenanceOptions { get; set; }

        public IList<Employee> AffectedEmployees { get; set; }

        public int Duration { get; set; }
    }
}
