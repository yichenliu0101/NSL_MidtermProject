using ISpan.NSL.SqlDataLayer.Dtos;
using ISpan.NSL.SqlDataLayer.Interface;
using ISpan.NSL.SqlDataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.NSL.SqlDataLayer.Services
{
	public class AdminService
	{
		public int Create(AdminDto dto)
		{
			//precondtion
			if(string.IsNullOrEmpty(dto.Name))	throw new ArgumentNullException("請輸入姓名");

			if(string.IsNullOrEmpty(dto.Email)) throw new ArgumentNullException("請輸入Email");

			if (string.IsNullOrEmpty(dto.Password)) throw new ArgumentNullException("請輸入密碼");

			IAdminRepo repo = new AdminRepository();
			var dtoInDb = repo.GetByEmail(dto.Email);

			if(dtoInDb != null)
			{
				throw new Exception("資料庫已有重複資料");
			}

			return repo.Create(dto);
		}
	}
}
