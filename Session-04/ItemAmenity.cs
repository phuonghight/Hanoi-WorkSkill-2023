//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session4
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemAmenity
    {
        public long ID { get; set; }
        public System.Guid GUID { get; set; }
        public long ItemID { get; set; }
        public long AmenityID { get; set; }
    
        public virtual Amenity Amenity { get; set; }
        public virtual Item Item { get; set; }
    }
}
