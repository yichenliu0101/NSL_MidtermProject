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
	public partial class FrmControl : Form
	{
		public FrmControl()
		{
			InitializeComponent();
		}

		public FrmControl(Form frm)
		{
			Open(frm);
		}
		public void Open(Form chOP)
		{
			this.panelShow.Panel2.Controls.Clear();
			chOP.TopLevel = false;
			this.panelShow.Panel2.Controls.Add(chOP);
			chOP.Show();
		}
		private void 文章維護ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labTitle.Text = "文章維護";
			Open(new FrmArticle());
		}

		private void 折扣碼維護ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labTitle.Text = "折扣碼維護";
			Open(new FrmCoupon());
		}

		private void 會員資料維護ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labTitle.Text = "會員資料維護";
			Open(new FrmMember());
		}

		private void 教師資料維護ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labTitle.Text = "教師資料維護";
			Open(new FrmTeacher());
		}
	}
}
