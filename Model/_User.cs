using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Model
{
    public class _User
    {
        [Key]
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserPassword{get;set;}
        public int RolID { get; set; }

        public _Role _Role { get; set; }

    }
}
