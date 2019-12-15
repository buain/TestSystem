using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.BLL.DTO;

namespace TestSystem.BLL.Interfaces
{
    public interface IQuestionLogic
    {
        QuestionDTO GetQuestionById(int? id);
        IEnumerable<QuestionDTO> GetAll();
        void Dispose();
    }
}
