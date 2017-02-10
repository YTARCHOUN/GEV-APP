using System.Collections.Generic;

namespace VehicleMaintenance.Application.Maintenances.Queries
{
    public interface IGetMaintenanceOptionListQuery
    {
        List<MaintenanceOptionModel> Execute();
    }
}
