//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoHang.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            this.NGUYENLIEUx = new HashSet<NGUYENLIEU>();
        }
    
        public string MANHACUNGCAP { get; set; }
        public string TENNHACUNGCAP { get; set; }
        public string DIACHI { get; set; }
        public string SODIENTHOAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUYENLIEU> NGUYENLIEUx { get; set; }
    }
}