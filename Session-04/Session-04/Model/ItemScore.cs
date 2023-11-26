namespace Session_04.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemScore
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long UserID { get; set; }

        public long ItemID { get; set; }

        public long ScoreID { get; set; }

        public long Value { get; set; }

        public virtual Item Item { get; set; }

        public virtual Score Score { get; set; }

        public virtual User User { get; set; }
    }
}
