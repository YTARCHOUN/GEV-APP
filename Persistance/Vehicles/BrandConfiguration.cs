using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMaintenance.Domain.Vehicles;

namespace VehicleMaintenance.Persistance.Vehicles
{
    public class BrandConfiguration
    {
        public BrandConfiguration(EntityTypeBuilder<Brand> entityBuilder)
        {
            entityBuilder.HasKey(b => b.Id);
            entityBuilder.Property(b => b.Name).IsRequired();
        }
    }
}
