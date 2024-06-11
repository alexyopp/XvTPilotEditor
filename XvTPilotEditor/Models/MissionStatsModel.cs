using System;
using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class MissionStatsModel
    {
        //**    Summary of Kills    **//
        //
        public uint TotalKills              { get; set; }               // Sum of PlayerKillsByRank and CraftKillsByType?
        public uint TotalSharedKills        { get; set; }               // Sum of PlayerSharedKillsByRank and CraftSharedKillsByType?

        public uint PlayerKills             { get; set; }               // Sum of PlayerKillsByRank?
        public uint PlayerSharedKills       { get; set; }               // Sum of PlayerSharedKillsByRank?

        public uint NonPlayerKills          { get; set; }               // Sum of CraftKillsByType?
        public uint NonPlayerSharedKills    { get; set; }               // Sum of CraftSharedKillsByType?

        public uint Assists                 { get; set; }

        public uint HiddenCargoFound        { get; set; }

        public uint LaserAccuracy           { get; set; }               //  Percentage, 0...100

        public uint WarheadAccuracy         { get; set; }               //  Percentage, 0...100
        //

        //**    Player Kills by Rank    **//
        //
        public Dictionary<PilotRating, uint> PlayerKillsByRank        { get; set; }
        public Dictionary<PilotRating, uint> PlayerSharedKillsByRank  { get; set; }
        //

        //**    Craft Kills by Type     **//
        //
        public Dictionary<CraftType, uint> CraftKillsByType          { get; set; }
        public Dictionary<CraftType, uint> CraftSharedKillsByType    { get; set; }
        //

        //**    Averages per Mission    **//
        //
        public double TotalKillsPerMission              { get; set; }   // Sum of PlayerKillsPerMission and NonPlayerKillsPerMission?
        public double TotalSharedKillsPerMission        { get; set; }   // Sum of PlayerSharedKillsPerMission and NonPlayerSharedKillsPerMission?

        public double PlayerKillsPerMission             { get; set; }   // Calculated value?
        public double PlayerSharedKillsPerMission       { get; set; }   // Calculated value?

        public double NonPlayerKillsPerMission          { get; set; }   // Calculated value?
        public double NonPlayerSharedKillsPerMission    { get; set; }   // Calculated value?

        public double AssistsPerMission                 { get; set; }   //  Calculated value?
        //

        //**    Total Losses    **//
        //
        public uint TotalCraftLosses        { get; set; }               //  Calculated value?
        public uint LossesToPlayerPilots    { get; set; }               //  Sum of LossesToPlayersByRank?
        public uint LossesToNonPlayerPilots { get; set; }
        public uint LossesToStarships       { get; set; }
        public uint LossesToMines           { get; set; }
        public uint LossesFromCollisions    { get; set; }
        //

        //**    Losses to Players by Rank   **//
        //
        public Dictionary<PilotRating, uint> LossesToPlayersByRank { get; set; }
        //

        public MissionStatsModel()
        {
            PlayerKillsByRank = new Dictionary<PilotRating, uint>();
            PlayerSharedKillsByRank = new Dictionary<PilotRating, uint>();
            LossesToPlayersByRank = new Dictionary<PilotRating, uint>();
            foreach (PilotRating pilotRating in Enum.GetValues<PilotRating>())
            {
                PlayerKillsByRank.Add(pilotRating, 0);
                PlayerSharedKillsByRank.Add(pilotRating, 0);
                LossesToPlayersByRank.Add(pilotRating, 0);
            }

            CraftKillsByType = new Dictionary<CraftType, uint>();
            CraftSharedKillsByType = new Dictionary<CraftType, uint>();
            foreach (CraftType craftType in Enum.GetValues<CraftType>())
            {
                CraftKillsByType.Add(craftType, 0);
                CraftSharedKillsByType.Add(craftType, 0);
            }
        }
    }
}
