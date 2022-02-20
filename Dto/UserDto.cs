using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Dtos
{
    public class UserDto
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string _UserPassword { get; set; }

        public int RoleId { get; set; }
    }
}
