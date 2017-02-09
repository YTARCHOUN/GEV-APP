using VehicleMaintenance.Domain.Employees;
using VehicleMaintenance.Domain.Common.Entities;
using System.Collections.Generic;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.Domain.Maintenances
{
    public class Maintenance:IEntity
    {
        public const int CREATED = 0;
        public const int IN_PROGRESS = 1;
        public const int TERMINATED = 2;



        public int Id { get; set; }

        public Vehicle Vehicle { get; set; }

        public IList<MaintenanceOption> MaintenanceOptions { get; set; }

        public IList<Employee> AffectedEmployees { get; set; }

        public int Duration { get; set; }

        public int Status { get; set; }

        public string Comment { get; set; }
    }
}
