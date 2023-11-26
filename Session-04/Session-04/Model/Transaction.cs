namespace Session_04.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            Bookings = new HashSet<Booking>();
        }

        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long UserID { get; set; }

        public long TransactionTypeID { get; set; }

        public decimal Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(50)]
        public string GatewayReturnID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual TransactionType TransactionType { get; set; }
    }
}
