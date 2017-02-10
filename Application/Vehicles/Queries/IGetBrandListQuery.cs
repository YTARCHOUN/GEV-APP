using System.Collections.Generic;

namespace VehicleMaintenance.Application.Vehicles.Queries
{
    public interface IGetBrandListQuery
    {
        List<BrandModel> Execute();
    }
}
