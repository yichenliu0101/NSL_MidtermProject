using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.NSL_Classes
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string LectureName { get; set; }
        public string CommentContent { get; set; }
        public int MemberId { get; set; }
        public int Satisfaction { get; set; }
        public bool IsAttend { get; set; }
        public bool IsReply { get; set; }
    }
}
