using Microsoft.EntityFrameworkCore;
using PASTRYInfrastructure.DataAccess;
using System;

namespace PASTRY.DomainEntities.Mappings
{
    public class EntityNameRegistrer : IEntityTypeConfigurationRegistrar
    {
        public void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
