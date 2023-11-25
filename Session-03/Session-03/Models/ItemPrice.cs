namespace session_03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemPrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemPrice()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long ItemID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public long CancellationPolicyID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

        public virtual CancellationPolicy CancellationPolicy { get; set; }

        public virtual Item Item { get; set; }
    }
}
