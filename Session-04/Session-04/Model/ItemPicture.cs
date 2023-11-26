namespace Session_04.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemPicture
    {
        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long ItemID { get; set; }

        [Required]
        [StringLength(500)]
        public string PictureFileName { get; set; }

        public virtual Item Item { get; set; }
    }
}
