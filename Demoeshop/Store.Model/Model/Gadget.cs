using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Model.Model
{
   public class Gadget
    {
       public int GadgetID { get; set; }
        public string Name { get; set; }
        public string Descripction { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }
        // beging e.g. column null
        //public Nullable<int> Stock {get; set;}
        // end
        public Category Category { get; set; }

    }
}
