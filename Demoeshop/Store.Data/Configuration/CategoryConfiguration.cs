﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.Entity.ModelConfiguration;
using Store.Model.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Data.Configuration
{
  public  class CategoryConfiguration:EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            Property(c=>c.Name).IsRequired().HasMaxLength(50);
        }
    }
}