//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session_01
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemPicture
    {
        public long ID { get; set; }
        public System.Guid GUID { get; set; }
        public long ItemID { get; set; }
        public string PictureFileName { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
