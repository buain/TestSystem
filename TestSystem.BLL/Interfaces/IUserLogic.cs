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
        IEnumerable<UserDTO> GetAll();
        void Create(UserDTO userDTO);
        void Delete(int id);
        void Dispose();
    }
}
