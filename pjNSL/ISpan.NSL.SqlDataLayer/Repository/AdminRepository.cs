using ISpan.NSL.SqlDataLayer.Dtos;
using ISpan.NSL.SqlDataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ISpan.NSL.SqlDataLayer.Repository
{
	public class AdminRepository : IAdminRepo
	{
		private Func<SqlConnection> _conngetter = SqlDb.GetConnection;

		public int Create(AdminDto dto)
		{
			string sql = @"INSERT INTO Member.Members (Name, Email, Password, ImageName, EmailCheck, Role)
						Values (@Name, @Email, @Password, @ImageName, @EmailCheck, @Role)";
			SqlParameter[] parameters = new SqlParameterBuilder()
											.AddVarchar("@Name", 20, dto.Name)
											.AddVarchar("@Email", 50, dto.Email)
											.AddVarchar("@Password", 100, dto.Password)
											.AddVarchar("@ImageName", 200, dto.ImageName)
											.AddBool("@EmailCheck", dto.EmailCheck)
											.AddInt("@Role", dto.Role)
											.Build();

			return SqlDb.Create(_conngetter, sql, parameters);
		}

		public AdminDto GetByEmail(string email)
		{
			string sql = @"SELECT Email, Password FROM Member.Members WHERE Email = @Email";
			SqlParameter parameter = new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = email };
			Func<SqlDataReader, AdminDto> func = Assembler.CreateAdminAssembler;

			return SqlDb.Get(_conngetter, sql, func, parameter);
		}
	}
}
