using VehicleMaintenance.Application.Vehicles.Commands.CreateVehicle;

namespace VehicleMaintenance.Application.Vehicles.Commands
{
    public interface ICreateVehicleCommand
    {
        void Create(CreateVehicleModel model);
    }
}
