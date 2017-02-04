using VehicleMaintenance.Domain.Common;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Customers;
using System;

namespace VehicleMaintenance.Domain.Reservations
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public Customer Customer { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
