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
    
    public partial class BCTINHHINHMUONSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BCTINHHINHMUONSACH()
        {
            this.CT_BCTINHHINHMUONSACH = new HashSet<CT_BCTINHHINHMUONSACH>();
        }
    
        public int IDBCMuonSach { get; set; }
        public System.DateTime NgayLap { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int TongSoLuotMuon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BCTINHHINHMUONSACH> CT_BCTINHHINHMUONSACH { get; set; }
    }
}
