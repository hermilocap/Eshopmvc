using Store.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Store.Data
{
   public class StoreSeedData:DropCreateDatabaseIfModelChanges<StoreEntities>
    {
        protected override void Seed(StoreEntities context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetGadgets().ForEach(g => context.Gadget.Add(g));
        }
        private static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category{
                  Name="Tablets"
                },
                new Category{
                Name="Laptos"},
                new Category{ Name="Mobiles"}
                
            };
        }
        public static List<Gadget> GetGadgets()
        {
            return new List<Gadget>
            {
                new Gadget
                {
                    Name="prontotec",
                    Descripction="Android 4,4",
                    CategoryID=1,
                    Price=46.67m,
                    Image="prontotec.jpg"
                },
                new Gadget
                {
                    Name="Samsung",
                    Descripction="Android 4,4",
                    CategoryID=1,
                    Price=34.67m,
                    Image="samsung.jpg"
                }

            };
        }
    }
}
