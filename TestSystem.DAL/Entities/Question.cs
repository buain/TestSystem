using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.DAL.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public int IdTest { get; set; }
        public string QuestionText { get; set; }
    }
}
