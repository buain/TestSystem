using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.DAL.Entities
{
    public class UserTimeOfTest
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdTest { get; set; }
        public int IsDone { get; set; }
        public DateTime StartTest { get; set; }
        public DateTime FinishTest { get; set; }
    }
}
