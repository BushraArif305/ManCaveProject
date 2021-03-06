//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManCaveLeague
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rank()
        {
            this.Tiers = new HashSet<Tier>();
        }
    
        public int RankId { get; set; }
        public string Title { get; set; }
        public Nullable<int> TierPoints { get; set; }
        public Nullable<int> LeagueId { get; set; }
        public Nullable<int> Index { get; set; }
    
        public virtual League League { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tier> Tiers { get; set; }
    }
}
