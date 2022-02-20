using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Model
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Category_Name { get; set; }
       //public ICollection<Category_Meta> Category_Meta { get; set; }
       public ICollection<Product>Products { get; set; }
    }
}
