using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.NSL.SqlDataLayer.Dtos
{
	public class AdminDto
	{
        public int Id { get; set; }
		public string Name { get; set; }
        public string Email { get; set; }
		public string Password { get; set; }
		public string ImageName { get; set; }
		public bool EmailCheck { get; set; }
        public int Role { get; set; }
		public AdminDto() 
		{
			EmailCheck = true;
			Role = 3;
			ImageName = "defalut.jpg";
		}

    }
}
