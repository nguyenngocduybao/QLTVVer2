//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_PHIEUNHAPSACH
    {
        public int IDCTPhieuNhap { get; set; }
        public Nullable<int> IDPhieuNhap { get; set; }
        public Nullable<int> IDSach { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    
        public virtual PHIEUNHAPSACH PHIEUNHAPSACH { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
