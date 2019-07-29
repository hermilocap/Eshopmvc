using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Infrastructure
{
 public   interface IDbFactory:IDisposable
    {
        StoreEntities Init();
    }
}
