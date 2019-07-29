using Store.Data.Infrastructure;
using Store.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static Store.Data.Repositories.GadgetRepository;

namespace Store.Data.Repositories
{
    public class GadgetRepository : RepositoryBase<Gadget>, IGadgetRepository
    {
        public GadgetRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public interface IGadgetRepository : IRepository<Gadget> { }
    }
}
