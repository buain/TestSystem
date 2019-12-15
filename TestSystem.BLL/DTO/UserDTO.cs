using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.BLL.DTO
{
    public class UserDTO
    {
        //Через этот класс мы будем передавать объекты пользователей между DAL и PL
        public int Id { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }

        
    }
}
