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
    
    public partial class View_AllGames
    {
        public int PlayerGameId { get; set; }
        public Nullable<int> PlayerMasterId { get; set; }
        public string RecordingFileName { get; set; }
        public Nullable<System.DateTime> GameStartTime { get; set; }
        public Nullable<System.DateTime> GameEndTime { get; set; }
        public Nullable<int> GameId { get; set; }
        public string Game { get; set; }
        public Nullable<int> GameTierId { get; set; }
        public string GameTier { get; set; }
        public Nullable<int> GameTierTypeId { get; set; }
        public int GameRankId { get; set; }
        public string GameTierType { get; set; }
        public string GameRank { get; set; }
        public Nullable<int> GameResultId { get; set; }
        public string GameResult { get; set; }
        public Nullable<int> GamePoints { get; set; }
        public Nullable<bool> IsMarked { get; set; }
        public Nullable<int> MarkedById { get; set; }
        public string MarkedByFName { get; set; }
        public string MarkedByLName { get; set; }
        public string ConsoleName { get; set; }
        public Nullable<System.DateTime> MarkedAt { get; set; }
        public Nullable<int> PlayerId { get; set; }
        public string PlayerName { get; set; }
        public Nullable<int> LeagueId { get; set; }
        public string League { get; set; }
        public Nullable<int> CurrentTierId { get; set; }
        public string CurrentTier { get; set; }
        public int CurrentRankId { get; set; }
        public string CurrentRank { get; set; }
        public Nullable<int> CurrentRankTierPoints { get; set; }
        public Nullable<int> CurrentTierTypeId { get; set; }
        public string CurrentTierType { get; set; }
        public Nullable<int> CurrentRankIndex { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<int> TotalPoints { get; set; }
        public bool PromoEnabled { get; set; }
    }
}
