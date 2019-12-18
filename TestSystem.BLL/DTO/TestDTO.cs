using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.BLL.DTO
{
    public class TestDTO
    {
        //Через этот класс мы будем передавать объекты тестов между DAL и PL
        public int Id { get; set; }
        public int Id_Owner { get; set; }

        [Display(Name = "Название")]
        [Required]
        [MaxLength(20, ErrorMessage = "Превышена допустимая длина строки")]
        public string Title { get; set; }
        public int TimeForTest { get; set; }
        public int Id_Category { get; set; }
    }
}
