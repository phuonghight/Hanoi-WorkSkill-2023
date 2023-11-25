namespace session_03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemAmenity
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long ItemID { get; set; }

        public long AmenityID { get; set; }

        public virtual Amenity Amenity { get; set; }

        public virtual Item Item { get; set; }
    }
}
