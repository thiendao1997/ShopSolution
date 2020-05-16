using ShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entity
{
    public class Catagory
    {
        public int IdCatagory { set; get; }
        public string NameCatagory { set; get; }
        public int SortOrder { set; get; }
        public int ParentId { set; get; }
        public Status StatusCatagory { set; get; }
    }

}
