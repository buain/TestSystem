using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInterface.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } //use as Login
        public string Password { get; set; }
        public int Age { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        
        public User() { }

    }
    public class Role //Admin or User
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}