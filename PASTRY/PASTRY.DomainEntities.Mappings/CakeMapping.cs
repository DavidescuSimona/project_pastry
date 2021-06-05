using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PASTRY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities.Mappings
{
    class CakeMapping : IEntityTypeConfiguration<Cake>
    {
        public void Configure(EntityTypeBuilder<Cake> builder)
        {
            builder.ToTable("Cakes");
            builder.Property(c => c.Id).HasColumnName("Id");
        }
    }
}
