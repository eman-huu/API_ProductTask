using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Model
{
    public class ProductViewModel
    {
        public int ProductID { set; get; }

        public string Product_Name { get; set; }

        public int CategoryID { get; set; }

        public int Category_MetaID { get; set; }
        public DateTime Product_Date { get; set; }

        public string Categoy { get; set; }
        public string Categoy_Meta { get; set; }

        public int Archieve_Status { get; set; }
    }
}
