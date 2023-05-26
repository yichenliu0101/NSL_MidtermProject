using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.NSL_Classes
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string MemberName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Language { get; set; }
        public int  ImageNo { get; set; }
        public byte[] ImageContent { get; set; }
        public bool CheckEmail { get; set; }
    }
}
