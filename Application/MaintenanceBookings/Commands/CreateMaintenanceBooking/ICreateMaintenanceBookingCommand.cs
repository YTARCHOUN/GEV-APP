using Application.MaintenanceBookings.Commands.CreateMaintenanceBooking;

namespace VehicleMaintenance.Application.MaintenanceBookings.Commands.CreateMaintenanceBooking
{
    public interface ICreateMaintenanceBookingCommand
    {
        void Execute(CreateMaintenanceBookingModel model);
    }
}
