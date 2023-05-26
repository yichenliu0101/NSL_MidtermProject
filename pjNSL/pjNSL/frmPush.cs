using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjNSL
{
    public partial class frmPush : Form
    {
        public frmPush()
        {
            InitializeComponent();
        }

        private void frmPush_Load(object sender, EventArgs e)
        {

        }

		private void picCoupon_Click(object sender, EventArgs e)
		{
            var frm=new frmPush();
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
