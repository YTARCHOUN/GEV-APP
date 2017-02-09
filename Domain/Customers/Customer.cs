using VehicleMaintenance.Domain.Common.Entities;

namespace VehicleMaintenance.Domain.Customers
{
    public class Customer : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
