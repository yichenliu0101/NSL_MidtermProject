using pjNSL.InterfaceClass;
using pjNSL.NSL_Classes.CouponDbo;
using pjNSL.Repository;
using pjNSL.Service;
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
    public partial class frmAddCoupon : Form
    {
        public frmAddCoupon()
        {
            InitializeComponent();
        }

		List<Coupon> _data;

		private void frmAddCoupon_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGVPoupon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return; // 按到了header,不處理

			int id =_data[e.RowIndex].Id;

			var frm = new frmEditCouponInterface(id);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void Display()
		{
			ICouponRepo repo = new CouponRepository();
			var service = new CouponService(repo);
			_data = service.Search(txtDiscountCode.Text);
			dataGVPoupon.DataSource = _data;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new frmAddCouponInterface();
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
