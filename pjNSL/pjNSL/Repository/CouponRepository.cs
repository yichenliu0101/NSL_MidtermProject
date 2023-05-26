using pjNSL.InterfaceClass;
using pjNSL.NSL_Classes.CouponDbo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjNSL.Repository
{
	public class CouponRepository: ICouponRepo
	{
		public Coupon Get(int id)
		{
			var db=new Model1();
			var dto = db.Coupons.Find(id);
			return dto;
		}

		public List<Coupon> Search(string DiscountCode)
		{
			var query = new Model1().Coupons.AsNoTracking().ToList().Select(c => new Coupon
			{
				Id = c.Id,
				DiscountCode = c.DiscountCode,
				Name = c.Name,
				Description = c.Description,
				StartTime = c.StartTime,
				ExpireTime = c.ExpireTime,
				DiscountMoney = c.DiscountMoney,
				Status= c.Status,
				CreatedTime= c.CreatedTime
			});

			if(string.IsNullOrEmpty(DiscountCode)==false)
			{
				query = query.Where(c => c.DiscountCode.Contains(DiscountCode));
			}

			query = query.OrderBy(c => c.Id);

			return query.ToList();
		}

		public Coupon Create(Coupon dto)
		{
			var db=new Model1();
			dto = new Coupon()
			{
				DiscountCode = dto.DiscountCode,
				Name = dto.Name,
				Description = dto.Description,
				StartTime = dto.StartTime,
				ExpireTime = dto.ExpireTime,
				Status = dto.Status,
				DiscountMoney= dto.DiscountMoney,
			};

			db.Coupons.Add(dto);
			db.SaveChanges();

			return dto;
		}

		public Coupon Update(Coupon dto)
		{
			var db = new Model1();
			var coupon = db.Coupons.Find(dto.Id);
			coupon.DiscountCode = dto.DiscountCode;
			coupon.Name = dto.Name;
			coupon.Description = dto.Description;
			coupon.StartTime = dto.StartTime;
			coupon.ExpireTime = dto.ExpireTime;
			coupon.Status = dto.Status;
			coupon.DiscountMoney = dto.DiscountMoney;

			db.SaveChanges();

			return dto;
		}



	}
}

