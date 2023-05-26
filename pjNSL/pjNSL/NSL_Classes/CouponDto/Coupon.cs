namespace pjNSL.NSL_Classes.CouponDbo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coupon.Coupon")]
    public partial class Coupon
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DiscountCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ExpireTime { get; set; }

        [Column(TypeName = "money")]
        public decimal DiscountMoney { get; set; }

        public bool Status { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
