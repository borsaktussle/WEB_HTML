//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KATEGORY_REPORT
    {
        public KATEGORY_REPORT()
        {
            this.REPORT = new HashSet<REPORT>();
        }
    
        public int ID_KATEGORY { get; set; }
        public string NAMA_KATEGORY { get; set; }
    
        public virtual ICollection<REPORT> REPORT { get; set; }
    }
}