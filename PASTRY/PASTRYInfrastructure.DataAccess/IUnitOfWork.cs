using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRYInfrastructure.DataAccess
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
