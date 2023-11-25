namespace session_03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemAttraction
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long ItemID { get; set; }

        public long AttractionID { get; set; }

        public decimal? Distance { get; set; }

        public long? DurationOnFoot { get; set; }

        public long? DurationByCar { get; set; }

        public virtual Attraction Attraction { get; set; }

        public virtual Item Item { get; set; }
    }
}
