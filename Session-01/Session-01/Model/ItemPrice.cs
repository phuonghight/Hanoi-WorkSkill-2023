namespace Session_01.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemPrice
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long ItemID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public long CancellationPolicyID { get; set; }

        public virtual CancellationPolicy CancellationPolicy { get; set; }

        public virtual Item Item { get; set; }
    }
}
