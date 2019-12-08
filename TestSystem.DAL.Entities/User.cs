using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } //use as Login
        public string Password { get; set; }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                if (DateTime.Now < value)
                {
                    throw new ArgumentException("Неверный ввод даты рождения");
                }
                else
                if (DateTime.Now.Year - value.Year > 150)
                {
                    throw new ArgumentException("Неверный ввод даты рождения");
                }
                else
                {
                    this.dateOfBirth = value;
                }
            }
        }
        public int Age
        {
            get
            {
                int days, months, years;
                if (DateTime.Now < this.DateOfBirth)
                {
                    throw new ArgumentException("Неверный ввод даты рождения");//
                }
                else
                {
                    years = DateTime.Now.Year - this.DateOfBirth.Year;
                    months = DateTime.Now.Month - this.DateOfBirth.Month;
                    if (months < 0)
                    {
                        months += 12;
                        years--;
                    }
                    days = DateTime.Now.Day - this.DateOfBirth.Day;
                    if (days < 0)
                    {
                        days += DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                        months--;
                        if (months < 0)
                        {
                            months += 12;
                            years--;
                        }
                        if (months >= 12)
                        {
                            months -= 12;
                            years++;
                        }
                    }
                    if ((days < 0) || (months < 0) || (years < 0))
                    {
                        throw new ArgumentException("Неверный ввод даты!");//
                    }
                    if (years > 150)
                    {
                        throw new ArgumentException("Слишком большой возраст");//
                    }
                }
                return years;
            }
        }
        public User()
        {

        }
    }
}
