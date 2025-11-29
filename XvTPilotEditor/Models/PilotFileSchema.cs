using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XvTPilotEditor.Models
{
    public class PilotFileSchema
    {
        // Note: Some consolidation can be done; example:
        //      "PLTCategoryTypeRecord totalCategoryScore" in PltFileRecord is the same as "int totalScoreEMC[3]" in Pl2FileRecord

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTCategoryTypeRecord
        {
            public int exercise;
            public int melee;
            public int combat;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTPlayerRankCountRecord
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] exercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] melee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] combat;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTAIRankCountRecord
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] exercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] melee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] combat;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTTournTeamRecord
        {
            public int teamParticipationState;
            public int totalTeamScore;
            public int numberOfMeleeRankingsFirst;
            public int numberOfMeleeRankingsSecond;
            public int numberOfMeleeRankingsThird;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTConnectedPlayerData
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string pilotLongNameUnused;     // char[14]

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string pilotShortName;      // char[14]

            public int fgIndex;
            public uint DPPlayerID;    // DWORD -> DPID
            public int pilotRank;
            public int playerScore;
            public int fullKills;
            public int sharedKills;
            public int unusedInspections;
            public int assistKills;
            public int losses;
            public int craftType;
            public int optionalCraftIndex;
            public int optionalWarhead;
            public int optionalBeam;
            public int optionalCountermeasure;
            public int hasDisconnectedFromHostUNK;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTTeamResultRecord
        {
            public int totalMissionScore;
            public int isMissionComplete;
            public int unknown0x8;
            public int timeMissionComplete;
            public int fullKills;
            public int sharedKills;
            public int losses;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTEarnedMedalRecord
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] meleePlaqueCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] tournamentPlaqueCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] exerciseBadgeCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] battleMedalCount;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTMissionSPRecord
        {
            public int unknown0x0;
            public int totalCountFlown;
            public int totalCountVictory;
            public int totalCountFailure;
            public int bestScore;
            public int bestTimeAsSeconds;
            public int bestFinishRank;
            public int bestEvaluationBadge;
            public int bestWinningMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTMissionMPRecord
        {
            public int unknown0x0;
            public int totalCountFlown;
            public int totalCountFinishedFirst;
            public int totalCountFinishedSecond;
            public int totalCountFinishedThird;
            public int totalCountVictory;
            public int totalCountFailure;
            public int bestScore;
            public int bestTimeAsSeconds;
            public int bestFinishPlace;
            public int bestEvaluationBadge;
            public int bestWinningMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTTournSPRecord
        {
            public int unknown0x0;
            public int totalCountFlown;
            public int numberOfFinishesAnyUNK;
            public int numberOfFinishesFirst;
            public int numberOfFinishesSecond;
            public int numberOfFinishesThird;
            public int bestScore;
            public int bestFinish;
            public int bestEvaluationMedal;
            public int bestFinishPointMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTTournMPRecord
        {
            public int unknown0x0;
            public int totalCountFlown;
            public int numberOfFinishesAnyUNK;
            public int numberOfFinishesFirst;
            public int numberOfFinishesSecond;
            public int numberOfFinishesThird;
            public int bestScore;
            public int bestFinish;
            public int unknown0x20;
            public int bestEvaluationMedal;
            public int bestFinishPointMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTBattleSPRecord
        {
            public int unknown0x0;
            public int totalCountFlown;
            public int totalCountVictory;
            public int totalCountFailure;
            public int totalCount10MissionMarathonUNK;
            public int bestScore;
            public int unknown0x18;
            public int bestEvaluationMedal;
            public int bestVictoryMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTBattleMPRecord
        {
            public int unknown0x0;
            public int totalCountFlown;
            public int totalCountVictory;
            public int totalCountFailure;
            public int totalCount10MissionMarathonUNK;
            public int bestScore;
            public int unknown0x18;
            public int unknown0x1C;
            public int bestEvaluationMedal;
            public int bestVictoryMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTFactionRecord
        {
            public int totalMissionsFlown;
            public int lastMissionTeam;
            public int lastMissionType;
            public int lastMissionTrainingSelected;
            public int lastMissionMeleeSelected;
            public int lastMissionTournamentSelected;
            public int lastMissionCombatSelected;
            public int lastMissionBattleSelected;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] unknown0x20;

            public PLTEarnedMedalRecord earnedMedalCount;
            public int debriefMeleePlaqueType;
            public int debriefTournamentTrophyType;
            public int debriefMissionBadgeType;
            public int debriefBattleMedalType;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] UnknownRecord4;

            public int totalFactionScore;
            public PLTCategoryTypeRecord totalCategoryScore;
            public PLTCategoryTypeRecord totalCategoryFlown;
            public int totalCampaignExerciseFlown;
            public int totalTournamentMeleeFlown;
            public int totalBattleCombatFlown;
            public PLTCategoryTypeRecord totalFullKills;
            public PLTCategoryTypeRecord totalFriendlyFullKills;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalFullKillsByShipExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalFullKillsByShipMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalFullKillsByShipCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalSharedKillsOfShipExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalSharedKillsOfShipMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalSharedKillsOfShipCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalAssistKillsOfShipExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalAssistKillsOfShipMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalAssistKillsOfShipCombat;

            public PLTPlayerRankCountRecord totalFullKillsOfPlayerRank;
            public PLTPlayerRankCountRecord totalSharedKillsOfPlayerRank;
            public PLTPlayerRankCountRecord totalAssistKillsOfPlayerRank;
            public PLTAIRankCountRecord totalFullKillsOfAIRank;
            public PLTAIRankCountRecord totalSharedKillsOfAIRank;
            public PLTAIRankCountRecord totalAssistKillsOfAIRank;
            public PLTCategoryTypeRecord totalHiddenCargoFound;
            public PLTCategoryTypeRecord totalCannonHit;
            public PLTCategoryTypeRecord totalCannonFired;
            public PLTCategoryTypeRecord totalWarheadHit;
            public PLTCategoryTypeRecord totalWarheadFired;
            public PLTCategoryTypeRecord totalLosses;
            public PLTCategoryTypeRecord totalLossesByCollision;
            public PLTCategoryTypeRecord totalLossesByStarship;
            public PLTCategoryTypeRecord totalLossesByMines;
            public PLTPlayerRankCountRecord totalLossesByPlayerRank;
            public PLTAIRankCountRecord totalLossesByAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public PLTMissionSPRecord[] missionSPExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionSPRecord[] missionSPMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionSPRecord[] missionSPCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public PLTMissionMPRecord[] missionMPExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionMPRecord[] missionMPMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionMPRecord[] missionMPCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTTournSPRecord[] missionSPTourn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTTournMPRecord[] missionMPTourn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTBattleSPRecord[] missionSPBattle;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTBattleMPRecord[] missionMPBattle;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTFileRecord
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string PilotName;   // char[14]

            public int TotalScore;
            public uint PlayerID;      // DWORD -> DPID
            public int continuedOrReflownMission;
            public int isHosting;
            public int numHumanPlayersInMission;
            public int frontFlyMode;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
            public int[] unknown0x26;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] unknown0x166;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
            public int[] unknown0x186;

            public int lastTeamNumber;
            public int lastSelectedMissionType;
            public int lastSelectedTraining;
            public int lastSelectedMelee;
            public int lastSelectedTournament;
            public int lastSelectedCombat;
            public int lastSelectedBattle;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
            public string GameNameString;  // char[22]

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] unknown0x2F8;    // BYTE

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
            public string GameNameString2;     // char[22]

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] unknown0x318;    // BYTE

            public int lastMissionWasNonSpecific;
            public int unknown0x326;
            public int PromoPoints;
            public int WorsePromoPoints;
            public int RankAdjustmentApplied;
            public int PercentToNextRank;
            public PLTCategoryTypeRecord totalCategoryScore;
            public PLTCategoryTypeRecord numFlownNonSeries;
            public PLTCategoryTypeRecord numFlownSeries;
            public PLTCategoryTypeRecord totalKillCount;
            public PLTCategoryTypeRecord numVanillaFriendlyKills;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftFullKillsExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftFullKillsMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftFullKillsCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftSharedKillsExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftSharedKillsMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftSharedKillsCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftAssistKillsExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftAssistKillsMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] totalCraftAssistKillsCombat;

            public PLTPlayerRankCountRecord TotalFullKillsOnPlayerRank;
            public PLTPlayerRankCountRecord TotalSharedKillsOnPlayerRank;
            public PLTPlayerRankCountRecord TotalAssistKillsOnPlayerRank;
            public PLTAIRankCountRecord TotalFullKillsOnAIRank;
            public PLTAIRankCountRecord TotalSharedKillsOnAIRank;
            public PLTAIRankCountRecord TotalAssistKillsOnAIRank;
            public PLTCategoryTypeRecord totalHiddenCargoFound;
            public PLTCategoryTypeRecord totalLaserHit;
            public int totalLaserFiredExercise;
            public int totalLaserFiredMelee;
            public int totalLaserFiredCombat;
            public int totalWarheadHitExercise;
            public int totalWarheadHitMelee;
            public int totalWarheadHitCombat;
            public int totalWarheadFiredExercise;
            public int totalWarheadFiredMelee;
            public int totalWarheadFiredCombat;
            public int totalCraftLossesExercise;
            public int totalCraftLossesMelee;
            public int totalCraftLossesCombat;
            public int totalLossesFromCollisionExercise;
            public int totalLossesFromCollisionMelee;
            public int totalLossesFromCollisionCombat;
            public int totalLossesFromStarshipsExercise;
            public int totalLossesFromStarshipsMelee;
            public int totalLossesFromStarshipsCombat;
            public int totalLossesFromMinesExercise;
            public int totalLossesFromMinesMelee;
            public int totalLossesFromMinesCombat;
            public PLTPlayerRankCountRecord TotalLossesFromPlayerRank;
            public PLTAIRankCountRecord TotalLossesFromAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] unknown0x1612;       // BYTE

            public int unknownPlaqueWon;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public PLTTournTeamRecord[] TournTeamRecords;

            public int numHumanPlayersUNK;
            public int numTeamsUNK;
            public int unknown0x170E;
            public int unknown0x1712;
            public int numCombatFlownInLastBattle;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2052)]
            public byte[] unknown0x171A;       // BYTE

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] battleCombatMissionID;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1012)]
            public byte[] unknown0x1F2E;       // BYTE

            public int totalScoreForCurrentBattleUNK;
            public uint CurrentRank;
            public int TotalCountMissionsFlown;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] RankAchievedOnMissionCount;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string RankString;      // char[32]

            public int debriefMissionScore;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefFullKillsOnPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefSharedKillsOnPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefFullKillsOnFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefSharedKillsOnFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefFullKillsByPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefSharedKillsByPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefFullKillsByFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefSharedKillsByFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefMeleeAIRankFG;

            public PLTCategoryTypeRecord UnknownRecord1;
            public PLTCategoryTypeRecord UnknownRecord2;
            public PLTCategoryTypeRecord UnknownRecord3;
            public PLTCategoryTypeRecord debriefEnemyKills;
            public PLTCategoryTypeRecord debriefFriendlyKills;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefFullKillsByShipTypeA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefFullKillsByShipTypeB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefFullKillsByShipTypeC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefSharedKillsByShipTypeA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefSharedKillsByShipTypeB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefSharedKillsByShipTypeC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefAssistKillsByShipTypeA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefAssistKillsByShipTypeB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public int[] debriefAssistKillsByShipTypeC;

            public PLTPlayerRankCountRecord debriefFullKillsOnPlayerRank;
            public PLTPlayerRankCountRecord debriefSharedKillsOnPlayerRank;
            public PLTPlayerRankCountRecord debriefAssistKillsOnPlayerRank;
            public PLTAIRankCountRecord debriefFullKillsOnAIRank;
            public PLTAIRankCountRecord debriefSharedKillsOnAIRank;
            public PLTAIRankCountRecord debriefAssistKillsOnAIRank;
            public PLTCategoryTypeRecord debriefNumHiddenCargoFound;
            public PLTCategoryTypeRecord debriefNumCannonHits;
            public PLTCategoryTypeRecord debriefNumCannonFired;
            public PLTCategoryTypeRecord debriefNumWarheadHits;
            public PLTCategoryTypeRecord debriefNumWarheadFired;
            public PLTCategoryTypeRecord debriefNumCraftLosses;
            public PLTCategoryTypeRecord debriefCraftLossesFromCollision;
            public PLTCategoryTypeRecord debriefCraftLossesFromStarship;
            public PLTCategoryTypeRecord debriefCraftLossesFromMine;
            public PLTPlayerRankCountRecord debriefLossesFromPlayerRank;
            public PLTAIRankCountRecord debriefLossesFromAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public PLTConnectedPlayerData[] connectedPlayerData;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public PLTTeamResultRecord[] debriefTeamResult;

            public int lastSelectedFaction;
            public PLTFactionRecord rebelSingleplayerData;
            public PLTFactionRecord imperialSingleplayerData;
            public PLTFactionRecord rebelMultiplayerData;
            public PLTFactionRecord imperialMultiplayerData;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTTournamentProgressState
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            public char[] unknown1;    // char[36]

            public int completedMissionCount;
            public int totalMissionCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public PLTTournTeamRecord[] teamRecord;

            public int playersActive;
            public int teamsActive;
            public int unknown2;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTBattleProgressState
        {
            public int MissionsFlown;
            public int CombatMissionID;
            public int TotalMissionCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] Outcome;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] BattleListIndex;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] CombatMissionListIndex;

            public int NumPlayers;
            public int TotalScore;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PL2DebriefRecord
        {
            public PLTCategoryTypeRecord UnknownRecord1;
            public PLTCategoryTypeRecord UnknownRecord2;
            public PLTCategoryTypeRecord UnknownRecord3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] enemyKillsEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] friendlyKillsEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 900)]
            public int[] TotalKillCountByCraftType;

            public PLTPlayerRankCountRecord FullKillsOnPlayerRank;
            public PLTPlayerRankCountRecord SharedKillsOnPlayerRank;
            public PLTPlayerRankCountRecord AssistKillsOnPlayerRank;
            public PLTAIRankCountRecord FullKillsOnAIRank;
            public PLTAIRankCountRecord SharedKillsOnAIRank;
            public PLTAIRankCountRecord AssistKillsOnAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] NumHiddenCargoFoundEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] NumCannonHitsEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] NumCannonFiredEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] NumWarheadHitsEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] NumWarheadFiredEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] NumCraftLossesEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] CraftLossesFromCollisionEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] CraftLossesFromStarshipEXX;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] CraftLossesFromMineEXX;

            public PLTPlayerRankCountRecord LossesFromPlayerRank;
            public PLTAIRankCountRecord LossesFromAIRank;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PL2CampaignStatusSPRecord
        {
            public int unknown0x0;
            public int isStartedUNK;
            public int missionNumber;
            public int isFinished;
            public int bestScore;
            public int unknown0x14;
            public int unknown0x18;
            public int unknown0x1C;
            public int unknown0x20;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PL2CampaignRecord
        {
            public int IDNumber;
            public int totalCountFlown;
            public int isMissionCompleteWithoutCheat;
            public int bestScore;
            public int bestEvaluationBadge;
            public int bestTimeAsSeconds;
            public int isMissionComplete;
            public int UIFrameTimerHelper;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PL2FactionRecord
        {
            public int totalMissionsFlown;
            public int lastKnownTeam;
            public int lastKnownFolderIndex;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] selectedMissionIDNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] unknown0x24;

            public int isMissionCategorySeries;
            public int activeMissionIDNum;
            public PLTEarnedMedalRecord earnedMedalCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] debriefMedalTypeMTEB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] UnknownRecord4;

            public int totalFactionScore;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalScoreEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalFlownNonSeriesEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalFlownSeriesEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalFullKillsEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalFriendlyFullKillsEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 300)]
            public int[] totalFullKillsOnCraftEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 300)]
            public int[] totalSharedKillsOnCraftEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 300)]
            public int[] totalAssistKillsOnCraftEMC;

            public PLTPlayerRankCountRecord totalFullKillsOfPlayerRank;
            public PLTPlayerRankCountRecord totalSharedKillsOfPlayerRank;
            public PLTPlayerRankCountRecord totalAssistKillsOfPlayerRank;
            public PLTAIRankCountRecord totalFullKillsOfAIRank;
            public PLTAIRankCountRecord totalSharedKillsOfAIRank;
            public PLTAIRankCountRecord totalAssistKillsOfAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalHiddenCargoFoundEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalCannonHitEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalCannonFiredEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalWarheadHitEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalWarheadFiredEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalLossesEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalLossesByCollisionEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalLossesByStarshipEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalLossesByMinesEMC;

            public PLTPlayerRankCountRecord totalLossesByPlayerRank;
            public PLTAIRankCountRecord totalLossesByAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public PLTMissionSPRecord[] missionSPExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionSPRecord[] missionSPMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionSPRecord[] missionSPCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public PLTMissionMPRecord[] missionMPExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionMPRecord[] missionMPMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public PLTMissionMPRecord[] missionMPCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTTournSPRecord[] missionSPTourn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTTournMPRecord[] missionMPTourn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTBattleSPRecord[] missionSPBattle;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTBattleMPRecord[] missionMPBattle;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PL2CampaignStatusSPRecord[] statusSPCampaign;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PL2CampaignStatusSPRecord[] statusMPCampaignUNK;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public PL2CampaignRecord[] missionSPCampaign;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public PL2CampaignRecord[] missionMPCampaign;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PL2CampaignProgressState
        {
            public int unknown1;
            public int CurrentMissionNumber;
            public int TotalMissionCount;
            public int CurrentMissionComplete;
            public int PlayerCount;
            public int TotalScore;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTBattleState
        {
            public int ConfigRandomSeed;
            public int IsInProgressUNK;
            public int ConfigBattleLength;
            public int ConfigGameRandomizeLevel;
            public PLTBattleProgressState saveState;
            public int unknown2;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PL2CampaignState
        {
            public int ConfigRandomSeed;
            public int IsInProgressUNK;
            public int ConfigGameRandomizeLevel;
            public PL2CampaignProgressState saveState;
            public int unknown2;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PL2FileRecord
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string PilotName;   // char[14]

            public int TotalScore;
            public uint PlayerID;      // DWORD -> DPID
            public int continuedOrReflownMission;
            public int isHosting;
            public int numHumanPlayersInMission;
            public int frontFlyMode;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
            public int[] unknown0x26;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] unknown0x166;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
            public int[] unknown0x186;

            public int activeMissionTeam;
            public int MissionFolderIndex;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] SelectedIDNumOfMissionCategory;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string GameName;      // char[32]

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string LastGameName;

            public int isMissionCategorySeries;
            public int activeMissionIDNum;
            public int PromoPoints;
            public int WorsePromoPoints;
            public int RankAdjustmentApplied;
            public int PercentToNextRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalScoreEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] numFlownNonSeriesEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] numFlownSeriesEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalKillCountEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] totalFriendlyKillCountEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 900)]
            public int[] TotalKillCountByCraftType;

            public PLTPlayerRankCountRecord TotalFullKillsOnPlayerRank;
            public PLTPlayerRankCountRecord TotalSharedKillsOnPlayerRank;
            public PLTPlayerRankCountRecord TotalAssistKillsOnPlayerRank;
            public PLTAIRankCountRecord TotalFullKillsOnAIRank;
            public PLTAIRankCountRecord TotalSharedKillsOnAIRank;
            public PLTAIRankCountRecord TotalAssistKillsOnAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalHiddenCargoFoundEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalLaserHitEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalLaserFiredEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalWarheadHitEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalWarheadFiredEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalCraftLossesEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalLossesFromCollisionEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalLossesFromStarshipsEMC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] TotalLossesFromMinesEMC;

            public PLTPlayerRankCountRecord TotalLossesFromPlayerRank;
            public PLTAIRankCountRecord TotalLossesFromAIRank;
            public PLTTournamentProgressState activeTournament;
            public PLTBattleProgressState activeBattle;
            public uint CurrentRank;
            public int TotalCountMissionsFlown;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] RankAchievedOnMissionCount;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string RankString;        // char[32]

            public int debriefMissionScore;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefFullKillsOnPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefSharedKillsOnPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefFullKillsOnFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefSharedKillsOnFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefFullKillsByPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] debriefSharedKillsByPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefFullKillsByFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefSharedKillsByFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public int[] debriefMeleeAIRankFG;

            public PL2DebriefRecord debrief;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public PLTConnectedPlayerData[] connectedPlayerData;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public PLTTeamResultRecord[] debriefTeamResult;

            public uint SelectedFaction;   // DWORD -> DPID

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public PL2FactionRecord[] faction;

            public PL2CampaignProgressState activeCampaign;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public sbyte[] gap45E1E;     // __int8

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTBattleState[] spBattleState;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PLTBattleState[] mpBattleState;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public PL2CampaignState[] spCampaignState;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public PL2CampaignState[] mpCampaignHostState;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public PL2CampaignState[] mpCampaignClientState;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] anonymous_259;

            public ushort anonymous_260;     // WORD
            public ushort anonymous_261;     // WORD
        };
    }
}