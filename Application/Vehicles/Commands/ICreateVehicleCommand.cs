using VehicleMaintenance.DataAccess.Vehicles.Commands.CreateVehicle;

namespace VehicleMaintenance.DataAccess.Vehicles.Commands
{
    public interface ICreateVehicleCommand
    {
        void Create(CreateVehicleModel model);
    }
}
