using Microsoft.EntityFrameworkCore;

namespace PASTRYInfrastructure.DataAccess
{
    public interface IEntityTypeConfigurationRegistrar
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}