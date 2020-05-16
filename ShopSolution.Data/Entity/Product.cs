using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entity
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public string Seoalias { get; set; }
    }
}
