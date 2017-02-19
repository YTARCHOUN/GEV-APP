
namespace VehicleMaintenance.Domain.Common.Entities.Location
{
    public class Address : IEntity
    {
        public int Id { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string PostalCode { get; set; }

        public City City { get; set; }

        public Country Country { get; set; }
    }
}
