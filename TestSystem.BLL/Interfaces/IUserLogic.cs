using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.BLL.DTO;

namespace TestSystem.BLL.Interfaces
{
    public interface IUserLogic
    {
        UserDTO GetUserById(int? id);
        //User GetUserByEmail(string? email);
        IEnumerable<UserDTO> GetAll();
        void Dispose();
    }
}
