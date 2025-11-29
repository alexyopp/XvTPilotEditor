using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.Models
{
    public class PilotRecordBase
    {
        // TODO: Consider creating directly from filebytes/exporting filebytes, rather than PilotFileSchema objects.

        public string PilotName { get; set; } = string.Empty;                                                 // char[14]
        public int TotalScore { get; set; }
        public uint PlayerID { get; set; }
        public int ContinuedOrReflownMission { get; set; }
        public int IsHosting { get; set; }
        public int NumHumanPlayersInMission { get; set; }
        public int FrontFlyMode { get; set; }
        public int[] Unknown0x26 { get; set; } = Array.Empty<int>();                                           // int[10]
        public int[] Unknown0x166 { get; set; } = Array.Empty<int>();                                           // int[10]
        public int[] Unknown0x186 { get; set; } = Array.Empty<int>();                                           // int[10]

        //...

        public int PromoPoints { get; set; }
        public int WorsePromoPoints { get; set; }
        public int RankAdjustmentApplied { get; set; }
        public int PercentToNextRank { get; set; }
        public MissionCategoryRecord TotalCategoryScore { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord NumFlownNonSeries { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord NumFlownSeries { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalKills { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord FriendlyKills { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecordByPlayerRating TotalFullKillsOnPlayerRating { get; set; } = new MissionCategoryRecordByPlayerRating();                    // int[3][25]
        public MissionCategoryRecordByPlayerRating TotalSharedKillsOnPlayerRating { get; set; } = new MissionCategoryRecordByPlayerRating();                    // int[3][25]
        public MissionCategoryRecordByPlayerRating TotalAssistsOnPlayerRating { get; set; } = new MissionCategoryRecordByPlayerRating();                    // int[3][25]
        public MissionCategoryRecordByAIRating TotalFullKillsOnAIRank { get; set; } = new MissionCategoryRecordByAIRating();                        // int[3][6]
        public MissionCategoryRecordByAIRating TotalSharedKillsOnAIRank { get; set; } = new MissionCategoryRecordByAIRating();                        // int[3][6]
        public MissionCategoryRecordByAIRating TotalAssistsOnAIRank { get; set; } = new MissionCategoryRecordByAIRating();                        // int[3][6]
        public MissionCategoryRecord TotalHiddenCargoFound { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalLaserHit { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalLaserFired { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalWarheadHit { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalWarheadFired { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalCraftLosses { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalLossesFromCollisions { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalLossesFromStarships { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecord TotalLossesFromMines { get; set; } = new MissionCategoryRecord();                                  // int[3]
        public MissionCategoryRecordByPlayerRating TotalLossesFromPlayerRank { get; set; } = new MissionCategoryRecordByPlayerRating();                    // int[3][25]
        public MissionCategoryRecordByAIRating TotalLossesFromAIRank { get; set; } = new MissionCategoryRecordByAIRating();                        // int[3][6]

        //...

        public uint CurrentRank { get; set; }
        public int TotalCountMissionsFlown { get; set; }
        public int[] RankAchievedOnMissionCount { get; set; } = Array.Empty<int>();                                           // int[25]
        public string RankString { get; set; } = string.Empty;                                                 // char[32]
        public int DebriefMissionScore { get; set; }
        public int[] DebriefFullKillsOnPlayer { get; set; } = Array.Empty<int>();                                           // int[8]
        public int[] DebriefSharedKillsOnPlayer { get; set; } = Array.Empty<int>();                                           // int[8]
        public int[] DebriefFullKillsOnFG { get; set; } = Array.Empty<int>();                                           // int[48]
        public int[] DebriefSharedKillsOnFG { get; set; } = Array.Empty<int>();                                           // int[48]
        public int[] DebriefFullKillsByPlayer { get; set; } = Array.Empty<int>();                                           // int[8]
        public int[] DebriefSharedKillsByPlayer { get; set; } = Array.Empty<int>();                                           // int[8]
        public int[] DebriefFullKillsByFG { get; set; } = Array.Empty<int>();                                           // int[48]
        public int[] DebriefSharedKillsByFG { get; set; } = Array.Empty<int>();                                           // int[48]
        public int[] DebriefMeleeAIRankFG { get; set; } = Array.Empty<int>();                                           // int[48]

        //...

        public ConnectedPlayerRecord[] ConnectedPlayer { get; set; } = new ConnectedPlayerRecord[Constants.MAX_CONNECTED_PLAYERS];   // ConnectedPlayerRecord[8]
        public TeamResultRecord[] DebriefTeamResult { get; set; } = new TeamResultRecord[10];                                     // int[10][6]

        public PilotRecordBase()
        {
        }

        // Convert helper for MissionCategoryRecord -> int[]
        public static int[] ToIntArray(MissionCategoryRecord r)
        {
            return r == null ? Array.Empty<int>() : new[] { r.Exercise, r.Melee, r.CombatEngagement };
        }

        // Convert helper for MissionCategoryRecord -> PLTCategoryTypeRecord
        public static PLTCategoryTypeRecord ToPLTCategoryTypeRecord(MissionCategoryRecord r)
        {
            PLTCategoryTypeRecord newRecord;
            newRecord.exercise = r.Exercise;
            newRecord.melee = r.Melee;
            newRecord.combat = r.CombatEngagement;

            return newRecord;
        }

        // Convert helper for MissionCategoryRecordByPlayerRating -> PLTPlayerRankCountRecord
        public static PLTPlayerRankCountRecord ToPLTPlayerRankCountRecord(MissionCategoryRecordByPlayerRating r)
        {
            PLTPlayerRankCountRecord newRecord;
            newRecord.exercise = r.Exercise;
            newRecord.melee = r.Melee;
            newRecord.combat = r.CombatEngagement;

            return newRecord;
        }

        // Convert helper for MissionCategoryRecordByAIRating -> PLTAIRankCountRecord
        public static PLTAIRankCountRecord ToPLTAIRankCountRecord(MissionCategoryRecordByAIRating r)
        {
            PLTAIRankCountRecord newRecord;
            newRecord.exercise = r.Exercise;
            newRecord.melee = r.Melee;
            newRecord.combat = r.CombatEngagement;

            return newRecord;
        }

        // Convert helper for ConnectedPlayerRecord[] -> PLTConnectedPlayerData[]
        public static PLTConnectedPlayerData[] ToPLTConnectedPlayerDataArray(ConnectedPlayerRecord[] connectedPlayerRecord)
        {
            PLTConnectedPlayerData[] pltConnectedPlayerDataArray = new PLTConnectedPlayerData[Constants.MAX_CONNECTED_PLAYERS];
            for (uint idx = 0; idx < Constants.MAX_CONNECTED_PLAYERS; ++idx)
            {
                pltConnectedPlayerDataArray[idx].pilotLongNameUnused = connectedPlayerRecord[idx].PilotLongNameUnused;      // char[14]
                pltConnectedPlayerDataArray[idx].pilotShortName = connectedPlayerRecord[idx].PilotShortName;                // char[14]
                pltConnectedPlayerDataArray[idx].fgIndex = connectedPlayerRecord[idx].FGIndex;
                pltConnectedPlayerDataArray[idx].DPPlayerID = connectedPlayerRecord[idx].DPPlayerID;
                pltConnectedPlayerDataArray[idx].pilotRank = connectedPlayerRecord[idx].PilotRank;
                pltConnectedPlayerDataArray[idx].playerScore = connectedPlayerRecord[idx].PlayerScore;
                pltConnectedPlayerDataArray[idx].fullKills = connectedPlayerRecord[idx].FullKills;
                pltConnectedPlayerDataArray[idx].sharedKills = connectedPlayerRecord[idx].SharedKills;
                pltConnectedPlayerDataArray[idx].unusedInspections = connectedPlayerRecord[idx].UnusedInspections;
                pltConnectedPlayerDataArray[idx].assistKills = connectedPlayerRecord[idx].AssistKills;
                pltConnectedPlayerDataArray[idx].losses = connectedPlayerRecord[idx].Losses;
                pltConnectedPlayerDataArray[idx].craftType = connectedPlayerRecord[idx].CraftType;
                pltConnectedPlayerDataArray[idx].optionalCraftIndex = connectedPlayerRecord[idx].OptionalCraftIndex;
                pltConnectedPlayerDataArray[idx].optionalWarhead = connectedPlayerRecord[idx].OptionalWarhead;
                pltConnectedPlayerDataArray[idx].optionalBeam = connectedPlayerRecord[idx].OptionalBeam;
                pltConnectedPlayerDataArray[idx].optionalCountermeasure = connectedPlayerRecord[idx].OptionalCountermeasure;
                pltConnectedPlayerDataArray[idx].hasDisconnectedFromHostUNK = connectedPlayerRecord[idx].HasDisconnectedFromHostUNK;
            }

            return pltConnectedPlayerDataArray;
        }

        // Convert helper for TeamResultRecord[] -> PLTTeamResultRecord[]
        public static PLTTeamResultRecord[] ToPLTTeamResultRecordArray(TeamResultRecord[] teamResultRecord)
        {
            PLTTeamResultRecord[] pltTeamResultRecordArray = new PLTTeamResultRecord[10];
            for (uint idx = 0; idx < 10; ++idx)
            {
                pltTeamResultRecordArray[idx].totalMissionScore = teamResultRecord[idx].TotalMissionScore;
                pltTeamResultRecordArray[idx].isMissionComplete = teamResultRecord[idx].IsMissionComplete;
                pltTeamResultRecordArray[idx].unknown0x8 = teamResultRecord[idx].Unknown0x8;
                pltTeamResultRecordArray[idx].timeMissionComplete = teamResultRecord[idx].TimeMissionComplete;
                pltTeamResultRecordArray[idx].fullKills = teamResultRecord[idx].FullKills;
                pltTeamResultRecordArray[idx].sharedKills = teamResultRecord[idx].SharedKills;
                pltTeamResultRecordArray[idx].losses = teamResultRecord[idx].Losses;
            }

            return pltTeamResultRecordArray;
        }
    }

    public class MissionCategoryRecord
    {
        public int Exercise { get; set; }
        public int Melee { get; set; }
        public int CombatEngagement { get; set; }

        public MissionCategoryRecord()
        {
            Exercise = 0;
            Melee = 0;
            CombatEngagement = 0;
        }

        public MissionCategoryRecord(int exercise, int melee, int combatEngagement)
        {
            Exercise = exercise;
            Melee = melee;
            CombatEngagement = combatEngagement;
        }

        public MissionCategoryRecord(int[] missionCategoryRecord)
        {
            if (missionCategoryRecord.Length != Enum.GetNames(typeof(MissionType)).Length)
            {
                throw new ArgumentException("missionCategoryRecord array must have exactly 3 elements.", nameof(missionCategoryRecord));
            }

            Exercise = missionCategoryRecord[(int)MissionType.Exercise];
            Melee = missionCategoryRecord[(int)MissionType.Melee];
            CombatEngagement = missionCategoryRecord[(int)MissionType.Combat];
        }

        public MissionCategoryRecord(PLTCategoryTypeRecord missionCategoryRecord)
        {
            Exercise = missionCategoryRecord.exercise;
            Melee = missionCategoryRecord.melee;
            CombatEngagement = missionCategoryRecord.combat;
        }
    }

    public class MissionCategoryRecordByPlayerRating
    {
        public int[] Exercise { get; private set; } = Array.Empty<int>();
        public int[] Melee { get; private set; } = Array.Empty<int>();
        public int[] CombatEngagement { get; private set; } = Array.Empty<int>();

        public MissionCategoryRecordByPlayerRating()
        {
        }

        public MissionCategoryRecordByPlayerRating(int[] exercise, int[] melee, int[] combatEngagement)
        {
            if (exercise.Length != Enum.GetNames(typeof(PilotRating)).Length)
            {
                throw new ArgumentException("MissionCategoryRecordByPlayerRating array must have exactly " + Enum.GetNames(typeof(PilotRating)).Length + " elements.", nameof(exercise));
            }
            if (melee.Length != Enum.GetNames(typeof(PilotRating)).Length)
            {
                throw new ArgumentException("MissionCategoryRecordByPlayerRating array must have exactly " + Enum.GetNames(typeof(PilotRating)).Length + " elements.", nameof(melee));
            }
            if (combatEngagement.Length != Enum.GetNames(typeof(PilotRating)).Length)
            {
                throw new ArgumentException("MissionCategoryRecordByPlayerRating array must have exactly " + Enum.GetNames(typeof(PilotRating)).Length + " elements.", nameof(combatEngagement));
            }

            Exercise = exercise;
            Melee = melee;
            CombatEngagement = combatEngagement;
        }

        //public MissionCategoryRecordByPlayerRating(int[] missionCategoryRecord)
        //{
        //    if (missionCategoryRecord.Length != Enum.GetNames(typeof(MissionType)).Length)
        //    {
        //        throw new ArgumentException("missionCategoryRecord array must have exactly 3 elements.", nameof(missionCategoryRecord));
        //    }

        //    MissionCategoryRecordByPlayerRating(missionCategoryRecord[(int)MissionType.Exercise], missionCategoryRecord[(int)MissionType.Melee], missionCategoryRecord[(int)MissionType.Combat]);
        //}

        public MissionCategoryRecordByPlayerRating(PLTPlayerRankCountRecord missionCategoryRecord)
        {
            Exercise = missionCategoryRecord.exercise;
            Melee = missionCategoryRecord.melee;
            CombatEngagement = missionCategoryRecord.combat;
        }
    }

    public class MissionCategoryRecordByAIRating
    {
        public int[] Exercise { get; private set; } = Array.Empty<int>();
        public int[] Melee { get; private set; } = Array.Empty<int>();
        public int[] CombatEngagement { get; private set; } = Array.Empty<int>();

        public MissionCategoryRecordByAIRating()
        {
        }

        public MissionCategoryRecordByAIRating(int[] exercise, int[] melee, int[] combatEngagement)
        {
            if (exercise.Length != 6)
            {
                throw new ArgumentException("MissionCategoryRecordByAIRating array must have exactly 25 elements.", nameof(exercise));
            }
            if (melee.Length != 6)
            {
                throw new ArgumentException("MissionCategoryRecordByAIRating array must have exactly 25 elements.", nameof(melee));
            }
            if (combatEngagement.Length != 6)
            {
                throw new ArgumentException("MissionCategoryRecordByAIRating array must have exactly 25 elements.", nameof(combatEngagement));
            }

            Exercise = exercise;
            Melee = melee;
            CombatEngagement = combatEngagement;
        }

        //public MissionCategoryRecordByAIRating(int[] missionCategoryRecord)
        //{
        //    if (missionCategoryRecord.Length != Enum.GetNames(typeof(MissionType)).Length)
        //    {
        //        throw new ArgumentException("missionCategoryRecord array must have exactly 3 elements.", nameof(missionCategoryRecord));
        //    }

        //    MissionCategoryRecordByAIRating(missionCategoryRecord[(int)MissionType.Exercise], missionCategoryRecord[(int)MissionType.Melee], missionCategoryRecord[(int)MissionType.Combat]);
        //}

        public MissionCategoryRecordByAIRating(PLTAIRankCountRecord missionCategoryRecord)
        {
            Exercise = missionCategoryRecord.exercise;
            Melee = missionCategoryRecord.melee;
            CombatEngagement = missionCategoryRecord.combat;
        }
    }

    public class ConnectedPlayerRecord
    {
        public string PilotLongNameUnused { get; set; } = string.Empty;
        public string PilotShortName { get; set; } = string.Empty;
        public int FGIndex { get; set; }
        public uint DPPlayerID { get; set; }
        public int PilotRank { get; set; }
        public int PlayerScore { get; set; }
        public int FullKills { get; set; }
        public int SharedKills { get; set; }
        public int UnusedInspections { get; set; }
        public int AssistKills { get; set; }
        public int Losses { get; set; }
        public int CraftType { get; set; }
        public int OptionalCraftIndex { get; set; }
        public int OptionalWarhead { get; set; }
        public int OptionalBeam { get; set; }
        public int OptionalCountermeasure { get; set; }
        public int HasDisconnectedFromHostUNK { get; set; }

        public ConnectedPlayerRecord()
        {
        }

        public ConnectedPlayerRecord(PLTConnectedPlayerData connectedPlayerRecord)
        {
            PilotLongNameUnused = connectedPlayerRecord.pilotLongNameUnused ?? string.Empty;
            PilotShortName = connectedPlayerRecord.pilotShortName ?? string.Empty;
            FGIndex = connectedPlayerRecord.fgIndex;
            DPPlayerID = connectedPlayerRecord.DPPlayerID;
            PilotRank = connectedPlayerRecord.pilotRank;
            PlayerScore = connectedPlayerRecord.playerScore;
            FullKills = connectedPlayerRecord.fullKills;
            SharedKills = connectedPlayerRecord.sharedKills;
            UnusedInspections = connectedPlayerRecord.unusedInspections;
            AssistKills = connectedPlayerRecord.assistKills;
            Losses = connectedPlayerRecord.losses;
            CraftType = connectedPlayerRecord.craftType;
            OptionalCraftIndex = connectedPlayerRecord.optionalCraftIndex;
            OptionalWarhead = connectedPlayerRecord.optionalWarhead;
            OptionalBeam = connectedPlayerRecord.optionalBeam;
            OptionalCountermeasure = connectedPlayerRecord.optionalCountermeasure;
            HasDisconnectedFromHostUNK = connectedPlayerRecord.hasDisconnectedFromHostUNK;
        }
    }

    public class TeamResultRecord
    {
        public int TotalMissionScore { get; set; }
        public int IsMissionComplete { get; set; }
        public int Unknown0x8 { get; set; }
        public int TimeMissionComplete { get; set; }
        public int FullKills { get; set; }
        public int SharedKills { get; set; }
        public int Losses { get; set; }

        public TeamResultRecord()
        {
        }

        public TeamResultRecord(PLTTeamResultRecord teamResultRecord)
        {
            TotalMissionScore = teamResultRecord.totalMissionScore;
            IsMissionComplete = teamResultRecord.isMissionComplete;
            Unknown0x8 = teamResultRecord.unknown0x8;
            TimeMissionComplete = teamResultRecord.timeMissionComplete;
            FullKills = teamResultRecord.fullKills;
            SharedKills = teamResultRecord.sharedKills;
            Losses = teamResultRecord.losses;
        }
    }
}
