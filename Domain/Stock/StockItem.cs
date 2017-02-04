using VehicleMaintenance.Domain.Common;

namespace VehicleMaintenance.Domain.Stock
{
    public class StockItem : IEntity
    {
        public int Id { get; set; }

        public VehiclePart VehiclePart { get; set; }

        public int Quatity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
