using VehicleMaintenance.DataAccess.Vehicles.Commands.CreateVehicle;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.DataAccess.Vehicles.Commands
{
    public interface ICreateVehicleCommand
    {
        Vehicle Create(CreateVehicleModel model);
    }
}
