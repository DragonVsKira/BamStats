//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BamStats.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BamName
    {
        public BamName()
        {
            this.BamFights = new HashSet<BamFight>();
            this.BamFights1 = new HashSet<BamFight>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<BamFight> BamFights { get; set; }
        public virtual ICollection<BamFight> BamFights1 { get; set; }
    }
}
