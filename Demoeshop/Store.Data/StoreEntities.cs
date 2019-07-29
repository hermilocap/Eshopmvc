using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Store.Model.Model;
using Store.Data.Configuration;

namespace Store.Data
{
   public class StoreEntities:DbContext
    {
        //aqui es donde se escribe el nombre de la bd
        public  StoreEntities (): base("StoreEntities") { }
        //nombre de tablas
        public DbSet<Gadget> Gadget { get; set; }
        public DbSet<Category> Categories { get; set; }
        public  virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GadgetConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}
