using Store.Data.Infrastructure;
using Store.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Store.Data.Repositories.CategoryRepository;

namespace Store.Service
{

    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories(string name = null);
        Category GetCategory(int id);
        Category GetCategory(string name);
        void CreateCategory(Category category);
        void SaveCategory();
    }
public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;
        public CategoryService( ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<Category> GetCategories(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return categoryRepository.GetAll();
            else
                return categoryRepository.GetAll().Where(c => c.Name == name);

        }
        public Category GetCategory(int id)
        {
            var category = categoryRepository.GetById(id);
            return category;
        }
        public Category GetCategory(string name)
        {
            var category = categoryRepository.GetCategoryByName(name);
            return category;
        }
        public void CreateCategory(Category category)
        {
            categoryRepository.Add(category);
        }
        public void SaveCategory() { 
            unitOfWork.Commit();
        }

    }
}
