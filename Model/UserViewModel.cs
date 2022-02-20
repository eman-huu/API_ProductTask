using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Model
{
    public class UserViewModel
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }
        public int RolID { get; set; }

        public string Role { get; set; }
    }
}
