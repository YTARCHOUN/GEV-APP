using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleMaintenance.DataAccess.Maintenances.Queries
{
    public class GetMaintenanceOptionListQuery : IGetMaintenanceOptionListQuery
    {
        IDatabaseService _database;

        public GetMaintenanceOptionListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public async Task<List<MaintenanceOptionModel>> Execute()
        {
            var maintenanceOptions = _database.MaintenanceOptions.Select(m => new MaintenanceOptionModel
            {
                Id = m.Id,
                Description = m.Description
            });

            return await maintenanceOptions.ToListAsync();
        }
    }
}
