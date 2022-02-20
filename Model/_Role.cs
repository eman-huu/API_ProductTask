using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Model
{
    public class _Role
    {
        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public ICollection<_User> Users { get; set; }
    }
}
