using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInterface.Models
{
    public class Test
    {
        public int Id { get; set; }
        public int Id_Owner { get; set; } //Тот кто проходил тест
        public string Title { get; set; } //Название теста
        public int TimeForTest { get; set; } // Время, выделеное для прохождения теста
        public int Id_Category { get; set; }
        public static void Create(Test model) //Создание теста
        {
            //
        }
        
    }
}