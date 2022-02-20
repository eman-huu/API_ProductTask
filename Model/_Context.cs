using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.EntityFrameworkCore;  

namespace API_ProductTask.Model
{
    public class _Context:DbContext
    {
        public _Context(DbContextOptions<_Context> options):base(options)
        {


        }

        public DbSet<Product> Products { get; set; }

        public DbSet<_User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

      //  public DbSet<Category_Meta> category_Metas { get; set; }

        public DbSet<_Role> _Roles { get; set; }

       
    }

}
