using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class ModeStats
    {
        //**    Summary of Kills    **//
        //
        public uint TotalKills          { get; }                   // Sum of PlayerKillsByRank and CraftKillsByType?
        public uint TotalSharedKills    { get; }                   // Sum of PlayerSharedKillsByRank and CraftSharedKillsByType?

        public uint PlayerKills         { get; }                  // Sum of PlayerKillsByRank?
        public uint PlayerSharedKills   { get; }                  // Sum of PlayerSharedKillsByRank?

        public uint NonPlayerKills          { get; }               // Sum of CraftKillsByType?
        public uint NonPlayerSharedKills    { get; }               // Sum of CraftSharedKillsByType?

        public uint Assists { get; set; }

        public uint HiddenCargoFound { get; set; }

        public uint LaserAccuracy { get; set; }                     //  Percentage, 0...100

        public uint WarheadAccuracy { get; set; }                   //  Percentage, 0...100
        //

        //**    Player Kills by Rank    **//
        //
        public List<PilotRating> PlayerKillsByRank        { get; set; }
        public List<PilotRating> PlayerSharedKillsByRank  { get; set; }
        //

        //**    Craft Kills by Type     **//
        //
        public List<CraftTypes> CraftKillsByType          { get; set; }
        public List<CraftTypes> CraftSharedKillsByType    { get; set; }
        //

        //**    Averages per Mission    **//
        //
        public double TotalKillsPerMission          { get; }       // Sum of PlayerKillsPerMission and NonPlayerKillsPerMission?
        public double TotalSharedKillsPerMission    { get; }       // Sum of PlayerSharedKillsPerMission and NonPlayerSharedKillsPerMission?

        public double PlayerKillsPerMission         { get; }        // Calculated value?
        public double PlayerSharedKillsPerMission   { get; }        // Calculated value?

        public double NonPlayerKillsPerMission          { get; }    // Calculated value?
        public double NonPlayerSharedKillsPerMission    { get; }    // Calculated value?

        public double AssistsPerMission { get; }                    //  Calculated value?
        //

        //**    Total Losses    **//
        //
        public uint TotalCraftLosses        { get; set; }           //  Calculated value?
        public uint LossesToPlayerPilots    { get; set; }           //  Sum of LossesToPlayersByRank?
        public uint LossesToNonPlayerPilots { get; set; }
        public uint LossesToStarships       { get; set; }
        public uint LossesToMines           { get; set; }
        public uint LossesFromCollisions    { get; set; }
        //

        //**    Losses to Players by Rank   **//
        //
        public List<PilotRating> LossesToPlayersByRank { get; set; }
        //

        public ModeStats()
        {
            PlayerKillsByRank       = new List<PilotRating>((int)PilotRating.MAX_PILOT_RATINGS);
            PlayerSharedKillsByRank = new List<PilotRating>((int)PilotRating.MAX_PILOT_RATINGS);

            CraftKillsByType        = new List<CraftTypes>((int)CraftTypes.MAX_CRAFT_TYPES);
            CraftSharedKillsByType  = new List<CraftTypes>((int)CraftTypes.MAX_CRAFT_TYPES);

            LossesToPlayersByRank   = new List<PilotRating>((int)PilotRating.MAX_PILOT_RATINGS);
        }
    }
}
