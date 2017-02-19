using System.Collections.Generic;
using System.Threading.Tasks;

namespace VehicleMaintenance.DataAccess.Maintenances.Queries
{
    public interface IGetMaintenanceOptionListQuery
    {
        Task<List<MaintenanceOptionModel>> Execute();
    }
}
