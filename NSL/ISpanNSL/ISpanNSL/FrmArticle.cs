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
	public partial class FrmArticle : Form
	{
		public FrmArticle()
		{
			InitializeComponent();
		}

		private void FrmArticle_Load(object sender, EventArgs e)
		{
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var frm = new FrmArticleCreateAndEdit();
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
