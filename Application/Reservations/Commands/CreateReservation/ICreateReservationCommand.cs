using Application.Reservations.Commands.CreateReservation;

namespace VehicleMaintenance.Application.Reservations.Commands.CreateReservation
{
    public interface ICreateReservationCommand
    {
        void Execute(CreateReservationModel model);
    }
}
