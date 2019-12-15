using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.DAL.Entities
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public int IdAnswer { get; set; }
        public int IdUserTestingSession { get; set; }
    }
}
