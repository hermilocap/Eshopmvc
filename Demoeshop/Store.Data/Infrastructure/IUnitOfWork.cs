using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Infrastructure
{
   public interface IUnitOfWork
    {
        void Commit();
    }
}
