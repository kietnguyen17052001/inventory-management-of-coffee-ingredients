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
    
    public partial class CHITIETPHIEUXUAT
    {
        public string MAPHIEU { get; set; }
        public string MANGUYENLIEU { get; set; }
        public Nullable<int> SOLUONG { get; set; }
    
        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
        public virtual PHIEUNHAPKHO_XUATKHO PHIEUNHAPKHO_XUATKHO { get; set; }
    }
}
