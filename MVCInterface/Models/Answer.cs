using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInterface.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int IdQuestion { get; set; }
        public string AnswerText { get; set; }
        public int IsRight { get; set; }
    }
}