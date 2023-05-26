using ISpan.NSL.SqlDataLayer.ExtMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.NSL.SqlDataLayer.Dtos
{
	public class Assembler
	{
        public static Func<SqlDataReader, AdminDto> CreateAdminAssembler 
		{
			get
			{
				Func<SqlDataReader, AdminDto> func = (reader) =>
				{
					int id = reader.GetInt("Id");
					string name = reader.GetString("Name");
					string email = reader.GetString("Email");
					string password = reader.GetString("Password");
					string imageName = reader.GetString("ImageName");
					bool emailCheck = reader.GetBool("EmailCheck");
					int role = reader.GetInt("Role");

					return new AdminDto
					{
						Id = id,
						Name = name,
						Email = email, 
						Password = password,
						ImageName = imageName,
						EmailCheck = emailCheck,
						Role = role,
					};
				};
				return func;
			}
		}
    }
}
