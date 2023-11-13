namespace Session_03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookingDetail
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long BookingID { get; set; }

        public long ItemPriceID { get; set; }

        public bool isRefund { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RefundDate { get; set; }

        public long? RefundCancellationPoliciyID { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual ItemPrice ItemPrice { get; set; }
    }
}
