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
    
    public partial class TAGS
    {
        public TAGS()
        {
            this.TAGS_QUESTION = new HashSet<TAGS_QUESTION>();
            this.TAGS_SHARING = new HashSet<TAGS_SHARING>();
            this.SHARING = new HashSet<SHARING>();
        }
    
        public int ID_TAGS { get; set; }
        public string TAGSNAME { get; set; }
    
        public virtual ICollection<TAGS_QUESTION> TAGS_QUESTION { get; set; }
        public virtual ICollection<TAGS_SHARING> TAGS_SHARING { get; set; }
        public virtual ICollection<SHARING> SHARING { get; set; }
    }
}