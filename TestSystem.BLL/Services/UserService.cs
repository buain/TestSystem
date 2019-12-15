using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.DAL.Interfaces;
using TestSystem.DAL.Entities;
using TestSystem.BLL.Interfaces;
using TestSystem.BLL.Infrastructure;
using AutoMapper;
using TestSystem.BLL.DTO;

namespace TestSystem.BLL.Services
{
    public class UserService : IUserLogic
    {
        IUnitOfWork Database { get; set; }
        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public IEnumerable<UserDTO> GetAll()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<User>, List<UserDTO>>(Database.Users.GetAll());
        }

        public UserDTO GetUserById(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id пользователя", "");
            var user = Database.Users.Get(id.Value);
            if (user == null)
                throw new ValidationException("Пользователь не найден", "");

            return new UserDTO
            {
                Id = user.Id,
                Email = user.Email,
                Age = user.Age,
                RoleId = user.RoleId
            };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
