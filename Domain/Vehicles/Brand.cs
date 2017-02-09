using System.Collections.Generic;
using VehicleMaintenance.Domain.Common.Entities;
using VehicleMaintenance.Domain.Stock;

namespace VehicleMaintenance.Domain.Vehicles
{
    public class Brand : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<VehiclePart> ExchangeParts { get; set; }

        public IList<VehiclePart> CompatibleExchangeParts { get; set; }
    }
}
