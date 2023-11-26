namespace Session_01.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Coupon
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        [Required]
        [StringLength(50)]
        public string CouponCode { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal MaximimDiscountAmount { get; set; }
    }
}
