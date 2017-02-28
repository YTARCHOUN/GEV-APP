using System;
using VehicleMaintenance.Domain.Common.Entities;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.MaintenanceBookings;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;

namespace VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking.Factory
{
    public class MaintenanceBookingFactory : IMaintenanceBookingFactory
    {
        
        public MaintenanceBooking Create(DateTime datetime, Customer customer, Vehicle vehicle, Workshop workshop, State state)
        {
            var maintenanceBooking = new MaintenanceBooking();

            maintenanceBooking.DateTime = datetime;

            maintenanceBooking.Customer = customer;

            maintenanceBooking.Vehicle = vehicle;

            maintenanceBooking.Workshop = workshop;

            maintenanceBooking.State = state;

            return maintenanceBooking;
        }
    }
}
