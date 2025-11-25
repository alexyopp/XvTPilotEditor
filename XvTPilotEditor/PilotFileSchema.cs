using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XvTPilotEditor
{
    class PilotFileSchema
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTCategoryTypeRecord
        {
            int exercise;
            int melee;
            int combat;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTPlayerRankCountRecord
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            int[] exercise;
            
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            int[] melee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            int[] combat;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTAIRankCountRecord
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            int[] exercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            int[] melee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            int[] combat;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTTournTeamRecord
        {
            int teamParticipationState;
            int totalTeamScore;
            int numberOfMeleeRankingsFirst;
            int numberOfMeleeRankingsSecond;
            int numberOfMeleeRankingsThird;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTConnectedPlayerData
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            string pilotLongNameUnused;     // char[14]

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            string pilotShortName;      // char[14]

            int fgIndex;
            uint DPPlayerID;    // DWORD -> DPID
            int pilotRank;
            int playerScore;
            int fullKills;
            int sharedKills;
            int unusedInspections;
            int assistKills;
            int losses;
            int craftType;
            int optionalCraftIndex;
            int optionalWarhead;
            int optionalBeam;
            int optionalCountermeasure;
            int hasDisconnectedFromHostUNK;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTTeamResultRecord
        {
            int totalMissionScore;
            int isMissionComplete;
            int unknown0x8;
            int timeMissionComplete;
            int fullKills;
            int sharedKills;
            int losses;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTEarnedMedalRecord
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            int[] meleePlaqueCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            int[] tournamentPlaqueCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            int[] exerciseBadgeCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            int[] battleMedalCount;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTMissionSPRecord
        {
            int unknown0x0;
            int totalCountFlown;
            int totalCountVictory;
            int totalCountFailure;
            int bestScore;
            int bestTimeAsSeconds;
            int bestFinishRank;
            int bestEvaluationBadge;
            int bestWinningMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTMissionMPRecord
        {
            int unknown0x0;
            int totalCountFlown;
            int totalCountFinishedFirst;
            int totalCountFinishedSecond;
            int totalCountFinishedThird;
            int totalCountVictory;
            int totalCountFailure;
            int bestScore;
            int bestTimeAsSeconds;
            int bestFinishPlace;
            int bestEvaluationBadge;
            int bestWinningMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTTournSPRecord
        {
            int unknown0x0;
            int totalCountFlown;
            int numberOfFinishesAnyUNK;
            int numberOfFinishesFirst;
            int numberOfFinishesSecond;
            int numberOfFinishesThird;
            int bestScore;
            int bestFinish;
            int bestEvaluationMedal;
            int bestFinishPointMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTTournMPRecord
        {
            int unknown0x0;
            int totalCountFlown;
            int numberOfFinishesAnyUNK;
            int numberOfFinishesFirst;
            int numberOfFinishesSecond;
            int numberOfFinishesThird;
            int bestScore;
            int bestFinish;
            int unknown0x20;
            int bestEvaluationMedal;
            int bestFinishPointMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTBattleSPRecord
        {
            int unknown0x0;
            int totalCountFlown;
            int totalCountVictory;
            int totalCountFailure;
            int totalCount10MissionMarathonUNK;
            int bestScore;
            int unknown0x18;
            int bestEvaluationMedal;
            int bestVictoryMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTBattleMPRecord
        {
            int unknown0x0;
            int totalCountFlown;
            int totalCountVictory;
            int totalCountFailure;
            int totalCount10MissionMarathonUNK;
            int bestScore;
            int unknown0x18;
            int unknown0x1C;
            int bestEvaluationMedal;
            int bestVictoryMargin;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        struct PLTFactionRecord
        {
            int totalMissionsFlown;
            int lastMissionTeam;
            int lastMissionType;
            int lastMissionTrainingSelected;
            int lastMissionMeleeSelected;
            int lastMissionTournamentSelected;
            int lastMissionCombatSelected;
            int lastMissionBattleSelected;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            int[] unknown0x20;

            PLTEarnedMedalRecord earnedMedalCount;
            int debriefMeleePlaqueType;
            int debriefTournamentTrophyType;
            int debriefMissionBadgeType;
            int debriefBattleMedalType;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            int[] UnknownRecord4;

            int totalFactionScore;
            PLTCategoryTypeRecord totalCategoryScore;
            PLTCategoryTypeRecord totalCategoryFlown;
            int totalCampaignExerciseFlown;
            int totalTournamentMeleeFlown;
            int totalBattleCombatFlown;
            PLTCategoryTypeRecord totalFullKills;
            PLTCategoryTypeRecord totalFriendlyFullKills;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalFullKillsByShipExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalFullKillsByShipMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalFullKillsByShipCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalSharedKillsOfShipExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalSharedKillsOfShipMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalSharedKillsOfShipCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalAssistKillsOfShipExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalAssistKillsOfShipMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalAssistKillsOfShipCombat;

            PLTPlayerRankCountRecord totalFullKillsOfPlayerRank;
            PLTPlayerRankCountRecord totalSharedKillsOfPlayerRank;
            PLTPlayerRankCountRecord totalAssistKillsOfPlayerRank;
            PLTAIRankCountRecord totalFullKillsOfAIRank;
            PLTAIRankCountRecord totalSharedKillsOfAIRank;
            PLTAIRankCountRecord totalAssistKillsOfAIRank;
            PLTCategoryTypeRecord totalHiddenCargoFound;
            PLTCategoryTypeRecord totalCannonHit;
            PLTCategoryTypeRecord totalCannonFired;
            PLTCategoryTypeRecord totalWarheadHit;
            PLTCategoryTypeRecord totalWarheadFired;
            PLTCategoryTypeRecord totalLosses;
            PLTCategoryTypeRecord totalLossesByCollision;
            PLTCategoryTypeRecord totalLossesByStarship;
            PLTCategoryTypeRecord totalLossesByMines;
            PLTPlayerRankCountRecord totalLossesByPlayerRank;
            PLTAIRankCountRecord totalLossesByAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            PLTMissionSPRecord[] missionSPExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            PLTMissionSPRecord[] missionSPMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            PLTMissionSPRecord[] missionSPCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            PLTMissionMPRecord[] missionMPExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            PLTMissionMPRecord[] missionMPMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            PLTMissionMPRecord[] missionMPCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            PLTTournSPRecord[] missionSPTourn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            PLTTournMPRecord[] missionMPTourn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            PLTBattleSPRecord[] missionSPBattle;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            PLTBattleMPRecord[] missionMPBattle;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)] // Pack=1 ensures no padding
        public struct PLTFileRecord
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            string PilotName;   // char[14]

            int TotalScore;
            uint PlayerID;      // DWORD -> DPID
            int continuedOrReflownMission;
            int isHosting;
            int numHumanPlayersInMission;
            int frontFlyMode;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
            int[] unknown0x26;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            int[] unknown0x166;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
            int[] unknown0x186;

            int lastTeamNumber;
            int lastSelectedMissionType;
            int lastSelectedTraining;
            int lastSelectedMelee;
            int lastSelectedTournament;
            int lastSelectedCombat;
            int lastSelectedBattle;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
            string GameNameString;  // char[22]

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            byte[] unknown0x2F8;    // BYTE

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
            string GameNameString2;     // char[22]

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            byte[] unknown0x318;    // BYTE

            int lastMissionWasNonSpecific;
            int unknown0x326;
            int PromoPoints;
            int WorsePromoPoints;
            int RankAdjustmentApplied;
            int PercentToNextRank;
            PLTCategoryTypeRecord totalCategoryScore;
            PLTCategoryTypeRecord numFlownNonSeries;
            PLTCategoryTypeRecord numFlownSeries;
            PLTCategoryTypeRecord totalKillCount;
            PLTCategoryTypeRecord numVanillaFriendlyKills;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftFullKillsExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftFullKillsMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftFullKillsCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftSharedKillsExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftSharedKillsMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftSharedKillsCombat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftAssistKillsExercise;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftAssistKillsMelee;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] totalCraftAssistKillsCombat;

            PLTPlayerRankCountRecord TotalFullKillsOnPlayerRank;
            PLTPlayerRankCountRecord TotalSharedKillsOnPlayerRank;
            PLTPlayerRankCountRecord TotalAssistKillsOnPlayerRank;
            PLTAIRankCountRecord TotalFullKillsOnAIRank;
            PLTAIRankCountRecord TotalSharedKillsOnAIRank;
            PLTAIRankCountRecord TotalAssistKillsOnAIRank;
            PLTCategoryTypeRecord totalHiddenCargoFound;
            PLTCategoryTypeRecord totalLaserHit;
            int totalLaserFiredExercise;
            int totalLaserFiredMelee;
            int totalLaserFiredCombat;
            int totalWarheadHitExercise;
            int totalWarheadHitMelee;
            int totalWarheadHitCombat;
            int totalWarheadFiredExercise;
            int totalWarheadFiredMelee;
            int totalWarheadFiredCombat;
            int totalCraftLossesExercise;
            int totalCraftLossesMelee;
            int totalCraftLossesCombat;
            int totalLossesFromCollisionExercise;
            int totalLossesFromCollisionMelee;
            int totalLossesFromCollisionCombat;
            int totalLossesFromStarshipsExercise;
            int totalLossesFromStarshipsMelee;
            int totalLossesFromStarshipsCombat;
            int totalLossesFromMinesExercise;
            int totalLossesFromMinesMelee;
            int totalLossesFromMinesCombat;
            PLTPlayerRankCountRecord TotalLossesFromPlayerRank;
            PLTAIRankCountRecord TotalLossesFromAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            byte[] unknown0x1612;       // BYTE

            int unknownPlaqueWon;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            PLTTournTeamRecord[] TournTeamRecords;

            int numHumanPlayersUNK;
            int numTeamsUNK;
            int unknown0x170E;
            int unknown0x1712;
            int numCombatFlownInLastBattle;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2052)]
            byte[] unknown0x171A;       // BYTE

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            int[] battleCombatMissionID;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1012)]
            byte[] unknown0x1F2E;       // BYTE

            int totalScoreForCurrentBattleUNK;
            uint CurrentRank;
            int TotalCountMissionsFlown;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            int[] RankAchievedOnMissionCount;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            string RankString;      // char[32]

            int debriefMissionScore;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            int[] debriefFullKillsOnPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            int[] debriefSharedKillsOnPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            int[] debriefFullKillsOnFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            int[] debriefSharedKillsOnFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            int[] debriefFullKillsByPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            int[] debriefSharedKillsByPlayer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            int[] debriefFullKillsByFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            int[] debriefSharedKillsByFG;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            int[] debriefMeleeAIRankFG;

            PLTCategoryTypeRecord UnknownRecord1;
            PLTCategoryTypeRecord UnknownRecord2;
            PLTCategoryTypeRecord UnknownRecord3;
            PLTCategoryTypeRecord debriefEnemyKills;
            PLTCategoryTypeRecord debriefFriendlyKills;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefFullKillsByShipTypeA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefFullKillsByShipTypeB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefFullKillsByShipTypeC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefSharedKillsByShipTypeA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefSharedKillsByShipTypeB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefSharedKillsByShipTypeC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefAssistKillsByShipTypeA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefAssistKillsByShipTypeB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            int[] debriefAssistKillsByShipTypeC;

            PLTPlayerRankCountRecord debriefFullKillsOnPlayerRank;
            PLTPlayerRankCountRecord debriefSharedKillsOnPlayerRank;
            PLTPlayerRankCountRecord debriefAssistKillsOnPlayerRank;
            PLTAIRankCountRecord debriefFullKillsOnAIRank;
            PLTAIRankCountRecord debriefSharedKillsOnAIRank;
            PLTAIRankCountRecord debriefAssistKillsOnAIRank;
            PLTCategoryTypeRecord debriefNumHiddenCargoFound;
            PLTCategoryTypeRecord debriefNumCannonHits;
            PLTCategoryTypeRecord debriefNumCannonFired;
            PLTCategoryTypeRecord debriefNumWarheadHits;
            PLTCategoryTypeRecord debriefNumWarheadFired;
            PLTCategoryTypeRecord debriefNumCraftLosses;
            PLTCategoryTypeRecord debriefCraftLossesFromCollision;
            PLTCategoryTypeRecord debriefCraftLossesFromStarship;
            PLTCategoryTypeRecord debriefCraftLossesFromMine;
            PLTPlayerRankCountRecord debriefLossesFromPlayerRank;
            PLTAIRankCountRecord debriefLossesFromAIRank;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            PLTConnectedPlayerData[] connectedPlayerData;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            PLTTeamResultRecord[] debriefTeamResult;

            int lastSelectedFaction;
            PLTFactionRecord rebelSingleplayerData;
            PLTFactionRecord imperialSingleplayerData;
            PLTFactionRecord rebelMultiplayerData;
            PLTFactionRecord imperialMultiplayerData;
        };
    }
}
