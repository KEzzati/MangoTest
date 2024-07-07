using System.ComponentModel.DataAnnotations;

namespace Mango_Services.Coupon.API.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public double MinAmount { get; set; }
        public DateTime LastUpdated { get; set; }

        public DateTime CreatedDate { get; set; }
    }

}
