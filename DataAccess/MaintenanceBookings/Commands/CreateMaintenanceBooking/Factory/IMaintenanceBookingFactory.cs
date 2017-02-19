using System;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.MaintenanceBookings;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;

namespace VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking.Factory
{
    public interface IMaintenanceBookingFactory
    {
        MaintenanceBooking Create(DateTime datetime, Customer customer, Vehicle vehicle, Workshop workshop);
    }
}
