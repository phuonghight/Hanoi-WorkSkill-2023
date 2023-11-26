namespace Session_01.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CancellationRefundFee
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long CancellationPolicyID { get; set; }

        public int DaysLeft { get; set; }

        public decimal PenaltyPercentage { get; set; }

        public virtual CancellationPolicy CancellationPolicy { get; set; }
    }
}
