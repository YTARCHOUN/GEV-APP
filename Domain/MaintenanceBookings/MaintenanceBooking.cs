using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Workshops;
using System;
using VehicleMaintenance.Domain.Common.Entities;
using VehicleMaintenance.Domain.MaintenanceBookings.States;

namespace VehicleMaintenance.Domain.MaintenanceBookings
{
    public class MaintenanceBooking : IEntity
    {
        public MaintenanceBooking()
        {
            StateId = MaintenanceBookingStates.CREATED;
        }
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public Customer Customer { get; set; }

        public Vehicle Vehicle { get; set; }

        public Workshop Workshop { get; set; }

        public int StateId { get; set; }
    }
}
