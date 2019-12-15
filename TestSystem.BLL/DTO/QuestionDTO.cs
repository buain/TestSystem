using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.BLL.DTO
{
    public class QuestionDTO
    {
        //Через этот класс мы будем передавать объекты вопросов между DAL и PL
        public int Id { get; set; }
        public int IdTest { get; set; }
        public string QuestionText { get; set; }
    }
}
