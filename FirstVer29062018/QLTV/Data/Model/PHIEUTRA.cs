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
    
    public partial class PHIEUTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTRA()
        {
            this.CT_PHIEUTRA = new HashSet<CT_PHIEUTRA>();
        }
    
        public int IDPhieuTra { get; set; }
        public Nullable<int> IDDocGia { get; set; }
        public System.DateTime NgayTra { get; set; }
        public Nullable<decimal> TienPhatKyNay { get; set; }
        public Nullable<decimal> SoTienTra { get; set; }
        public Nullable<decimal> TienNoKyNay { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUTRA> CT_PHIEUTRA { get; set; }
        public virtual THEDOCGIA THEDOCGIA { get; set; }
    }
}
