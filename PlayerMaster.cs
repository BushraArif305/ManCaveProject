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
    
    public partial class PlayerMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlayerMaster()
        {
            this.PlayerGames = new HashSet<PlayerGame>();
        }
    
        public int PlayerMasterId { get; set; }
        public Nullable<int> PlayerId { get; set; }
        public Nullable<int> LeagueId { get; set; }
        public Nullable<int> TierId { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<int> TotalPoints { get; set; }
        public bool PromoEnabled { get; set; }
        public Nullable<bool> IsPromoBlock { get; set; }
    
        public virtual League League { get; set; }
        public virtual Player Player { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerGame> PlayerGames { get; set; }
        public virtual Tier Tier { get; set; }
    }
}
