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
    
    public partial class NGUOIDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOIDUNG()
        {
            this.PHIEUNHAPKHO_XUATKHO = new HashSet<PHIEUNHAPKHO_XUATKHO>();
        }
    
        public string MANHANVIEN { get; set; }
        public string TENNHANVIEN { get; set; }
        public string TAIKHOAN { get; set; }
        public string MATKHAU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPKHO_XUATKHO> PHIEUNHAPKHO_XUATKHO { get; set; }
    }
}