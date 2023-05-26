using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.NSL_Classes
{
    public class Coupon
    {
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public string CouponName { get; set; }
        public string CouponDescription { get; set; }
        public decimal CouponPrice { get; set; }
        public string CouponStatus { get; set; }
        public DateTime ReleaseTime { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}
