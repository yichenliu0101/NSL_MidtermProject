using pjNSL.NSL_Classes.CouponDbo;
using pjNSL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjNSL
{
    public partial class frmAddCouponInterface : Form
    {
		
		public frmAddCouponInterface()
        {
			
            InitializeComponent();

        }


		private void frmAddCouponInterface_Load(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var dto = new Coupon()
			{
				Name = txtName.Text,
				Description = txtDescription.Text,
				DiscountCode = txtDiscountCode.Text,
				DiscountMoney = Convert.ToDecimal(txtDiscountMoney.Text),
				Status = Convert.ToBoolean(comboBoxStatus.SelectedIndex),
				StartTime = timeStart.Value,
				ExpireTime = timeExpire.Value,
			};


			//ICouponRepo repo = new CouponRepository();
			//var service = new CouponService(repo);
			//service.Update(dto);
			var ser = new CouponRepository();
			ser.Create(dto);
		}
	}
}
