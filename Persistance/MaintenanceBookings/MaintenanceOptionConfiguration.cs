using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleMaintenance.Domain.Maintenances;

namespace VehicleMaintenance.Persistance.MaintenanceBookings
{
    public class MaintenanceOptionConfiguration
    {
        public MaintenanceOptionConfiguration(EntityTypeBuilder<MaintenanceOption> entityBuilder)
        {
            entityBuilder.HasKey(m => m.Id);
            entityBuilder.Property(m => m.Description).IsRequired();
        }
    }
}
