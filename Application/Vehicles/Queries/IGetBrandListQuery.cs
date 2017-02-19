using System.Collections.Generic;
using System.Threading.Tasks;

namespace VehicleMaintenance.DataAccess.Vehicles.Queries
{
    public interface IGetBrandListQuery
    {
        Task<List<BrandModel>> Execute();
    }
}
