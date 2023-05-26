using pjNSL.NSL_Classes.CouponDbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjNSL.InterfaceClass
{
	public interface ICouponRepo
	{
		Coupon Get(int id);
		List<Coupon> Search(string DiscountCode);
		Coupon Update(Coupon dto);
		Coupon Create(Coupon dto);
	}
}
