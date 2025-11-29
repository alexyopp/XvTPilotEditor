using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static XvTPilotEditor.PilotFileSchema;

namespace XvTPilotEditor
{
    public class PilotRecord
    {
        // Size 14
        public string PltPilotName { get; set; }
        public string Pl2PilotName { get; set; }

        public int PltTotalScore { get; set; }
        public int Pl2TotalScore { get; set; }

        public uint PltPlayerID { get; set; }
        public uint Pl2PlayerID { get; set; }

        public int PltContinuedOrReflownMission { get; set; }
        public int Pl2ContinuedOrReflownMission { get; set; }

        public int PltIsHosting { get; set; }
        public int Pl2IsHosting { get; set; }

        public int PltNumHumanPlayersInMission { get; set; }
        public int Pl2NumHumanPlayersInMission { get; set; }

        public int PltFrontFlyMode { get; set; }
        public int Pl2FrontFlyMode { get; set; }

        // Size 10
        public int[] PltUnknown0x26 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x26 { get; private set; } = Array.Empty<int>();

        // Size 10
        public int[] PltUnknown0x166 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x166 { get; private set; } = Array.Empty<int>();

        // Size 10
        public int[] PltUnknown0x186 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x186 { get; private set; } = Array.Empty<int>();

        //...

        public int PltPromoPoints { get; set; }
        public int Pl2PromoPoints { get; set; }

        public int PltWorsePromoPoints { get; set; }
        public int Pl2WorsePromoPoints { get; set; }

        public int PltRankAdjustmentApplied { get; set; }
        public int Pl2RankAdjustmentApplied { get; set; }

        public int PltPercentToNextRank { get; set; }
        public int Pl2PercentToNextRank { get; set; }

