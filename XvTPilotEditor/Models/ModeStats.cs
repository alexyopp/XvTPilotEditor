using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    class ModeStats
    {
        //**SUMMARY OF KILLS**//
        //  Total Kills
        public uint TotalKills          { get; }                   // Sum of PlayerKillsByRank and CraftKillsByType?
        public uint TotalSharedKills    { get; }                   // Sum of PlayerSharedKillsByRank and CraftSharedKillsByType?

        //  Player Kills
        public uint PlayerKills         { get; }                  // Sum of PlayerKillsByRank?
        public uint PlayerSharedKills   { get; }                  // Sum of PlayerSharedKillsByRank?

        //  Non-Player Kills
        public uint NonPlayerKills          { get; }               // Sum of CraftKillsByType?
        public uint NonPlayerSharedKills    { get; }               // Sum of CraftSharedKillsByType?

        //  Assists
        public uint Assists { get; set; }

        //  Hidden Cargo Found
        public uint HiddenCargoFound { get; set; }

        //  Laser Accuracy (a percentage, 0 - 100)
        public uint LaserAccuracy { get; set; }

        //  Warhead Accuracy (a percentage, 0 - 100)
        public uint WarheadAccuracy { get; set; }

        //**PLAYER KILLS BY RANK**//
        public List<PilotRating>? PlayerKillsByRank        { get; set; }
        public List<PilotRating>? PlayerSharedKillsByRank  { get; set; }

        //**CRAFT KILLS BY TYPE**//
        public List<CraftTypes> CraftKillsByType          { get; set; }
        public List<CraftTypes> CraftSharedKillsByType    { get; set; }

        //**AVERAGES PER MISSION**//
        //  Total Kills
        public double TotalKillsPerMission          { get; }       // Sum of PlayerKillsPerMission and NonPlayerKillsPerMission?
        public double TotalSharedKillsPerMission    { get; }       // Sum of PlayerSharedKillsPerMission and NonPlayerSharedKillsPerMission?

        //  Player Kills
        public double PlayerKillsPerMission         { get; }        // Calculated value?
        public double PlayerSharedKillsPerMission   { get; }        // Calculated value?

        //  Non-Player Kills
        public double NonPlayerKillsPerMission          { get; }    // Calculated value?
        public double NonPlayerSharedKillsPerMission    { get; }    // Calculated value?

        //  Assists
        public double AssistsPerMission { get; }                    //  Calculated value?

        //**TOTAL LOSSES**//
        public uint TotalCraftLosses        { get; set; }           //  Calculated value?
        public uint LossesToPlayerPilots    { get; set; }           //  Sum of LossesToPlayersByRank?
        public uint LossesToNonPlayerPilots { get; set; }
        public uint LossesToStarships       { get; set; }
        public uint LossesToMines           { get; set; }
        public uint LossesFromCollisions    { get; set; }

        //**LOSSES TO PLAYERS BY RANK**//
        public List<PilotRating>? LossesToPlayersByRank { get; set; }

        public ModeStats()
        {
            CraftKillsByType        = new List<CraftTypes>((int)CraftTypes.MAX_CRAFT_TYPES);
            CraftSharedKillsByType  = new List<CraftTypes>((int)CraftTypes.MAX_CRAFT_TYPES);
        }
    }
}
