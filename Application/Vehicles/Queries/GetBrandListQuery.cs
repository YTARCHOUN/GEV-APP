using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleMaintenance.Application.Vehicles.Queries
{
    public class GetBrandListQuery : IGetBrandListQuery
    {
        IDatabaseService _databaseService;

        public GetBrandListQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<BrandModel> Execute()
        {
            var brands = _databaseService.Brands.Select(
                brand => new BrandModel {
                    Id = brand.Id,
                    Name = brand.Name
                });

            return brands.ToList();
        }
    }
}
