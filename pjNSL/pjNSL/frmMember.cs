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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

		private void pictureBoxAddAdmin_Click(object sender, EventArgs e)
		{
            var form = new FrmAddAdmin();
            form.ShowDialog();
		}

		private void labAddAdmin_Click(object sender, EventArgs e)
		{
			var form = new FrmAddAdmin();
			form.ShowDialog();
		}
	}
}
