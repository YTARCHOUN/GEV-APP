using VehicleMaintenance.Domain.Common;

namespace VehicleMaintenance.Domain.Employees
{
    public class Employee : IEntity
    {
        public const int MANGER = 0;
        public const int TECHNICIEN = 1;

        public int Id { get; set; }

        public string FullName { get; set; }

        public int EmployeeType { get; set; }

        private Employee()
        {
        }

        public Employee(int EmployeeType)
        {
            this.EmployeeType = EmployeeType;
        }
    }
}
