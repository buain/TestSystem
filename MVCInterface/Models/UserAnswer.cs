using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInterface.Models
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public int Id_Answer { get; set; }
        public int Id_UserTestingSession { get; set; }
    }
}