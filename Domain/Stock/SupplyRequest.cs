using System.Collections.Generic;
using VehicleMaintenance.Domain.Common.Entities;
using VehicleMaintenance.Domain.Employees;

namespace VehicleMaintenance.Domain.Stock
{
    public class SupplyRequest : IEntity
    {
        public int Id { get; set; }

        public Employee Employee { get; set; }

        public IList<VehiclePart> VehicleParts { get; set; }
    }
}
