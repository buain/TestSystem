using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.BLL.DTO;

namespace TestSystem.BLL.Interfaces
{
    public interface ITestLogic
    {
        TestDTO GetTestById(int? id);
        IEnumerable<TestDTO> GetAll();
        void Create(TestDTO testDTO);
        void StartTest(TestDTO testDTO);
        void Edit(TestDTO testDTO);
        void Delete(TestDTO testDTO);
        void Dispose();
    }
}