        public MissionCategoryRecord PltTotalCategoryScore { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalCategoryScore { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltNumFlownNonSeries { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2NumFlownNonSeries { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltNumFlownSeries { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2NumFlownSeries { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalKills { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalKills { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltFriendlyKills { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2FriendlyKills { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecordByPlayerRating PltTotalFullKillsOnPlayerRating { get; private set; }
        public MissionCategoryRecordByPlayerRating Pl2TotalFullKillsOnPlayerRating { get; private set; }

        public MissionCategoryRecordByPlayerRating PltTotalSharedKillsOnPlayerRating { get; private set; }
        public MissionCategoryRecordByPlayerRating Pl2TotalSharedKillsOnPlayerRating { get; private set; }

        public MissionCategoryRecordByPlayerRating PltTotalAssistsOnPlayerRating { get; private set; }
        public MissionCategoryRecordByPlayerRating Pl2TotalAssistsOnPlayerRating { get; private set; }

        public MissionCategoryRecordByAIRating PltTotalFullKillsOnAIRank { get; private set; }
        public MissionCategoryRecordByAIRating Pl2TotalFullKillsOnAIRank { get; private set; }

        public MissionCategoryRecordByAIRating PltTotalSharedKillsOnAIRank { get; private set; }
        public MissionCategoryRecordByAIRating Pl2TotalSharedKillsOnAIRank { get; private set; }

        public MissionCategoryRecordByAIRating PltTotalAssistsOnAIRank { get; private set; }
        public MissionCategoryRecordByAIRating Pl2TotalAssistsOnAIRank { get; private set; }

        public MissionCategoryRecord PltTotalHiddenCargoFound { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalHiddenCargoFound { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLaserHit { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLaserHit { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLaserFired { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLaserFired { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalWarheadHit { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalWarheadHit { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalWarheadFired { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalWarheadFired { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalCraftLosses { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalCraftLosses { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLossesFromCollisions { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLossesFromCollisions { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLossesFromStarships { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLossesFromStarships { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLossesFromMines { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLossesFromMines { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecordByPlayerRating PltTotalLossesFromPlayerRank { get; private set; }
        public MissionCategoryRecordByPlayerRating Pl2TotalLossesFromPlayerRank { get; private set; }

        public MissionCategoryRecordByAIRating PltTotalLossesFromAIRank { get; private set; }
        public MissionCategoryRecordByAIRating Pl2TotalLossesFromAIRank { get; private set; }

        //...

        public uint PltCurrentRank { get; set; }
        public uint Pl2CurrentRank { get; set; }

        public int PltTotalCountMissionsFlown { get; set; }
        public int Pl2TotalCountMissionsFlown { get; set; }

        public int[] PltRankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();
        public int[] Pl2RankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();

        public string PltRankString { get; set; } = string.Empty;
        public string Pl2RankString { get; set; } = string.Empty;

        public int PltDebriefMissionScore { get; set; }
        public int Pl2DebriefMissionScore { get; set; }

        public int[] PltDebriefFullKillsOnPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsOnPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsOnPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsOnPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefFullKillsOnFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsOnFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsOnFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsOnFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefFullKillsByPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsByPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsByPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsByPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefFullKillsByFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsByFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsByFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsByFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefMeleeAIRankFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefMeleeAIRankFG { get; private set; } = Array.Empty<int>();

        //...

        public ConnectedPlayerRecord[] PltConnectedPlayer { get; private set; }
        public ConnectedPlayerRecord[] Pl2ConnectedPlayer { get; private set; }

        public TeamResultRecord[] PltDebriefTeamResult { get; private set; }
        public TeamResultRecord[] Pl2DebriefTeamResult { get; private set; }

        //  Note the difference in types between the Plt and Pl2 versions; probably can homogenize these in the future
        public int PltLastSelectedFaction { get; set; }
        public uint Pl2LastSelectedFaction { get; set; }

        // --- PLT fields (flattened) ---
        public int PltlastTeamNumber { get; set; }
        public int PltlastSelectedMissionType { get; set; }
        public int PltlastSelectedTraining { get; set; }
        public int PltlastSelectedMelee { get; set; }
        public int PltlastSelectedTournament { get; set; }
        public int PltlastSelectedCombat { get; set; }
        public int PltlastSelectedBattle { get; set; }
        public string PltGameNameString { get; set; } = string.Empty;
        public byte[] Pltunknown0x2F8 { get; private set; } = Array.Empty<byte>();
        public string PltGameNameString2 { get; set; } = string.Empty;
        public byte[] Pltunknown0x318 { get; private set; } = Array.Empty<byte>();
        public int PltlastMissionWasNonSpecific { get; set; }
        public int Pltunknown0x326 { get; set; }
        public int[] PlttotalCraftFullKillsExercise { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftFullKillsMelee { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftFullKillsCombat { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftSharedKillsExercise { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftSharedKillsMelee { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftSharedKillsCombat { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftAssistKillsExercise { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftAssistKillsMelee { get; private set; } = Array.Empty<int>();
        public int[] PlttotalCraftAssistKillsCombat { get; private set; } = Array.Empty<int>();
        public byte[] Pltunknown0x1612 { get; private set; } = Array.Empty<byte>();
        public int PltunknownPlaqueWon { get; set; }
        public PilotFileSchema.PLTTournTeamRecord[] PltTournTeamRecords { get; private set; } = Array.Empty<PilotFileSchema.PLTTournTeamRecord>();
        public int PltnumHumanPlayersUNK { get; set; }
        public int PltnumTeamsUNK { get; set; }
        public int Pltunknown0x170E { get; set; }
        public int Pltunknown0x1712 { get; set; }
        public int PltnumCombatFlownInLastBattle { get; set; }
        public byte[] Pltunknown0x171A { get; private set; } = Array.Empty<byte>();
        public int[] PltbattleCombatMissionID { get; private set; } = Array.Empty<int>();
        public byte[] Pltunknown0x1F2E { get; private set; } = Array.Empty<byte>();
        public int PlttotalScoreForCurrentBattleUNK { get; set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltUnknownRecord1 { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltUnknownRecord2 { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltUnknownRecord3 { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefEnemyKills { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefFriendlyKills { get; private set; }
        public int[] PltdebriefFullKillsByShipTypeA { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefFullKillsByShipTypeB { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefFullKillsByShipTypeC { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefSharedKillsByShipTypeA { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefSharedKillsByShipTypeB { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefSharedKillsByShipTypeC { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefAssistKillsByShipTypeA { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefAssistKillsByShipTypeB { get; private set; } = Array.Empty<int>();
        public int[] PltdebriefAssistKillsByShipTypeC { get; private set; } = Array.Empty<int>();
        public PilotFileSchema.PLTPlayerRankCountRecord PltdebriefFullKillsOnPlayerRank { get; private set; }
        public PilotFileSchema.PLTPlayerRankCountRecord PltdebriefSharedKillsOnPlayerRank { get; private set; }
        public PilotFileSchema.PLTPlayerRankCountRecord PltdebriefAssistKillsOnPlayerRank { get; private set; }
        public PilotFileSchema.PLTAIRankCountRecord PltdebriefFullKillsOnAIRank { get; private set; }
        public PilotFileSchema.PLTAIRankCountRecord PltdebriefSharedKillsOnAIRank { get; private set; }
        public PilotFileSchema.PLTAIRankCountRecord PltdebriefAssistKillsOnAIRank { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefNumHiddenCargoFound { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefNumCannonHits { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefNumCannonFired { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefNumWarheadHits { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefNumWarheadFired { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefNumCraftLosses { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefCraftLossesFromCollision { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefCraftLossesFromStarship { get; private set; }
        public PilotFileSchema.PLTCategoryTypeRecord PltdebriefCraftLossesFromMine { get; private set; }
        public PilotFileSchema.PLTPlayerRankCountRecord PltdebriefLossesFromPlayerRank { get; private set; }
        public PilotFileSchema.PLTAIRankCountRecord PltdebriefLossesFromAIRank { get; private set; }

        public PilotFileSchema.PLTFactionRecord PltrebelSingleplayerData { get; private set; }
        public PilotFileSchema.PLTFactionRecord PltimperialSingleplayerData { get; private set; }
        public PilotFileSchema.PLTFactionRecord PltrebelMultiplayerData { get; private set; }
        public PilotFileSchema.PLTFactionRecord PltimperialMultiplayerData { get; private set; }

        // --- PL2 fields (flattened) ---
        public int Pl2activeMissionTeam { get; set; }
        public int Pl2MissionFolderIndex { get; set; }
        public int[] Pl2SelectedIDNumOfMissionCategory { get; private set; } = Array.Empty<int>();
        public string Pl2GameName { get; set; } = string.Empty;
        public string Pl2LastGameName { get; set; } = string.Empty;
        public int Pl2isMissionCategorySeries { get; set; }
        public int Pl2activeMissionIDNum { get; set; }
        public int[] Pl2TotalKillCountByCraftType { get; private set; } = Array.Empty<int>();
        public PilotFileSchema.PLTTournamentProgressState Pl2activeTournament { get; private set; }
        public PilotFileSchema.PLTBattleProgressState Pl2activeBattle { get; private set; }
        public PilotFileSchema.PL2DebriefRecord Pl2debrief { get; private set; }

        public PilotFileSchema.PL2FactionRecord[] Pl2faction { get; private set; } = Array.Empty<PilotFileSchema.PL2FactionRecord>();
        public PilotFileSchema.PL2CampaignProgressState Pl2activeCampaign { get; private set; }
        public sbyte[] Pl2gap45E1E { get; private set; } = Array.Empty<sbyte>();
        public PilotFileSchema.PLTBattleState[] Pl2spBattleState { get; private set; } = Array.Empty<PilotFileSchema.PLTBattleState>();
        public PilotFileSchema.PLTBattleState[] Pl2mpBattleState { get; private set; } = Array.Empty<PilotFileSchema.PLTBattleState>();
        public PilotFileSchema.PL2CampaignState[] Pl2spCampaignState { get; private set; } = Array.Empty<PilotFileSchema.PL2CampaignState>();
        public PilotFileSchema.PL2CampaignState[] Pl2mpCampaignHostState { get; private set; } = Array.Empty<PilotFileSchema.PL2CampaignState>();
        public PilotFileSchema.PL2CampaignState[] Pl2mpCampaignClientState { get; private set; } = Array.Empty<PilotFileSchema.PL2CampaignState>();
        public int[] Pl2anonymous_259 { get; private set; } = Array.Empty<int>();
        public ushort Pl2anonymous_260 { get; set; }
        public ushort Pl2anonymous_261 { get; set; }

        private PilotFileSchema.PLTFileRecord _pltData;
        public PilotFileSchema.PLTFileRecord PltData { get => _pltData; }

        private PilotFileSchema.PL2FileRecord _pl2Data;
        public PilotFileSchema.PL2FileRecord Pl2Data { get => _pl2Data; }

        public PilotRecord()
        {
        }

        public PilotRecord(PilotFileSchema.PLTFileRecord pltFile)
        {
            FillFromPlt(pltFile);
        }

        public PilotRecord(PilotFileSchema.PL2FileRecord pl2File)
        {
            FillFromPl2(pl2File);
        }

        public PilotRecord(PilotFileSchema.PLTFileRecord pltFile, PilotFileSchema.PL2FileRecord pl2File)
        {
            FillFromPlt(pltFile);
            FillFromPl2(pl2File);
        }

        public void FillFromPlt(PilotFileSchema.PLTFileRecord pltFile)
        {
            _pltData = pltFile;

            PltPilotName                        = pltFile.PilotName ?? string.Empty;
            PltTotalScore                       = pltFile.TotalScore;
            PltPlayerID                         = pltFile.PlayerID;
            PltContinuedOrReflownMission        = pltFile.continuedOrReflownMission;
            PltIsHosting                        = pltFile.isHosting;
            PltNumHumanPlayersInMission         = pltFile.numHumanPlayersInMission;
            PltFrontFlyMode                     = pltFile.frontFlyMode;
            PltUnknown0x26                      = pltFile.unknown0x26 ?? Array.Empty<int>();
            PltUnknown0x166                     = pltFile.unknown0x166 ?? Array.Empty<int>();
            PltUnknown0x186                     = pltFile.unknown0x186 ?? Array.Empty<int>();
            PltlastTeamNumber                   = pltFile.lastTeamNumber;
            PltlastSelectedMissionType          = pltFile.lastSelectedMissionType;
            PltlastSelectedTraining             = pltFile.lastSelectedTraining;
            PltlastSelectedMelee                = pltFile.lastSelectedMelee;
            PltlastSelectedTournament           = pltFile.lastSelectedTournament;
            PltlastSelectedCombat               = pltFile.lastSelectedCombat;
            PltlastSelectedBattle               = pltFile.lastSelectedBattle;
            PltGameNameString                   = pltFile.GameNameString ?? string.Empty;
            Pltunknown0x2F8                     = pltFile.unknown0x2F8 ?? Array.Empty<byte>();
            PltGameNameString2                  = pltFile.GameNameString2 ?? string.Empty;
            Pltunknown0x318                     = pltFile.unknown0x318 ?? Array.Empty<byte>();
            PltlastMissionWasNonSpecific        = pltFile.lastMissionWasNonSpecific;
            Pltunknown0x326                     = pltFile.unknown0x326;
            PltPromoPoints                      = pltFile.PromoPoints;
            PltWorsePromoPoints                 = pltFile.WorsePromoPoints;
            PltRankAdjustmentApplied            = pltFile.RankAdjustmentApplied;
            PltPercentToNextRank                = pltFile.PercentToNextRank;
            PltTotalCategoryScore               = new MissionCategoryRecord(pltFile.totalCategoryScore);
            PltNumFlownNonSeries                = new MissionCategoryRecord(pltFile.numFlownNonSeries);
            PltNumFlownSeries                   = new MissionCategoryRecord(pltFile.numFlownSeries);
            PltTotalKills                       = new MissionCategoryRecord(pltFile.totalKillCount);
            PltFriendlyKills                    = new MissionCategoryRecord(pltFile.numVanillaFriendlyKills);
            PlttotalCraftFullKillsExercise      = pltFile.totalCraftFullKillsExercise ?? Array.Empty<int>();
            PlttotalCraftFullKillsMelee         = pltFile.totalCraftFullKillsMelee ?? Array.Empty<int>();
            PlttotalCraftFullKillsCombat        = pltFile.totalCraftFullKillsCombat ?? Array.Empty<int>();
            PlttotalCraftSharedKillsExercise    = pltFile.totalCraftSharedKillsExercise ?? Array.Empty<int>();
            PlttotalCraftSharedKillsMelee       = pltFile.totalCraftSharedKillsMelee ?? Array.Empty<int>();
            PlttotalCraftSharedKillsCombat      = pltFile.totalCraftSharedKillsCombat ?? Array.Empty<int>();
            PlttotalCraftAssistKillsExercise    = pltFile.totalCraftAssistKillsExercise ?? Array.Empty<int>();
            PlttotalCraftAssistKillsMelee       = pltFile.totalCraftAssistKillsMelee ?? Array.Empty<int>();
            PlttotalCraftAssistKillsCombat      = pltFile.totalCraftAssistKillsCombat ?? Array.Empty<int>();
            PltTotalFullKillsOnPlayerRating     = new MissionCategoryRecordByPlayerRating(pltFile.TotalFullKillsOnPlayerRank);
            PltTotalSharedKillsOnPlayerRating   = new MissionCategoryRecordByPlayerRating(pltFile.TotalSharedKillsOnPlayerRank);
            PltTotalAssistsOnPlayerRating       = new MissionCategoryRecordByPlayerRating(pltFile.TotalAssistKillsOnPlayerRank);
            PltTotalFullKillsOnAIRank           = new MissionCategoryRecordByAIRating(pltFile.TotalFullKillsOnAIRank);
            PltTotalSharedKillsOnAIRank         = new MissionCategoryRecordByAIRating(pltFile.TotalSharedKillsOnAIRank);
            PltTotalAssistsOnAIRank             = new MissionCategoryRecordByAIRating(pltFile.TotalAssistKillsOnAIRank);
            PltTotalHiddenCargoFound            = new MissionCategoryRecord(pltFile.totalHiddenCargoFound);
            PltTotalLaserHit                    = new MissionCategoryRecord(pltFile.totalLaserHit);
            PltTotalLaserFired                  = new MissionCategoryRecord(pltFile.totalLaserFiredExercise, pltFile.totalLaserFiredMelee, pltFile.totalLaserFiredCombat);
            PltTotalWarheadHit                  = new MissionCategoryRecord(pltFile.totalWarheadHitExercise, pltFile.totalWarheadHitMelee, pltFile.totalWarheadHitCombat);
            PltTotalWarheadFired                = new MissionCategoryRecord(pltFile.totalWarheadFiredExercise, pltFile.totalWarheadFiredMelee, pltFile.totalWarheadFiredCombat);
            PltTotalCraftLosses                 = new MissionCategoryRecord(pltFile.totalCraftLossesExercise, pltFile.totalCraftLossesMelee, pltFile.totalCraftLossesCombat);
            PltTotalLossesFromCollisions        = new MissionCategoryRecord(pltFile.totalLossesFromCollisionExercise, pltFile.totalLossesFromCollisionMelee, pltFile.totalLossesFromCollisionCombat);
            PltTotalLossesFromStarships         = new MissionCategoryRecord(pltFile.totalLossesFromStarshipsExercise, pltFile.totalLossesFromStarshipsMelee, pltFile.totalLossesFromStarshipsCombat);
            PltTotalLossesFromMines             = new MissionCategoryRecord(pltFile.totalLossesFromMinesExercise, pltFile.totalLossesFromMinesMelee, pltFile.totalLossesFromMinesCombat);
            PltTotalLossesFromPlayerRank        = new MissionCategoryRecordByPlayerRating(pltFile.TotalLossesFromPlayerRank);
            PltTotalLossesFromAIRank            = new MissionCategoryRecordByAIRating(pltFile.TotalLossesFromAIRank);
            Pltunknown0x1612                    = pltFile.unknown0x1612 ?? Array.Empty<byte>();
            PltunknownPlaqueWon                 = pltFile.unknownPlaqueWon;
            PltTournTeamRecords                 = pltFile.TournTeamRecords ?? Array.Empty<PilotFileSchema.PLTTournTeamRecord>();
            PltnumHumanPlayersUNK               = pltFile.numHumanPlayersUNK;
            PltnumTeamsUNK                      = pltFile.numTeamsUNK;
            Pltunknown0x170E                    = pltFile.unknown0x170E;
            Pltunknown0x1712                    = pltFile.unknown0x1712;
            PltnumCombatFlownInLastBattle       = pltFile.numCombatFlownInLastBattle;
            Pltunknown0x171A                    = pltFile.unknown0x171A ?? Array.Empty<byte>();
            PltbattleCombatMissionID            = pltFile.battleCombatMissionID ?? Array.Empty<int>();
            Pltunknown0x1F2E                    = pltFile.unknown0x1F2E ?? Array.Empty<byte>();
            PlttotalScoreForCurrentBattleUNK    = pltFile.totalScoreForCurrentBattleUNK;
            PltCurrentRank                      = pltFile.CurrentRank;
            PltTotalCountMissionsFlown          = pltFile.TotalCountMissionsFlown;
            PltRankAchievedOnMissionCount       = pltFile.RankAchievedOnMissionCount ?? Array.Empty<int>();
            PltRankString                       = pltFile.RankString ?? string.Empty;
            PltDebriefMissionScore              = pltFile.debriefMissionScore;
            PltDebriefFullKillsOnPlayer         = pltFile.debriefFullKillsOnPlayer ?? Array.Empty<int>();
            PltDebriefSharedKillsOnPlayer       = pltFile.debriefSharedKillsOnPlayer ?? Array.Empty<int>();
            PltDebriefFullKillsOnFG             = pltFile.debriefFullKillsOnFG ?? Array.Empty<int>();
            PltDebriefSharedKillsOnFG           = pltFile.debriefSharedKillsOnFG ?? Array.Empty<int>();
            PltDebriefFullKillsByPlayer         = pltFile.debriefFullKillsByPlayer ?? Array.Empty<int>();
            PltDebriefSharedKillsByPlayer       = pltFile.debriefSharedKillsByPlayer ?? Array.Empty<int>();
            PltDebriefFullKillsByFG             = pltFile.debriefFullKillsByFG ?? Array.Empty<int>();
            PltDebriefSharedKillsByFG           = pltFile.debriefSharedKillsByFG ?? Array.Empty<int>();
            PltDebriefMeleeAIRankFG             = pltFile.debriefMeleeAIRankFG ?? Array.Empty<int>();
            PltUnknownRecord1                   = pltFile.UnknownRecord1;
            PltUnknownRecord2                   = pltFile.UnknownRecord2;
            PltUnknownRecord3                   = pltFile.UnknownRecord3;
            PltdebriefEnemyKills                = pltFile.debriefEnemyKills;
            PltdebriefFriendlyKills             = pltFile.debriefFriendlyKills;
            PltdebriefFullKillsByShipTypeA      = pltFile.debriefFullKillsByShipTypeA ?? Array.Empty<int>();
            PltdebriefFullKillsByShipTypeB      = pltFile.debriefFullKillsByShipTypeB ?? Array.Empty<int>();
            PltdebriefFullKillsByShipTypeC      = pltFile.debriefFullKillsByShipTypeC ?? Array.Empty<int>();
            PltdebriefSharedKillsByShipTypeA    = pltFile.debriefSharedKillsByShipTypeA ?? Array.Empty<int>();
            PltdebriefSharedKillsByShipTypeB    = pltFile.debriefSharedKillsByShipTypeB ?? Array.Empty<int>();
            PltdebriefSharedKillsByShipTypeC    = pltFile.debriefSharedKillsByShipTypeC ?? Array.Empty<int>();
            PltdebriefAssistKillsByShipTypeA    = pltFile.debriefAssistKillsByShipTypeA ?? Array.Empty<int>();
            PltdebriefAssistKillsByShipTypeB    = pltFile.debriefAssistKillsByShipTypeB ?? Array.Empty<int>();
            PltdebriefAssistKillsByShipTypeC    = pltFile.debriefAssistKillsByShipTypeC ?? Array.Empty<int>();
            PltdebriefFullKillsOnPlayerRank     = pltFile.debriefFullKillsOnPlayerRank;
            PltdebriefSharedKillsOnPlayerRank   = pltFile.debriefSharedKillsOnPlayerRank;
            PltdebriefAssistKillsOnPlayerRank   = pltFile.debriefAssistKillsOnPlayerRank;
            PltdebriefFullKillsOnAIRank         = pltFile.debriefFullKillsOnAIRank;
            PltdebriefSharedKillsOnAIRank       = pltFile.debriefSharedKillsOnAIRank;
            PltdebriefAssistKillsOnAIRank       = pltFile.debriefAssistKillsOnAIRank;
            PltdebriefNumHiddenCargoFound       = pltFile.debriefNumHiddenCargoFound;
            PltdebriefNumCannonHits             = pltFile.debriefNumCannonHits;
            PltdebriefNumCannonFired            = pltFile.debriefNumCannonFired;
            PltdebriefNumWarheadHits            = pltFile.debriefNumWarheadHits;
            PltdebriefNumWarheadFired           = pltFile.debriefNumWarheadFired;
            PltdebriefNumCraftLosses            = pltFile.debriefNumCraftLosses;
            PltdebriefCraftLossesFromCollision  = pltFile.debriefCraftLossesFromCollision;
            PltdebriefCraftLossesFromStarship   = pltFile.debriefCraftLossesFromStarship;
            PltdebriefCraftLossesFromMine       = pltFile.debriefCraftLossesFromMine;
            PltdebriefLossesFromPlayerRank      = pltFile.debriefLossesFromPlayerRank;
            PltdebriefLossesFromAIRank          = pltFile.debriefLossesFromAIRank;

            PltConnectedPlayer = new ConnectedPlayerRecord[Constants.MAX_CONNECTED_PLAYERS];
            for (uint idx = 0; idx < Constants.MAX_CONNECTED_PLAYERS; ++idx)
            {
                PltConnectedPlayer[idx] = new ConnectedPlayerRecord(pltFile.connectedPlayerData[idx]);
            }

            PltDebriefTeamResult = new TeamResultRecord[10]; // TODO: Why 10?  I mean, that's what's defined in the file, but what is the in-game significance?
            for (uint idx = 0; idx < 10; ++idx)
            {
                PltDebriefTeamResult[idx] = new TeamResultRecord(pltFile.debriefTeamResult[idx]);
            }

            PltLastSelectedFaction              = pltFile.lastSelectedFaction;
            PltrebelSingleplayerData            = pltFile.rebelSingleplayerData;
            PltimperialSingleplayerData         = pltFile.imperialSingleplayerData;
            PltrebelMultiplayerData             = pltFile.rebelMultiplayerData;
            PltimperialMultiplayerData          = pltFile.imperialMultiplayerData;
        }

        public void FillFromPl2(PilotFileSchema.PL2FileRecord pl2File)
        {
            _pl2Data = pl2File;

            Pl2PilotName                        = pl2File.PilotName ?? string.Empty;
            Pl2TotalScore                       = pl2File.TotalScore;
            Pl2PlayerID                         = pl2File.PlayerID;
            Pl2ContinuedOrReflownMission        = pl2File.continuedOrReflownMission;
            Pl2IsHosting                        = pl2File.isHosting;
            Pl2NumHumanPlayersInMission         = pl2File.numHumanPlayersInMission;
            Pl2FrontFlyMode                     = pl2File.frontFlyMode;
            Pl2Unknown0x26                      = pl2File.unknown0x26 ?? Array.Empty<int>();
            Pl2Unknown0x166                     = pl2File.unknown0x166 ?? Array.Empty<int>();
            Pl2Unknown0x186                     = pl2File.unknown0x186 ?? Array.Empty<int>();
            Pl2activeMissionTeam                = pl2File.activeMissionTeam;
            Pl2MissionFolderIndex               = pl2File.MissionFolderIndex;
            Pl2SelectedIDNumOfMissionCategory   = pl2File.SelectedIDNumOfMissionCategory ?? Array.Empty<int>();
            Pl2GameName                         = pl2File.GameName ?? string.Empty;
            Pl2LastGameName                     = pl2File.LastGameName ?? string.Empty;
            Pl2isMissionCategorySeries          = pl2File.isMissionCategorySeries;
            Pl2activeMissionIDNum               = pl2File.activeMissionIDNum;
            Pl2PromoPoints                      = pl2File.PromoPoints;
            Pl2WorsePromoPoints                 = pl2File.WorsePromoPoints;
            Pl2RankAdjustmentApplied            = pl2File.RankAdjustmentApplied;
            Pl2PercentToNextRank                = pl2File.PercentToNextRank;
            Pl2TotalCategoryScore               = new MissionCategoryRecord(pl2File.totalScoreEMC);
            Pl2NumFlownNonSeries                = new MissionCategoryRecord(pl2File.numFlownNonSeriesEMC);
            Pl2NumFlownSeries                   = new MissionCategoryRecord(pl2File.numFlownSeriesEMC);
            Pl2TotalKills                       = new MissionCategoryRecord(pl2File.totalKillCountEMC);
            Pl2FriendlyKills                    = new MissionCategoryRecord(pl2File.totalFriendlyKillCountEMC);
            Pl2TotalKillCountByCraftType        = pl2File.TotalKillCountByCraftType ?? Array.Empty<int>();
            Pl2TotalFullKillsOnPlayerRating     = new MissionCategoryRecordByPlayerRating(pl2File.TotalFullKillsOnPlayerRank);
            Pl2TotalSharedKillsOnPlayerRating   = new MissionCategoryRecordByPlayerRating(pl2File.TotalSharedKillsOnPlayerRank);
            Pl2TotalAssistsOnPlayerRating       = new MissionCategoryRecordByPlayerRating(pl2File.TotalAssistKillsOnPlayerRank);
            Pl2TotalFullKillsOnAIRank           = new MissionCategoryRecordByAIRating(pl2File.TotalFullKillsOnAIRank);
            Pl2TotalSharedKillsOnAIRank         = new MissionCategoryRecordByAIRating(pl2File.TotalSharedKillsOnAIRank);
            Pl2TotalAssistsOnAIRank             = new MissionCategoryRecordByAIRating(pl2File.TotalAssistKillsOnAIRank);
            Pl2TotalHiddenCargoFound            = new MissionCategoryRecord(pl2File.TotalHiddenCargoFoundEMC);
            Pl2TotalLaserHit                    = new MissionCategoryRecord(pl2File.TotalLaserHitEMC);
            Pl2TotalLaserFired                  = new MissionCategoryRecord(pl2File.TotalLaserFiredEMC);
            Pl2TotalWarheadHit                  = new MissionCategoryRecord(pl2File.TotalWarheadHitEMC);
            Pl2TotalWarheadFired                = new MissionCategoryRecord(pl2File.TotalWarheadFiredEMC);
            Pl2TotalCraftLosses                 = new MissionCategoryRecord(pl2File.TotalCraftLossesEMC);
            Pl2TotalLossesFromCollisions        = new MissionCategoryRecord(pl2File.TotalLossesFromCollisionEMC);
            Pl2TotalLossesFromStarships         = new MissionCategoryRecord(pl2File.TotalLossesFromStarshipsEMC);
            Pl2TotalLossesFromMines             = new MissionCategoryRecord(pl2File.TotalLossesFromMinesEMC);
            Pl2TotalLossesFromPlayerRank        = new MissionCategoryRecordByPlayerRating(pl2File.TotalLossesFromPlayerRank);
            Pl2TotalLossesFromAIRank            = new MissionCategoryRecordByAIRating(pl2File.TotalLossesFromAIRank);
            Pl2activeTournament                 = pl2File.activeTournament;
            Pl2activeBattle                     = pl2File.activeBattle;
            Pl2CurrentRank                      = pl2File.CurrentRank;
            Pl2TotalCountMissionsFlown          = pl2File.TotalCountMissionsFlown;
            Pl2RankAchievedOnMissionCount       = pl2File.RankAchievedOnMissionCount ?? Array.Empty<int>();
            Pl2RankString                       = pl2File.RankString ?? string.Empty;
            Pl2DebriefMissionScore              = pl2File.debriefMissionScore;
            Pl2DebriefFullKillsOnPlayer         = pl2File.debriefFullKillsOnPlayer ?? Array.Empty<int>();
            Pl2DebriefSharedKillsOnPlayer       = pl2File.debriefSharedKillsOnPlayer ?? Array.Empty<int>();
            Pl2DebriefFullKillsOnFG             = pl2File.debriefFullKillsOnFG ?? Array.Empty<int>();
            Pl2DebriefSharedKillsOnFG           = pl2File.debriefSharedKillsOnFG ?? Array.Empty<int>();
            Pl2DebriefFullKillsByPlayer         = pl2File.debriefFullKillsByPlayer ?? Array.Empty<int>();
            Pl2DebriefSharedKillsByPlayer       = pl2File.debriefSharedKillsByPlayer ?? Array.Empty<int>();
            Pl2DebriefFullKillsByFG             = pl2File.debriefFullKillsByFG ?? Array.Empty<int>();
            Pl2DebriefSharedKillsByFG           = pl2File.debriefSharedKillsByFG ?? Array.Empty<int>();
            Pl2DebriefMeleeAIRankFG             = pl2File.debriefMeleeAIRankFG ?? Array.Empty<int>();
            Pl2debrief                          = pl2File.debrief;

            Pl2ConnectedPlayer = new ConnectedPlayerRecord[Constants.MAX_CONNECTED_PLAYERS];
            for (uint idx = 0; idx < Constants.MAX_CONNECTED_PLAYERS; ++idx)
            {
                Pl2ConnectedPlayer[idx] = new ConnectedPlayerRecord(pl2File.connectedPlayerData[idx]);
            }

            Pl2DebriefTeamResult = new TeamResultRecord[10]; // TODO: Why 10?  I mean, that's what's defined in the file, but what is the in-game significance?
            for (uint idx = 0; idx < 10; ++idx)
            {
                Pl2DebriefTeamResult[idx] = new TeamResultRecord(pl2File.debriefTeamResult[idx]);
            }

            Pl2LastSelectedFaction              = pl2File.SelectedFaction;
            Pl2faction                          = pl2File.faction ?? Array.Empty<PilotFileSchema.PL2FactionRecord>();
            Pl2activeCampaign                   = pl2File.activeCampaign;
            Pl2gap45E1E                         = pl2File.gap45E1E ?? Array.Empty<sbyte>();
            Pl2spBattleState                    = pl2File.spBattleState ?? Array.Empty<PilotFileSchema.PLTBattleState>();
            Pl2mpBattleState                    = pl2File.mpBattleState ?? Array.Empty<PilotFileSchema.PLTBattleState>();
            Pl2spCampaignState                  = pl2File.spCampaignState ?? Array.Empty<PilotFileSchema.PL2CampaignState>();
            Pl2mpCampaignHostState              = pl2File.mpCampaignHostState ?? Array.Empty<PilotFileSchema.PL2CampaignState>();
            Pl2mpCampaignClientState            = pl2File.mpCampaignClientState ?? Array.Empty<PilotFileSchema.PL2CampaignState>();
            Pl2anonymous_259                    = pl2File.anonymous_259 ?? Array.Empty<int>();
            Pl2anonymous_260                    = pl2File.anonymous_260;
            Pl2anonymous_261                    = pl2File.anonymous_261;
        }

        // Convert helper for MissionCategoryRecord -> int[]
        private static int[] ToIntArray(MissionCategoryRecord r)
        {
            return r == null ? Array.Empty<int>() : new[] { r.Exercise, r.Melee, r.CombatEngagement };
        }

        // Convert helper for MissionCategoryRecord -> PLTCategoryTypeRecord
        private static PLTCategoryTypeRecord ToPLTCategoryTypeRecord(MissionCategoryRecord r)
        {
            PLTCategoryTypeRecord newRecord;
            newRecord.exercise = r.Exercise;
            newRecord.melee = r.Melee;
            newRecord.combat = r.CombatEngagement;

            return newRecord;
        }

        // Convert helper for MissionCategoryRecordByPlayerRating -> PLTPlayerRankCountRecord
        private static PLTPlayerRankCountRecord ToPLTPlayerRankCountRecord(MissionCategoryRecordByPlayerRating r)
        {
            PLTPlayerRankCountRecord newRecord;
            newRecord.exercise = r.Exercise;
            newRecord.melee = r.Melee;
            newRecord.combat = r.CombatEngagement;

            return newRecord;
        }

        // Convert helper for MissionCategoryRecordByAIRating -> PLTAIRankCountRecord
        private static PLTAIRankCountRecord ToPLTAIRankCountRecord(MissionCategoryRecordByAIRating r)
        {
            PLTAIRankCountRecord newRecord;
            newRecord.exercise = r.Exercise;
            newRecord.melee = r.Melee;
            newRecord.combat = r.CombatEngagement;

            return newRecord;
        }

        // Convert helper for ConnectedPlayerRecord[] -> PLTConnectedPlayerData[]
        private static PLTConnectedPlayerData[] ToPLTConnectedPlayerDataArray(ConnectedPlayerRecord[] connectedPlayerRecord)
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
        private static PLTTeamResultRecord[] ToPLTTeamResultRecordArray(TeamResultRecord[] teamResultRecord)
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

        /// <summary>
        /// Create a PLTFileRecord populated from this PilotRecord (PLT fields).
        /// Only fields that are present on PilotRecord are set; other fields remain default.
        /// </summary>
        public PilotFileSchema.PLTFileRecord ToPltFileRecord()
        {
            var rec = new PilotFileSchema.PLTFileRecord();

            rec.PilotName                           = this.PltPilotName;                                                    // char[14]
            rec.TotalScore                          = this.PltTotalScore;
            rec.PlayerID                            = this.PltPlayerID;
            rec.continuedOrReflownMission           = this.PltContinuedOrReflownMission;
            rec.isHosting                           = this.PltIsHosting;
            rec.numHumanPlayersInMission            = this.PltNumHumanPlayersInMission;
            rec.frontFlyMode                        = this.PltFrontFlyMode;
            rec.unknown0x26                         = this.PltUnknown0x26;                                                  // int[10]
            rec.unknown0x166                        = this.PltUnknown0x166;                                                 // int[10]
            rec.unknown0x186                        = this.PltUnknown0x186;                                                 // int[10]
            rec.lastTeamNumber                      = this.PltlastTeamNumber;
            rec.lastSelectedMissionType             = this.PltlastSelectedMissionType;
            rec.lastSelectedTraining                = this.PltlastSelectedTraining;
            rec.lastSelectedMelee                   = this.PltlastSelectedMelee;
            rec.lastSelectedTournament              = this.PltlastSelectedTournament;
            rec.lastSelectedCombat                  = this.PltlastSelectedCombat;
            rec.lastSelectedBattle                  = this.PltlastSelectedBattle;
            rec.GameNameString                      = this.PltGameNameString;                                               // int[22]
            rec.unknown0x2F8                        = this.Pltunknown0x2F8;                                                 // int[10]
            rec.GameNameString2                     = this.PltGameNameString2;                                              // int[22]
            rec.unknown0x318                        = this.Pltunknown0x318;                                                 // int[10]
            rec.lastMissionWasNonSpecific           = this.PltlastMissionWasNonSpecific;
            rec.unknown0x326                        = this.Pltunknown0x326;
            rec.PromoPoints                         = this.PltPromoPoints;
            rec.WorsePromoPoints                    = this.PltWorsePromoPoints;
            rec.RankAdjustmentApplied               = this.PltRankAdjustmentApplied;
            rec.PercentToNextRank                   = this.PltPercentToNextRank;
            rec.totalCategoryScore                  = ToPLTCategoryTypeRecord(this.PltTotalCategoryScore);                  // int[3]
            rec.numFlownNonSeries                   = ToPLTCategoryTypeRecord(this.PltNumFlownNonSeries);                   // int[3]
            rec.numFlownSeries                      = ToPLTCategoryTypeRecord(this.PltNumFlownSeries);                      // int[3]
            rec.totalKillCount                      = ToPLTCategoryTypeRecord(this.PltTotalKills);                          // int[3]
            rec.numVanillaFriendlyKills             = ToPLTCategoryTypeRecord(this.PltFriendlyKills);                       // int[3]
            rec.totalCraftFullKillsExercise         = this.PlttotalCraftFullKillsExercise;                                  // int[88]
            rec.totalCraftFullKillsMelee            = this.PlttotalCraftFullKillsMelee;                                     // int[88]
            rec.totalCraftFullKillsCombat           = this.PlttotalCraftFullKillsCombat;                                    // int[88]
            rec.totalCraftSharedKillsExercise       = this.PlttotalCraftSharedKillsExercise;                                // int[88]
            rec.totalCraftSharedKillsMelee          = this.PlttotalCraftSharedKillsMelee;                                   // int[88]
            rec.totalCraftSharedKillsCombat         = this.PlttotalCraftSharedKillsCombat;                                  // int[88]
            rec.totalCraftAssistKillsExercise       = this.PlttotalCraftAssistKillsExercise;                                // int[88]
            rec.totalCraftAssistKillsMelee          = this.PlttotalCraftAssistKillsMelee;                                   // int[88]
            rec.totalCraftAssistKillsCombat         = this.PlttotalCraftAssistKillsCombat;                                  // int[88]
            rec.TotalFullKillsOnPlayerRank          = ToPLTPlayerRankCountRecord(this.PltTotalFullKillsOnPlayerRating);     // int[3][25]
            rec.TotalSharedKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(this.PltTotalSharedKillsOnPlayerRating);   // int[3][25]
            rec.TotalAssistKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(this.PltTotalAssistsOnPlayerRating);       // int[3][25]
            rec.TotalFullKillsOnAIRank              = ToPLTAIRankCountRecord(this.PltTotalFullKillsOnAIRank);               // int[3][6]
            rec.TotalSharedKillsOnAIRank            = ToPLTAIRankCountRecord(this.PltTotalSharedKillsOnAIRank);             // int[3][6]
            rec.TotalAssistKillsOnAIRank            = ToPLTAIRankCountRecord(this.PltTotalAssistsOnAIRank);                 // int[3][6]
            rec.totalHiddenCargoFound               = ToPLTCategoryTypeRecord(this.PltTotalHiddenCargoFound);               // int[3]
            rec.totalLaserHit                       = ToPLTCategoryTypeRecord(this.PltTotalLaserHit);                       // int[3]
            rec.totalLaserFiredExercise             = this.PltTotalLaserFired.Exercise;
            rec.totalLaserFiredMelee                = this.PltTotalLaserFired.Melee;
            rec.totalLaserFiredCombat               = this.PltTotalLaserFired.CombatEngagement;
            rec.totalWarheadHitExercise             = this.PltTotalWarheadHit.Exercise;
            rec.totalWarheadHitMelee                = this.PltTotalWarheadHit.Melee;
            rec.totalWarheadHitCombat               = this.PltTotalWarheadHit.CombatEngagement;
            rec.totalWarheadFiredExercise           = this.PltTotalWarheadFired.Exercise;
            rec.totalWarheadFiredMelee              = this.PltTotalWarheadFired.Melee;
            rec.totalWarheadFiredCombat             = this.PltTotalWarheadFired.CombatEngagement;
            rec.totalCraftLossesExercise            = this.PltTotalCraftLosses.Exercise;
            rec.totalCraftLossesMelee               = this.PltTotalCraftLosses.Melee;
            rec.totalCraftLossesCombat              = this.PltTotalCraftLosses.CombatEngagement;
            rec.totalLossesFromCollisionExercise    = this.PltTotalLossesFromCollisions.Exercise;
            rec.totalLossesFromCollisionMelee       = this.PltTotalLossesFromCollisions.Melee;
            rec.totalLossesFromCollisionCombat      = this.PltTotalLossesFromCollisions.CombatEngagement;
            rec.totalLossesFromStarshipsExercise    = this.PltTotalLossesFromStarships.Exercise;
            rec.totalLossesFromStarshipsMelee       = this.PltTotalLossesFromStarships.Melee;
            rec.totalLossesFromStarshipsCombat      = this.PltTotalLossesFromStarships.CombatEngagement;
            rec.totalLossesFromMinesExercise        = this.PltTotalLossesFromMines.Exercise;
            rec.totalLossesFromMinesMelee           = this.PltTotalLossesFromMines.Melee;
            rec.totalLossesFromMinesCombat          = this.PltTotalLossesFromMines.CombatEngagement;
            rec.TotalLossesFromPlayerRank           = ToPLTPlayerRankCountRecord(this.PltTotalLossesFromPlayerRank);        // int[3][25]
            rec.TotalLossesFromAIRank               = ToPLTAIRankCountRecord(this.PltTotalLossesFromAIRank);                // int[3][6]
            rec.unknown0x1612                       = this.Pltunknown0x1612;                                                // byte[40]
            rec.unknownPlaqueWon                    = this.PltunknownPlaqueWon;
            rec.TournTeamRecords                    = this.PltTournTeamRecords;                                             // int[10][5]
            rec.numHumanPlayersUNK                  = this.PltnumHumanPlayersUNK;
            rec.numTeamsUNK                         = this.PltnumTeamsUNK;
            rec.unknown0x170E                       = this.Pltunknown0x170E;
            rec.unknown0x1712                       = this.Pltunknown0x1712;
            rec.numCombatFlownInLastBattle          = this.PltnumCombatFlownInLastBattle;
            rec.unknown0x171A                       = this.Pltunknown0x171A;                                                // byte[2052]
            rec.battleCombatMissionID               = this.PltbattleCombatMissionID;                                        // int[4]
            rec.unknown0x1F2E                       = this.Pltunknown0x1F2E;                                                // byte[1012]
            rec.totalScoreForCurrentBattleUNK       = this.PlttotalScoreForCurrentBattleUNK;
            rec.CurrentRank                         = this.PltCurrentRank;
            rec.TotalCountMissionsFlown             = this.PltTotalCountMissionsFlown;
            rec.RankAchievedOnMissionCount          = this.PltRankAchievedOnMissionCount;                                   // int[25]
            rec.RankString                          = this.PltRankString;                                                   // char[32]
            rec.debriefMissionScore                 = this.PltDebriefMissionScore;
            rec.debriefFullKillsOnPlayer            = this.PltDebriefFullKillsOnPlayer;                                     // int[8]
            rec.debriefSharedKillsOnPlayer          = this.PltDebriefSharedKillsOnPlayer;                                   // int[8]
            rec.debriefFullKillsOnFG                = this.PltDebriefFullKillsOnFG;                                         // int[48]
            rec.debriefSharedKillsOnFG              = this.PltDebriefSharedKillsOnFG;                                       // int[48]
            rec.debriefFullKillsByPlayer            = this.PltDebriefFullKillsByPlayer;                                     // int[8]
            rec.debriefSharedKillsByPlayer          = this.PltDebriefSharedKillsByPlayer;                                   // int[8]
            rec.debriefFullKillsByFG                = this.PltDebriefFullKillsByFG;                                         // int[48]
            rec.debriefSharedKillsByFG              = this.PltDebriefSharedKillsByFG;                                       // int[48]
            rec.debriefMeleeAIRankFG                = this.PltDebriefMeleeAIRankFG;                                         // int[48]
            rec.UnknownRecord1                      = this.PltUnknownRecord1;                                               // int[3]
            rec.UnknownRecord2                      = this.PltUnknownRecord2;                                               // int[3]
            rec.UnknownRecord3                      = this.PltUnknownRecord3;                                               // int[3]
            rec.debriefEnemyKills                   = this.PltdebriefEnemyKills;                                            // int[3]
            rec.debriefFriendlyKills                = this.PltdebriefFriendlyKills;                                         // int[3]
            rec.debriefFullKillsByShipTypeA         = this.PltdebriefFullKillsByShipTypeA;                                  // int[88]
            rec.debriefFullKillsByShipTypeB         = this.PltdebriefFullKillsByShipTypeB;                                  // int[88]
            rec.debriefFullKillsByShipTypeC         = this.PltdebriefFullKillsByShipTypeC;                                  // int[88]
            rec.debriefSharedKillsByShipTypeA       = this.PltdebriefSharedKillsByShipTypeA;                                // int[88]
            rec.debriefSharedKillsByShipTypeB       = this.PltdebriefSharedKillsByShipTypeB;                                // int[88]
            rec.debriefSharedKillsByShipTypeC       = this.PltdebriefSharedKillsByShipTypeC;                                // int[88]
            rec.debriefAssistKillsByShipTypeA       = this.PltdebriefAssistKillsByShipTypeA;                                // int[88]
            rec.debriefAssistKillsByShipTypeB       = this.PltdebriefAssistKillsByShipTypeB;                                // int[88]
            rec.debriefAssistKillsByShipTypeC       = this.PltdebriefAssistKillsByShipTypeC;                                // int[88]
            rec.debriefFullKillsOnPlayerRank        = this.PltdebriefFullKillsOnPlayerRank;                                 // int[3][25]
            rec.debriefSharedKillsOnPlayerRank      = this.PltdebriefSharedKillsOnPlayerRank;                               // int[3][25]
            rec.debriefAssistKillsOnPlayerRank      = this.PltdebriefAssistKillsOnPlayerRank;                               // int[3][25]
            rec.debriefFullKillsOnAIRank            = this.PltdebriefFullKillsOnAIRank;                                     // int[3][6]
            rec.debriefSharedKillsOnAIRank          = this.PltdebriefSharedKillsOnAIRank;                                   // int[3][6]
            rec.debriefAssistKillsOnAIRank          = this.PltdebriefAssistKillsOnAIRank;                                   // int[3][6]
            rec.debriefNumHiddenCargoFound          = this.PltdebriefNumHiddenCargoFound;                                   // int[3]
            rec.debriefNumCannonHits                = this.PltdebriefNumCannonHits;                                         // int[3]
            rec.debriefNumCannonFired               = this.PltdebriefNumCannonFired;                                        // int[3]
            rec.debriefNumWarheadHits               = this.PltdebriefNumWarheadHits;                                        // int[3]
            rec.debriefNumWarheadFired              = this.PltdebriefNumWarheadFired;                                       // int[3]
            rec.debriefNumCraftLosses               = this.PltdebriefNumCraftLosses;                                        // int[3]
            rec.debriefCraftLossesFromCollision     = this.PltdebriefCraftLossesFromCollision;                              // int[3]
            rec.debriefCraftLossesFromStarship      = this.PltdebriefCraftLossesFromStarship;                               // int[3]
            rec.debriefCraftLossesFromMine          = this.PltdebriefCraftLossesFromMine;                                   // int[3]
            rec.debriefLossesFromPlayerRank         = this.PltdebriefLossesFromPlayerRank;                                  // int[3][25]
            rec.debriefLossesFromAIRank             = this.PltdebriefLossesFromAIRank;                                      // int[3][6]
            rec.connectedPlayerData                 = ToPLTConnectedPlayerDataArray(this.PltConnectedPlayer);               // PLTConnectedPlayerData[8]
            rec.debriefTeamResult                   = ToPLTTeamResultRecordArray(this.PltDebriefTeamResult);                // PLTTeamResultRecord[10]  (int[10][6])
            rec.lastSelectedFaction                 = this.PltLastSelectedFaction;
            rec.rebelSingleplayerData               = this.PltrebelSingleplayerData;
            rec.imperialSingleplayerData            = this.PltimperialSingleplayerData;
            rec.rebelMultiplayerData                = this.PltrebelMultiplayerData;
            rec.imperialMultiplayerData             = this.PltimperialMultiplayerData;

            return rec;
        }

        /// <summary>
        /// Create a PL2FileRecord populated from this PilotRecord (PL2 fields).
        /// Only fields that are present on PilotRecord are set; other fields remain default.
        /// </summary>
        public PilotFileSchema.PL2FileRecord ToPl2FileRecord()
        {
            var rec = new PilotFileSchema.PL2FileRecord();

            rec.PilotName                           = this.Pl2PilotName;                                                    // char[14]
            rec.TotalScore                          = this.Pl2TotalScore;
            rec.PlayerID                            = this.Pl2PlayerID;
            rec.continuedOrReflownMission           = this.Pl2ContinuedOrReflownMission;
            rec.isHosting                           = this.Pl2IsHosting;
            rec.numHumanPlayersInMission            = this.Pl2NumHumanPlayersInMission;
            rec.frontFlyMode                        = this.Pl2FrontFlyMode;
            rec.unknown0x26                         = this.Pl2Unknown0x26;                                                  // int[80]
            rec.unknown0x166                        = this.Pl2Unknown0x166;                                                 // int[8]
            rec.unknown0x186                        = this.Pl2Unknown0x186;                                                 // int[80]
            rec.activeMissionTeam                   = this.Pl2activeMissionTeam;
            rec.MissionFolderIndex                  = this.Pl2MissionFolderIndex;
            rec.SelectedIDNumOfMissionCategory      = this.Pl2SelectedIDNumOfMissionCategory;                               // int[6]
            rec.GameName                            = this.Pl2GameName;                                                     // char[32]
            rec.LastGameName                        = this.Pl2LastGameName;                                                 // char[32]
            rec.isMissionCategorySeries             = this.Pl2isMissionCategorySeries;
            rec.activeMissionIDNum                  = this.Pl2activeMissionIDNum;
            rec.PromoPoints                         = this.Pl2PromoPoints;
            rec.WorsePromoPoints                    = this.Pl2WorsePromoPoints;
            rec.RankAdjustmentApplied               = this.Pl2RankAdjustmentApplied;
            rec.PercentToNextRank                   = this.Pl2PercentToNextRank;
            rec.totalScoreEMC                       = ToIntArray(this.Pl2TotalCategoryScore);                               // int[3]
            rec.numFlownNonSeriesEMC                = ToIntArray(this.Pl2NumFlownNonSeries);                                // int[3]
            rec.numFlownSeriesEMC                   = ToIntArray(this.Pl2NumFlownSeries);                                   // int[3]
            rec.totalKillCountEMC                   = ToIntArray(this.Pl2TotalKills);                                       // int[3]
            rec.totalFriendlyKillCountEMC           = ToIntArray(this.Pl2FriendlyKills);                                    // int[3]
            rec.TotalKillCountByCraftType           = this.Pl2TotalKillCountByCraftType;                                    // int[900]
            rec.TotalFullKillsOnPlayerRank          = ToPLTPlayerRankCountRecord(this.Pl2TotalFullKillsOnPlayerRating);     // int[3][25]
            rec.TotalSharedKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(this.Pl2TotalSharedKillsOnPlayerRating);   // int[3][25]
            rec.TotalAssistKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(this.Pl2TotalAssistsOnPlayerRating);       // int[3][25]
            rec.TotalFullKillsOnAIRank              = ToPLTAIRankCountRecord(this.Pl2TotalFullKillsOnAIRank);               // int[3][6]
            rec.TotalSharedKillsOnAIRank            = ToPLTAIRankCountRecord(this.Pl2TotalSharedKillsOnAIRank);             // int[3][6]
            rec.TotalAssistKillsOnAIRank            = ToPLTAIRankCountRecord(this.Pl2TotalAssistsOnAIRank);                 // int[3][6]
            rec.TotalHiddenCargoFoundEMC            = ToIntArray(this.Pl2TotalHiddenCargoFound);                            // int[3]
            rec.TotalLaserHitEMC                    = ToIntArray(this.Pl2TotalLaserHit);                                    // int[3]
            rec.TotalLaserFiredEMC                  = ToIntArray(this.Pl2TotalLaserFired);                                  // int[3]
            rec.TotalWarheadHitEMC                  = ToIntArray(this.Pl2TotalWarheadHit);                                  // int[3]
            rec.TotalWarheadFiredEMC                = ToIntArray(this.Pl2TotalWarheadFired);                                // int[3]
            rec.TotalCraftLossesEMC                 = ToIntArray(this.Pl2TotalCraftLosses);                                 // int[3]
            rec.TotalLossesFromCollisionEMC         = ToIntArray(this.Pl2TotalLossesFromCollisions);                        // int[3]
            rec.TotalLossesFromStarshipsEMC         = ToIntArray(this.Pl2TotalLossesFromStarships);                         // int[3]
            rec.TotalLossesFromMinesEMC             = ToIntArray(this.Pl2TotalLossesFromMines);                             // int[3]
            rec.TotalLossesFromPlayerRank           = ToPLTPlayerRankCountRecord(this.Pl2TotalLossesFromPlayerRank);        // int[3][25]
            rec.TotalLossesFromAIRank               = ToPLTAIRankCountRecord(this.Pl2TotalLossesFromAIRank);                // int[3][6]
            rec.activeTournament                    = this.Pl2activeTournament;
            rec.activeBattle                        = this.Pl2activeBattle;
            rec.CurrentRank                         = this.Pl2CurrentRank;
            rec.TotalCountMissionsFlown             = this.Pl2TotalCountMissionsFlown;
            rec.RankAchievedOnMissionCount          = this.Pl2RankAchievedOnMissionCount;                                   // int[25]
            rec.RankString                          = this.Pl2RankString;                                                   // char[32]
            rec.debriefMissionScore                 = this.Pl2DebriefMissionScore;
            rec.debriefFullKillsOnPlayer            = this.Pl2DebriefFullKillsOnPlayer;                                     // int[8]
            rec.debriefSharedKillsOnPlayer          = this.Pl2DebriefSharedKillsOnPlayer;                                   // int[8]
            rec.debriefFullKillsOnFG                = this.Pl2DebriefFullKillsOnFG;                                         // int[48]
            rec.debriefSharedKillsOnFG              = this.Pl2DebriefSharedKillsOnFG;                                       // int[48]
            rec.debriefFullKillsByPlayer            = this.Pl2DebriefFullKillsByPlayer;                                     // int[8]
            rec.debriefSharedKillsByPlayer          = this.Pl2DebriefSharedKillsByPlayer;                                   // int[8]
            rec.debriefFullKillsByFG                = this.Pl2DebriefFullKillsByFG;                                         // int[48]
            rec.debriefSharedKillsByFG              = this.Pl2DebriefSharedKillsByFG;                                       // int[48]
            rec.debriefMeleeAIRankFG                = this.Pl2DebriefMeleeAIRankFG;                                         // int[48]
            rec.debrief                             = this.Pl2debrief;
            rec.connectedPlayerData                 = ToPLTConnectedPlayerDataArray(this.Pl2ConnectedPlayer);               // PLTConnectedPlayerData[8]
            rec.debriefTeamResult                   = ToPLTTeamResultRecordArray(this.Pl2DebriefTeamResult);                // PLTTeamResultRecord[10]  (int[10][6])
            rec.SelectedFaction                     = this.Pl2LastSelectedFaction;
            rec.faction                             = this.Pl2faction;
            rec.activeCampaign                      = this.Pl2activeCampaign;
            rec.gap45E1E                            = this.Pl2gap45E1E;                                                     // sbyte[4]
            rec.spBattleState                       = this.Pl2spBattleState;
            rec.mpBattleState                       = this.Pl2mpBattleState;
            rec.spCampaignState                     = this.Pl2spCampaignState;
            rec.mpCampaignHostState                 = this.Pl2mpCampaignHostState;
            rec.mpCampaignClientState               = this.Pl2mpCampaignClientState;
            rec.anonymous_259                       = this.Pl2anonymous_259;
            rec.anonymous_260                       = this.Pl2anonymous_260;
            rec.anonymous_261                       = this.Pl2anonymous_261;

            return rec;
        }
    }

    public class MissionCategoryRecord
    {
        public int Exercise { get; set; }
        public int Melee { get; set; }
        public int CombatEngagement { get; set; }

        public MissionCategoryRecord()
        {
            this.Exercise = 0;
            this.Melee = 0;
            this.CombatEngagement = 0;
        }

        public MissionCategoryRecord(int exercise, int melee, int combatEngagement)
        {
            this.Exercise = exercise;
            this.Melee = melee;
            this.CombatEngagement = combatEngagement;
        }

        public MissionCategoryRecord(int[] missionCategoryRecord)
        {
            if (missionCategoryRecord.Length != Enum.GetNames(typeof(MissionType)).Length)
            {
                throw new ArgumentException("missionCategoryRecord array must have exactly 3 elements.", nameof(missionCategoryRecord));
            }

            this.Exercise = missionCategoryRecord[(int)MissionType.Exercise];
            this.Melee = missionCategoryRecord[(int)MissionType.Melee];
            this.CombatEngagement = missionCategoryRecord[(int)MissionType.Combat];
        }

        public MissionCategoryRecord(PLTCategoryTypeRecord missionCategoryRecord)
        {
            this.Exercise = missionCategoryRecord.exercise;
            this.Melee = missionCategoryRecord.melee;
            this.CombatEngagement = missionCategoryRecord.combat;
        }
    }

    public class MissionCategoryRecordByPlayerRating
    {
        public int[] Exercise { get; private set; } = Array.Empty<int>();
        public int[] Melee { get; private set; } = Array.Empty<int>();
        public int[] CombatEngagement { get; private set; } = Array.Empty<int>();

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

            this.Exercise = exercise;
            this.Melee = melee;
            this.CombatEngagement = combatEngagement;
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
            this.Exercise = missionCategoryRecord.exercise;
            this.Melee = missionCategoryRecord.melee;
            this.CombatEngagement = missionCategoryRecord.combat;
        }
    }

    public class MissionCategoryRecordByAIRating
    {
        public int[] Exercise { get; private set; } = Array.Empty<int>();
        public int[] Melee { get; private set; } = Array.Empty<int>();
        public int[] CombatEngagement { get; private set; } = Array.Empty<int>();

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

            this.Exercise = exercise;
            this.Melee = melee;
            this.CombatEngagement = combatEngagement;
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
            this.Exercise = missionCategoryRecord.exercise;
            this.Melee = missionCategoryRecord.melee;
            this.CombatEngagement = missionCategoryRecord.combat;
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
