using pjNSL.InterfaceClass;
using pjNSL.NSL_Classes.CouponDbo;
using pjNSL.Repository;
using System.Collections.Generic;
using System.Xml.Linq;

namespace pjNSL.Service
{
	public class CouponService
	{
		private ICouponRepo _couponRepo;

		public CouponService(ICouponRepo couponRepo)
		{
			_couponRepo=couponRepo;
		}

		public List<Coupon> Search(string DiscountCode)
		{

			var result =_couponRepo.Search(DiscountCode);

			return result;
		}

		public Coupon Update(Coupon coupon)
		{
			var result= _couponRepo.Update(coupon);

			return result;
		}

		public Coupon Create(Coupon coupon)
		{
			var result = _couponRepo.Create(coupon);

			return result;
		}
	}
}
