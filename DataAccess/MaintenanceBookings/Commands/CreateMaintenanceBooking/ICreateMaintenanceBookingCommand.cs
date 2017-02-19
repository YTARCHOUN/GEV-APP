using Application.MaintenanceBookings.Commands.CreateMaintenanceBooking;

namespace VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking
{
    public interface ICreateMaintenanceBookingCommand
    {
        void Execute(CreateMaintenanceBookingModel model);
    }
}
