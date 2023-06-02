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
	public partial class FrmCoupon : Form
	{
		public FrmCoupon()
		{
			InitializeComponent();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var frm = new FrmCouponCreateAndEdit();
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
