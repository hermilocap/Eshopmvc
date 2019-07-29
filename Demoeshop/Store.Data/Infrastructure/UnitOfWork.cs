using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Infrastructure
{
   public class UnitOfWork:IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private StoreEntities dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public StoreEntities DbContext
        {
            get
            { return dbContext ?? (dbContext = dbFactory.Init());

            }
        }
        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
