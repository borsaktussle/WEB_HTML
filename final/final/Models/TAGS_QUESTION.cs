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
    
    public partial class TAGS_QUESTION
    {
        public int ID_TAGS_QUESTION { get; set; }
        public Nullable<int> ID_QUESTION { get; set; }
        public Nullable<int> ID_TAGS { get; set; }
    
        public virtual QUESTION QUESTION { get; set; }
        public virtual TAGS TAGS { get; set; }
    }
}
