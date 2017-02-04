using VehicleMaintenance.Domain.Common;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Customers;
using System;

namespace VehicleMaintenance.Domain.Reservations
{
    public class Reservation : IEntity
    {
        public const int CREATED = 0;
        public const int CONFIRMED = 1;
        public const int CANCELED = 2;

        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public Customer Customer { get; set; }

        public Vehicle Vehicle { get; set; }

        public int Status { get; set; }
    }
}
