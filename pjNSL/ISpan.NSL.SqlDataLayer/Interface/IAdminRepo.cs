using ISpan.NSL.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.NSL.SqlDataLayer.Interface
{
	public interface IAdminRepo
	{
		int Create(AdminDto dto);

		AdminDto GetByEmail(string email);
	}
}
