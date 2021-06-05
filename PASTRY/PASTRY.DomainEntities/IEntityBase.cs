using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities
{
    public interface IEntityBase
    {
        public Guid Id { get; set; }
    }
}
