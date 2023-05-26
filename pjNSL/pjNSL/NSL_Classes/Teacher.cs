using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.NSL_Classes
{
    public class Teacher:Member
    {
        public int TeacherID { get; set; }
        public string Education { get; set; }
        public string Talent { get; set; }
        public string WorkExperience { get; set; }
        public string Indroduction { get; set; }
        public string BankAccount { get; set; }
    }
}
