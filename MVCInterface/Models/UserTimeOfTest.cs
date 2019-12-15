using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInterface.Models
{
    public class UserTimeOfTest
    {
        public int Id { get; set; }

        public int Id_User { get; set; }

        public int Id_Test { get; set; }

        public int IsDone { get; set; }
        public DateTime Started_date { get; set; }

        public DateTime Finished_date { get; set; }
    }
}