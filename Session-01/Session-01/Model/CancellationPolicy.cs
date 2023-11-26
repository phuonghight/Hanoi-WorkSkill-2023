namespace Session_01.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CancellationPolicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CancellationPolicy()
        {
            CancellationRefundFees = new HashSet<CancellationRefundFee>();
            ItemPrices = new HashSet<ItemPrice>();
        }

        public long ID { get; set; }

        public Guid GUID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Commission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CancellationRefundFee> CancellationRefundFees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
    }
}
