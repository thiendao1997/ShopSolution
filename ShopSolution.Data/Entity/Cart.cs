using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entity
{
    public class Cart
    {
        public int IdCart { set; get; }
        public int IdProduct { set; get; }
        public int Quantily { set; get; }
        public decimal PriceCart { set; get; }
    }
}
