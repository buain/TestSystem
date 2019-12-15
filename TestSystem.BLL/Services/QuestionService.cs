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
    public class QuestionService : IQuestionLogic
    {
        IUnitOfWork Database { get; set; }
        public QuestionService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public IEnumerable<QuestionDTO> GetAll()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Question, QuestionDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Question>, List<QuestionDTO>>(Database.Questions.GetAll());
        }

        public QuestionDTO GetQuestionById(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id вопроса", "");
            var question = Database.Questions.Get(id.Value);
            if (question == null)
                throw new ValidationException("Вопрос не найден", "");

            return new QuestionDTO
            {
                Id = question.Id,
                IdTest = question.IdTest,
                QuestionText = question.QuestionText
            };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
