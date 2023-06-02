using ISpan.NSL.SqlDataLayer;
using ISpan.NSL.SqlDataLayer.Dtos;
using ISpan.NSL.SqlDataLayer.Repository;
using ISpan.NSL.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjNSL
{
	public partial class FrmAddAdmin : Form
	{
		public FrmAddAdmin()
		{
			InitializeComponent();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string email = txtEmail.Text;
			string password = txtPassword.Text;

			var dto = new AdminDto()
			{
				Name = name,
				Email = email,
				Password = password,
			};

			var repo = new AdminService();
			try
			{
				repo.Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"錯誤訊息: " + ex.Message);
			}
		}
	}
}
