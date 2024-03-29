﻿using Store.Data.Infrastructure;
using Store.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Store.Data.Repositories.CategoryRepository;

namespace Store.Data.Repositories
{
 public class CategoryRepository: RepositoryBase<Category>, ICategoryRepository
    {

        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
            return category;

        }

        public override void Update(Category entity)
        {
            entity.DateUpdated = DateTime.Now;
            base.Update(entity);
        }

        public interface ICategoryRepository : IRepository<Category>
        {
            Category GetCategoryByName(string categoryName);
        }

    }
}
