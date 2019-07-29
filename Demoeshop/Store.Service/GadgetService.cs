using Store.Model.Model;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Store.Data.Repositories.GadgetRepository;
using static Store.Data.Repositories.CategoryRepository;

namespace Store.Service
{
    public interface IGadgetService
    {
        IEnumerable<Gadget> GetGadgets();
        IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null);
        Gadget GetGadget(int id);
        void CreateGadget(Gadget gadget);
        void SaveGadget();
    }


    public
class GadgetService: IGadgetService
    {
        private readonly IGadgetRepository gadgetRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public GadgetService(IGadgetRepository gadgetRepository, ICategoryRepository categoryRepository,IUnitOfWork unitOfWork)
        {
            this.gadgetRepository = gadgetRepository;
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

       public IEnumerable<Gadget> GetGadgets()
        {
            var gadgets = gadgetRepository.GetAll();
            return gadgets;
        }

        public IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null)
        {
            var category = categoryRepository.GetCategoryByName(categoryName);
            return category.Gadgets.Where(g => g.Name.ToLower().Contains(gadgetName.ToLower().Trim()));
        }
        public Gadget GetGadget(int id)
        {
            var gadget = gadgetRepository.GetById(id);
            return gadget;
        }
        public void CreateGadget(Gadget gadget)
        {
            gadgetRepository.Add(gadget);
        }
        public void SaveGadget()
        {
            unitOfWork.Commit();
        }


    }
}
