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
<<<<<<< HEAD:NSL/ISpanNSL/ISpanNSL/FrmCouponCreateAndEdit.cs
	public partial class FrmCouponCreateAndEdit : Form
	{
		public FrmCouponCreateAndEdit()
		{
			InitializeComponent();
=======
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
>>>>>>> b854668f68e5471cae471b9c45563366e874a215:pjNSL/pjNSL/frmMember.cs
		}
	}
}
