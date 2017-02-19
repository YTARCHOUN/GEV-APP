using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleMaintenance.DataAccess.Vehicles.Queries
{
    public class GetBrandListQuery : IGetBrandListQuery
    {
        IDatabaseService _databaseService;

        public GetBrandListQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<List<BrandModel>> Execute()
        {
            var brands = _databaseService.Brands.Select(
                brand => new BrandModel
                {
                    Id = brand.Id,
                    Name = brand.Name
                });

            return await brands.ToListAsync();
        }
    }
}
