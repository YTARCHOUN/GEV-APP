using System;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.MaintenanceBookings;
using VehicleMaintenance.Domain.MaintenanceBookings.States;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;

namespace VehicleMaintenance.Application.MaintenanceBookings.Commands.CreateMaintenanceBooking.Factory
{
    public class MaintenanceBookingFactory : IMaintenanceBookingFactory
    {
        public MaintenanceBooking Create(DateTime datetime, Customer customer, Vehicle vehicle, Workshop workshop)
        {
            var maintenanceBooking = new MaintenanceBooking(new CreatedState());

            maintenanceBooking.DateTime = datetime;

            maintenanceBooking.Customer = customer;

            maintenanceBooking.Vehicle = vehicle;

            maintenanceBooking.Workshop = workshop;

            return maintenanceBooking;
        }
    }
}
