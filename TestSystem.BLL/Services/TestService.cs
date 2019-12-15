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
    public class TestService : ITestLogic
    {
        IUnitOfWork Database { get; set; }
        public TestService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public IEnumerable<TestDTO> GetAll()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Test, TestDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Test>, List<TestDTO>>(Database.Tests.GetAll());
        }

        public TestDTO GetTestById(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id теста", "");
            var test = Database.Tests.Get(id.Value);
            if (test == null)
                throw new ValidationException("Тест не найден", "");

            return new TestDTO
            {
                Id = test.Id,
                Id_Owner = test.Id_Owner,
                Title = test.Title,
                TimeForTest = test.TimeForTest,
                Id_Category = test.Id_Category
            };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
