using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace pjNSL.NSL_Classes.CouponDbo
{
	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=CouponDto")
		{
		}

		public virtual DbSet<Coupon> Coupons { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Coupon>()
				.Property(e => e.DiscountMoney)
				.HasPrecision(19, 4);
		}
	}
}
