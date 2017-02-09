using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Workshops;
using System;
using VehicleMaintenance.Domain.Common.State;
using VehicleMaintenance.Domain.Common.Entities;

namespace VehicleMaintenance.Domain.MaintenanceBookings
{
    public class MaintenanceBooking : StatefullEntity,IEntity
    {
        public MaintenanceBooking(IState state) : base(state)
        {
        }

        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public Customer Customer { get; set; }

        public Vehicle Vehicle { get; set; }

        public Workshop Workshop { get; set; }




    }
}
