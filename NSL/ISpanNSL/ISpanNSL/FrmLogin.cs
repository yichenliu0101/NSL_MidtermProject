using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpanNSL
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// todo 驗證帳密是否正確

			// 若正確, 清空二個textbox

			//開啟FormMain
			var frm = new FrmControl();
			frm.Owner = this;

			this.Hide();

			frm.ShowDialog();
		}
	}
}
