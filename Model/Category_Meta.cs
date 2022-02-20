using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Model
{
    public class Category_Meta
    {
        [Key]
        public int MetaID { get; set; }

        public string Meta_Desc { get; set; }

        public int CategoryID {get;set;}

        public Category Category { get; set; }

        //public ICollection<Product> Products { get; set; }
    }
}
