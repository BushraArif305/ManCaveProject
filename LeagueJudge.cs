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
    
    public partial class LeagueJudge
    {
        public int LeagueJudgeId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> LeagueMasterId { get; set; }
    
        public virtual User User { get; set; }
        public virtual LeagueMaster LeagueMaster { get; set; }
    }
}
