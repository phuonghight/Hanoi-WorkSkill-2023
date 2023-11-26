namespace Session_01.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            ItemAmenities = new HashSet<ItemAmenity>();
            ItemAttractions = new HashSet<ItemAttraction>();
            ItemPictures = new HashSet<ItemPicture>();
            ItemPrices = new HashSet<ItemPrice>();
        }

        public long ID { get; set; }

        public Guid GUID { get; set; }

        public long UserID { get; set; }

        public long ItemTypeID { get; set; }

        public long AreaID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Capacity { get; set; }

        public int NumberOfBeds { get; set; }

        public int NumberOfBedrooms { get; set; }

        public int NumberOfBathrooms { get; set; }

        [Required]
        [StringLength(500)]
        public string ExactAddress { get; set; }

        [Required]
        [StringLength(250)]
        public string ApproximateAddress { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        [Required]
        [StringLength(2000)]
        public string HostRules { get; set; }

        public int MinimumNights { get; set; }

        public int MaximumNights { get; set; }

        public virtual Area Area { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemAmenity> ItemAmenities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemAttraction> ItemAttractions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPicture> ItemPictures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }

        public virtual ItemType ItemType { get; set; }

        public virtual User User { get; set; }
    }
}
