using VehicleMaintenance.Domain.Employees;
using VehicleMaintenance.Domain.Common.Entities;
using System.Collections.Generic;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.Domain.Maintenances
{
    public class Maintenance:IEntity
    {
        public int Id { get; set; }

        public Vehicle Vehicle { get; set; }

        public IList<MaintenanceOption> MaintenanceOptions { get; set; }

        public IList<Employee> AffectedEmployees { get; set; }

        public int Duration { get; set; }

        public State State { get; set; }

        public string Comment { get; set; }
    }
}
