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
    
    public partial class USERADMIN
    {
        public string UserNameAdmin { get; set; }
        public string PasswordAdmin { get; set; }
        public Nullable<int> IDAdmin { get; set; }
    
        public virtual CT_USERADMIN CT_USERADMIN { get; set; }
    }
}
