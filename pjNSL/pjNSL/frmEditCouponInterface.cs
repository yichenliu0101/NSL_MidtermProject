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
using System.Xml.Linq;

namespace pjNSL
{
	public partial class frmEditCouponInterface : Form
	{
		private readonly int _Id;
		public frmEditCouponInterface(int id)
		{
			InitializeComponent();
			_Id = id;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmEditCouponInterface_Load(object sender, EventArgs e)
		{
			var repo = new CouponRepository();
			var dto = repo.Get(_Id);
			if (dto == null)
			{
				MessageBox.Show("找不到符合的記錄");
				return;
			}

			txtName.Text = dto.Name;
			txtDescription.Text = dto.Description;
			txtDiscountCode.Text = dto.DiscountCode;
			txtDiscountMoney.Text = dto.DiscountMoney.ToString();
			comboBoxStatus.SelectedIndex = Convert.ToInt32(dto.Status);
			timeStart.Value = dto.StartTime;
			timeExpire.Value = dto.ExpireTime;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var dto=new Coupon() { Name = txtName.Text, 
				Description = txtDescription.Text ,
				DiscountCode=txtDiscountCode.Text,
				DiscountMoney=Convert.ToDecimal(txtDiscountMoney.Text),
				Status=Convert.ToBoolean(comboBoxStatus.SelectedIndex),
				StartTime=timeStart.Value,
				ExpireTime=timeExpire.Value,
				Id=_Id
			};
				

			//ICouponRepo repo = new CouponRepository();
			//var service = new CouponService(repo);
			//service.Update(dto);
			var ser = new CouponRepository();
			ser.Update(dto);
		}
	}
}
