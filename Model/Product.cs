using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Model
{
    public class Product
    {
        [Key]
        public int ProductID { set; get; }

        public string Product_Name { get; set; }


        public DateTime Product_Date { get; set; }

        //public int Category_MetaID { get; set; }

        public int CategoryID { get; set; }
        public int Archieve_Status { get; set; }

      //public Category_Meta Category_Meta { get; set; }
        public Category Category { get; set; }

    }
}
