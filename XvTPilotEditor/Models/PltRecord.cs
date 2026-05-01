using System;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.Models
{
    public class PltRecord : PilotRecordBase
    {
        // Note: these five paragraphs correlate to the gaps in the PilotRecordBase properties; integrating them reveals the structure of the plt file
        // TODO: Consider creating directly from filebytes/exporting filebytes, rather than PilotFileSchema objects.

        //  TODO: Look into bringing this into the Base class (i.e., merging how Plt and Pl2 handle this)
        public int                                  LastTeamNumber                      { get; set; }                                                       //              TODO: Investigate if this is the same as Pl2's activeMissionTeam
        public int                                  LastSelectedMissionType             { get; set; }                                                       //              TODO: Investigate if this is the same as Pl2's MissionFolderIndex
        public int                                  LastSelectedTraining                { get; set; }                                                       //              TODO: Investigate if this is the same as Pl2's SelectedIDNumOfMissionCategory[0]
        public int                                  LastSelectedMelee                   { get; set; }                                                       //              TODO: Investigate if this is the same as Pl2's SelectedIDNumOfMissionCategory[1]
        public int                                  LastSelectedTournament              { get; set; }                                                       //              TODO: Investigate if this is the same as Pl2's SelectedIDNumOfMissionCategory[2]
        public int                                  LastSelectedCombat                  { get; set; }                                                       //              TODO: Investigate if this is the same as Pl2's SelectedIDNumOfMissionCategory[3]
        public int                                  LastSelectedBattle                  { get; set; }                                                       //              TODO: Investigate if this is the same as Pl2's SelectedIDNumOfMissionCategory[4]
        public string                               GameNameString                      { get; set; }   = string.Empty;                                     // char[22]     TODO: Investigate if this is the same as Pl2's GameName
        public byte[]                               Unknown0x2F8                        { get; set; }   = Array.Empty<byte>();                              // byte[10]     TODO: Appears to just be padding; probably don't need to provide UI access to this, but should still preserve it when writing to file
        public string                               GameNameString2                     { get; set; }   = string.Empty;                                     // char[22]     TODO: Investigate if this is the same as Pl2's LastGameName
        public byte[]                               Unknown0x318                        { get; set; }   = Array.Empty<byte>();                              // byte[10]     TODO: Appears to just be padding; probably don't need to provide UI access to this, but should still preserve it when writing to file
        public int                                  LastMissionWasNonSpecific           { get; set; }                                                       //              TODO: What is this?  Is it the same as Pl2's isMissionCategorySeries?
        public int                                  Unknown0x326                        { get; set; }                                                       //              TODO: What is this?  Is it the same as Pl2's activeMissionIDNum?

        //  Note the difference in types between the Plt and Pl2 versions
        //  TODO: Look into bringing this into the Base class (i.e., merging how Plt and Pl2 handle this)
        public int[]                                TotalFullKillsByCraftExercise       { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalFullKillsByCraftMelee          { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalFullKillsByCraftCombat         { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalSharedKillsByCraftExercise     { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalSharedKillsByCraftMelee        { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalSharedKillsByCraftCombat       { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalAssistsByCraftExercise         { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalAssistsByCraftMelee            { get; set; }   = Array.Empty<int>();                               // int[88]
        public int[]                                TotalAssistsByCraftCombat           { get; set; }   = Array.Empty<int>();                               // int[88]

        public byte[]                               Unknown0x1612                       { get; set; }   = Array.Empty<byte>();                              // byte[40]     TODO: Appears to just be padding; probably don't need to provide UI access to this, but should still preserve it when writing to file
        public int                                  UnknownPlaqueWon                    { get; set; }                                                       //              TODO: What is this? Give it a better name and remove the "Unknown" prefix
        public TournamentTeamRecord[]               TournamentTeamRecord                { get; set; }   = new TournamentTeamRecord[Constants.MAX_TEAMS];    // int[10][5]
        public int                                  NumHumanPlayersUNK                  { get; set; }                                                       //              TODO: What is this? Give it a better name and remove the "UNK" postfix
        public int                                  NumTeamsUNK                         { get; set; }                                                       //              TODO: What is this? Give it a better name and remove the "UNK" postfix
        public int                                  Unknown0x170E                       { get; set; }                                                       //              TODO: What is this?
        public int                                  Unknown0x1712                       { get; set; }                                                       //              TODO: What is this?
        public int                                  NumCombatFlownInLastBattle          { get; set; }                                                       //              TODO: Confirm this is the number of combet engagements flown in the last battle
        public byte[]                               Unknown0x171A                       { get; set; }   = Array.Empty<byte>();                              // byte[2052]   TODO: What is this?  Too big to be padding.  Regardless, probably don't need to provide UI access to this, but should still preserve it when writing to file
        public int[]                                BattleCombatMissionID               { get; set; }   = Array.Empty<int>();                               // int[4]       TODO: What actually is this?  Battles can have up to 7 missions, but at most 4 victories, so maybe that's it?
        public byte[]                               Unknown0x1F2E                       { get; set; }   = Array.Empty<byte>();                              // byte[1012]   TODO: What is this?  Too big to be padding.  Regardless, probably don't need to provide UI access to this, but should still preserve it when writing to file
        public int                                  TotalScoreForCurrentBattleUNK       { get; set; }                                                       //              TODO: Why the UNK postfix?

        public MissionCategoryRecord                UnknownRecord1                      { get; set; }   = new MissionCategoryRecord();                      // int[3]       TODO: What is this?
        public MissionCategoryRecord                UnknownRecord2                      { get; set; }   = new MissionCategoryRecord();                      // int[3]       TODO: What is this?
        public MissionCategoryRecord                UnknownRecord3                      { get; set; }   = new MissionCategoryRecord();                      // int[3]       TODO: What is this?
        public MissionCategoryRecord                DebriefEnemyKills                   { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefFriendlyKills                { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public int[]                                DebriefFullKillsByShipTypeA         { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefFullKillsByShipTypeB         { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefFullKillsByShipTypeC         { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefSharedKillsByShipTypeA       { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefSharedKillsByShipTypeB       { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefSharedKillsByShipTypeC       { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefAssistKillsByShipTypeA       { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefAssistKillsByShipTypeB       { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public int[]                                DebriefAssistKillsByShipTypeC       { get; set; }   = Array.Empty<int>();                               // int[88]      TODO: ShipType == CraftType, preumably, but why A, B, and C?
        public MissionCategoryRecordByPlayerRating  DebriefFullKillsByPlayerRating      { get; set; }   = new MissionCategoryRecordByPlayerRating();        // int[3][25]
        public MissionCategoryRecordByPlayerRating  DebriefSharedKillsByPlayerRating    { get; set; }   = new MissionCategoryRecordByPlayerRating();        // int[3][25]
        public MissionCategoryRecordByPlayerRating  DebriefAssistByPlayerRating         { get; set; }   = new MissionCategoryRecordByPlayerRating();        // int[3][25]
        public MissionCategoryRecordByAIRating      DebriefFullKillsByAIRank            { get; set; }   = new MissionCategoryRecordByAIRating();            // int[3][6]
        public MissionCategoryRecordByAIRating      DebriefSharedKillsByAIRank          { get; set; }   = new MissionCategoryRecordByAIRating();            // int[3][6]
        public MissionCategoryRecordByAIRating      DebriefAssistsByAIRank              { get; set; }   = new MissionCategoryRecordByAIRating();            // int[3][6]
        public MissionCategoryRecord                DebriefNumHiddenCargoFound          { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumLaserHit                  { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumLaserFired                { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumWarheadHit                { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumWarheadFired              { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumCraftLosses               { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumLossesFromCollisions      { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumLossesFromStarships       { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecord                DebriefNumLossesFromMines           { get; set; }   = new MissionCategoryRecord();                      // int[3]
        public MissionCategoryRecordByPlayerRating  DebriefLossesByPlayerRating         { get; set; }   = new MissionCategoryRecordByPlayerRating();        // int[3][25]   TODO: Confirm this is really Exercise, Melee, Combat; found values in the Exercise column, but that is unexpected (Exercise should be co-op only)
        public MissionCategoryRecordByAIRating      DebriefLossesByAIRank               { get; set; }   = new MissionCategoryRecordByAIRating();            // int[3][6]

        //  Note the difference in types between the Plt and Pl2 versions
        public int LastSelectedFaction { get; set; }                                                                                            //          TODO: Look into bringing this into the Base class (i.e., merging how Plt and Pl2 handle this)
        public PLTFactionRecord         rebelSingleplayerData           { get; private set; }
        public PLTFactionRecord         imperialSingleplayerData        { get; private set; }
        public PLTFactionRecord         rebelMultiplayerData            { get; private set; }
        public PLTFactionRecord         imperialMultiplayerData         { get; private set; }

        private PLTFileRecord _pltData;
        public PLTFileRecord PltData { get => _pltData; }

        public PltRecord()
        {
        }

        public PltRecord(PLTFileRecord pltFile)
        {
            FillFromPlt(pltFile);
        }

        public void FillFromPlt(PLTFileRecord pltFile)
        {
            _pltData = pltFile;

            PilotName                           = pltFile.PilotName ?? string.Empty;
            TotalScore                          = pltFile.TotalScore;
            PlayerID                            = pltFile.PlayerID;
            ContinuedOrReflownMission           = pltFile.continuedOrReflownMission;
            IsHosting                           = pltFile.isHosting;
            NumHumanPlayersInMission            = pltFile.numHumanPlayersInMission;
            FrontFlyMode                        = pltFile.frontFlyMode;
            Unknown0x26                         = pltFile.unknown0x26 ?? Array.Empty<int>();
            Unknown0x166                        = pltFile.unknown0x166 ?? Array.Empty<int>();
            Unknown0x186                        = pltFile.unknown0x186 ?? Array.Empty<int>();
            LastTeamNumber                      = pltFile.lastTeamNumber;
            LastSelectedMissionType             = pltFile.lastSelectedMissionType;
            LastSelectedTraining                = pltFile.lastSelectedTraining;
            LastSelectedMelee                   = pltFile.lastSelectedMelee;
            LastSelectedTournament              = pltFile.lastSelectedTournament;
            LastSelectedCombat                  = pltFile.lastSelectedCombat;
            LastSelectedBattle                  = pltFile.lastSelectedBattle;
            GameNameString                      = pltFile.GameNameString ?? string.Empty;
            Unknown0x2F8                        = pltFile.unknown0x2F8 ?? Array.Empty<byte>();
            GameNameString2                     = pltFile.GameNameString2 ?? string.Empty;
            Unknown0x318                        = pltFile.unknown0x318 ?? Array.Empty<byte>();
            LastMissionWasNonSpecific           = pltFile.lastMissionWasNonSpecific;
            Unknown0x326                        = pltFile.unknown0x326;
            PromoPoints                         = pltFile.PromoPoints;
            WorsePromoPoints                    = pltFile.WorsePromoPoints;
            RankAdjustmentApplied               = pltFile.RankAdjustmentApplied;
            PercentToNextRank                   = pltFile.PercentToNextRank;
            TotalCategoryScore                  = new MissionCategoryRecord(pltFile.totalCategoryScore);
            NumFlownNonSeries                   = new MissionCategoryRecord(pltFile.numFlownNonSeries);
            NumFlownSeries                      = new MissionCategoryRecord(pltFile.numFlownSeries);
            TotalKills                          = new MissionCategoryRecord(pltFile.totalKillCount);
            FriendlyKills                       = new MissionCategoryRecord(pltFile.numVanillaFriendlyKills);
            TotalFullKillsByCraftExercise        = pltFile.totalCraftFullKillsExercise ?? Array.Empty<int>();
            TotalFullKillsByCraftMelee           = pltFile.totalCraftFullKillsMelee ?? Array.Empty<int>();
            TotalFullKillsByCraftCombat          = pltFile.totalCraftFullKillsCombat ?? Array.Empty<int>();
            TotalSharedKillsByCraftExercise      = pltFile.totalCraftSharedKillsExercise ?? Array.Empty<int>();
            TotalSharedKillsByCraftMelee         = pltFile.totalCraftSharedKillsMelee ?? Array.Empty<int>();
            TotalSharedKillsByCraftCombat        = pltFile.totalCraftSharedKillsCombat ?? Array.Empty<int>();
            TotalAssistsByCraftExercise         = pltFile.totalCraftAssistKillsExercise ?? Array.Empty<int>();
            TotalAssistsByCraftMelee            = pltFile.totalCraftAssistKillsMelee ?? Array.Empty<int>();
            TotalAssistsByCraftCombat           = pltFile.totalCraftAssistKillsCombat ?? Array.Empty<int>();
            TotalFullKillsByPlayerRating        = new MissionCategoryRecordByPlayerRating(pltFile.TotalFullKillsOnPlayerRank);
            TotalSharedKillsByPlayerRating      = new MissionCategoryRecordByPlayerRating(pltFile.TotalSharedKillsOnPlayerRank);
            TotalAssistsByPlayerRating          = new MissionCategoryRecordByPlayerRating(pltFile.TotalAssistKillsOnPlayerRank);
            TotalFullKillsByAIRank              = new MissionCategoryRecordByAIRating(pltFile.TotalFullKillsOnAIRank);
            TotalSharedKillsByAIRank            = new MissionCategoryRecordByAIRating(pltFile.TotalSharedKillsOnAIRank);
            TotalAssistsByAIRank                = new MissionCategoryRecordByAIRating(pltFile.TotalAssistKillsOnAIRank);
            TotalHiddenCargoFound               = new MissionCategoryRecord(pltFile.totalHiddenCargoFound);
            TotalLaserHit                       = new MissionCategoryRecord(pltFile.totalLaserHit);
            TotalLaserFired                     = new MissionCategoryRecord(pltFile.totalLaserFiredExercise, pltFile.totalLaserFiredMelee, pltFile.totalLaserFiredCombat);
            TotalWarheadHit                     = new MissionCategoryRecord(pltFile.totalWarheadHitExercise, pltFile.totalWarheadHitMelee, pltFile.totalWarheadHitCombat);
            TotalWarheadFired                   = new MissionCategoryRecord(pltFile.totalWarheadFiredExercise, pltFile.totalWarheadFiredMelee, pltFile.totalWarheadFiredCombat);
            TotalCraftLosses                    = new MissionCategoryRecord(pltFile.totalCraftLossesExercise, pltFile.totalCraftLossesMelee, pltFile.totalCraftLossesCombat);
            TotalLossesFromCollisions           = new MissionCategoryRecord(pltFile.totalLossesFromCollisionExercise, pltFile.totalLossesFromCollisionMelee, pltFile.totalLossesFromCollisionCombat);
            TotalLossesFromStarships            = new MissionCategoryRecord(pltFile.totalLossesFromStarshipsExercise, pltFile.totalLossesFromStarshipsMelee, pltFile.totalLossesFromStarshipsCombat);
            TotalLossesFromMines                = new MissionCategoryRecord(pltFile.totalLossesFromMinesExercise, pltFile.totalLossesFromMinesMelee, pltFile.totalLossesFromMinesCombat);
            TotalLossesByPlayerRating           = new MissionCategoryRecordByPlayerRating(pltFile.TotalLossesFromPlayerRank);
            TotalLossesByAIRank                 = new MissionCategoryRecordByAIRating(pltFile.TotalLossesFromAIRank);
            Unknown0x1612                       = pltFile.unknown0x1612 ?? Array.Empty<byte>();
            UnknownPlaqueWon                    = pltFile.unknownPlaqueWon;

            TournamentTeamRecord = new TournamentTeamRecord[Constants.MAX_TEAMS];
            for (uint idx = 0; idx < Constants.MAX_TEAMS; ++idx)
            {
                TournamentTeamRecord[idx] = new TournamentTeamRecord(pltFile.TournTeamRecords[idx]);
            }

            NumHumanPlayersUNK                  = pltFile.numHumanPlayersUNK;
            NumTeamsUNK                         = pltFile.numTeamsUNK;
            Unknown0x170E                       = pltFile.unknown0x170E;
            Unknown0x1712                       = pltFile.unknown0x1712;
            NumCombatFlownInLastBattle          = pltFile.numCombatFlownInLastBattle;
            Unknown0x171A                       = pltFile.unknown0x171A ?? Array.Empty<byte>();
            BattleCombatMissionID               = pltFile.battleCombatMissionID ?? Array.Empty<int>();
            Unknown0x1F2E                       = pltFile.unknown0x1F2E ?? Array.Empty<byte>();
            TotalScoreForCurrentBattleUNK       = pltFile.totalScoreForCurrentBattleUNK;
            CurrentRank                         = pltFile.CurrentRank;
            TotalCountMissionsFlown             = pltFile.TotalCountMissionsFlown;
            RankAchievedOnMissionCount          = pltFile.RankAchievedOnMissionCount ?? Array.Empty<int>();
            RankString                          = pltFile.RankString ?? string.Empty;
            DebriefMissionScore                 = pltFile.debriefMissionScore;
            DebriefFullKillsOnPlayer            = pltFile.debriefFullKillsOnPlayer ?? Array.Empty<int>();
            DebriefSharedKillsOnPlayer          = pltFile.debriefSharedKillsOnPlayer ?? Array.Empty<int>();
            DebriefFullKillsOnFG                = pltFile.debriefFullKillsOnFG ?? Array.Empty<int>();
            DebriefSharedKillsOnFG              = pltFile.debriefSharedKillsOnFG ?? Array.Empty<int>();
            DebriefFullKillsByPlayer            = pltFile.debriefFullKillsByPlayer ?? Array.Empty<int>();
            DebriefSharedKillsByPlayer          = pltFile.debriefSharedKillsByPlayer ?? Array.Empty<int>();
            DebriefFullKillsByFG                = pltFile.debriefFullKillsByFG ?? Array.Empty<int>();
            DebriefSharedKillsByFG              = pltFile.debriefSharedKillsByFG ?? Array.Empty<int>();
            DebriefMeleeAIRankFG                = pltFile.debriefMeleeAIRankFG ?? Array.Empty<int>();
            UnknownRecord1                      = new MissionCategoryRecord(pltFile.UnknownRecord1);
            UnknownRecord2                      = new MissionCategoryRecord(pltFile.UnknownRecord2);
            UnknownRecord3                      = new MissionCategoryRecord(pltFile.UnknownRecord3);
            DebriefEnemyKills                   = new MissionCategoryRecord(pltFile.debriefEnemyKills);
            DebriefFriendlyKills                = new MissionCategoryRecord(pltFile.debriefFriendlyKills);
            DebriefFullKillsByShipTypeA         = pltFile.debriefFullKillsByShipTypeA ?? Array.Empty<int>();
            DebriefFullKillsByShipTypeB         = pltFile.debriefFullKillsByShipTypeB ?? Array.Empty<int>();
            DebriefFullKillsByShipTypeC         = pltFile.debriefFullKillsByShipTypeC ?? Array.Empty<int>();
            DebriefSharedKillsByShipTypeA       = pltFile.debriefSharedKillsByShipTypeA ?? Array.Empty<int>();
            DebriefSharedKillsByShipTypeB       = pltFile.debriefSharedKillsByShipTypeB ?? Array.Empty<int>();
            DebriefSharedKillsByShipTypeC       = pltFile.debriefSharedKillsByShipTypeC ?? Array.Empty<int>();
            DebriefAssistKillsByShipTypeA       = pltFile.debriefAssistKillsByShipTypeA ?? Array.Empty<int>();
            DebriefAssistKillsByShipTypeB       = pltFile.debriefAssistKillsByShipTypeB ?? Array.Empty<int>();
            DebriefAssistKillsByShipTypeC       = pltFile.debriefAssistKillsByShipTypeC ?? Array.Empty<int>();
            DebriefFullKillsByPlayerRating      = new MissionCategoryRecordByPlayerRating(pltFile.debriefFullKillsOnPlayerRank);
            DebriefSharedKillsByPlayerRating    = new MissionCategoryRecordByPlayerRating(pltFile.debriefSharedKillsOnPlayerRank);
            DebriefAssistByPlayerRating         = new MissionCategoryRecordByPlayerRating(pltFile.debriefAssistKillsOnPlayerRank);
            DebriefFullKillsByAIRank            = new MissionCategoryRecordByAIRating(pltFile.debriefFullKillsOnAIRank);
            DebriefSharedKillsByAIRank          = new MissionCategoryRecordByAIRating(pltFile.debriefSharedKillsOnAIRank);
            DebriefAssistsByAIRank              = new MissionCategoryRecordByAIRating(pltFile.debriefAssistKillsOnAIRank);
            DebriefNumHiddenCargoFound          = new MissionCategoryRecord(pltFile.debriefNumHiddenCargoFound);
            DebriefNumLaserHit                  = new MissionCategoryRecord(pltFile.debriefNumCannonHits);
            DebriefNumLaserFired                = new MissionCategoryRecord(pltFile.debriefNumCannonFired);
            DebriefNumWarheadHit                = new MissionCategoryRecord(pltFile.debriefNumWarheadHits);
            DebriefNumWarheadFired              = new MissionCategoryRecord(pltFile.debriefNumWarheadFired);
            DebriefNumCraftLosses               = new MissionCategoryRecord(pltFile.debriefNumCraftLosses);
            DebriefNumLossesFromCollisions      = new MissionCategoryRecord(pltFile.debriefCraftLossesFromCollision);
            DebriefNumLossesFromStarships       = new MissionCategoryRecord(pltFile.debriefCraftLossesFromStarship);
            DebriefNumLossesFromMines           = new MissionCategoryRecord(pltFile.debriefCraftLossesFromMine);
            DebriefLossesByPlayerRating         = new MissionCategoryRecordByPlayerRating(pltFile.debriefLossesFromPlayerRank);
            DebriefLossesByAIRank               = new MissionCategoryRecordByAIRating(pltFile.debriefLossesFromAIRank);

            ConnectedPlayer = new ConnectedPlayerRecord[Constants.MAX_CONNECTED_PLAYERS];
            for (uint idx = 0; idx < Constants.MAX_CONNECTED_PLAYERS; ++idx)
            {
                ConnectedPlayer[idx] = new ConnectedPlayerRecord(pltFile.connectedPlayerData[idx]);
            }

            DebriefTeamResult = new TeamResultRecord[Constants.MAX_TEAMS];
            for (uint idx = 0; idx < Constants.MAX_TEAMS; ++idx)
            {
                DebriefTeamResult[idx] = new TeamResultRecord(pltFile.debriefTeamResult[idx]);
            }

            LastSelectedFaction                 = pltFile.lastSelectedFaction;
            rebelSingleplayerData               = pltFile.rebelSingleplayerData;
            imperialSingleplayerData            = pltFile.imperialSingleplayerData;
            rebelMultiplayerData                = pltFile.rebelMultiplayerData;
            imperialMultiplayerData             = pltFile.imperialMultiplayerData;
        }

        /// <summary>
        /// Create a PLTFileRecord populated from this PilotRecord (PLT fields).
        /// Only fields that are present on PilotRecord are set; other fields remain default.
        /// </summary>
        public PLTFileRecord ToPltFileRecord()
        {
            var rec = new PLTFileRecord();

            rec.PilotName                           = PilotName;                                                    // char[14]
            rec.TotalScore                          = TotalScore;
            rec.PlayerID                            = PlayerID;
            rec.continuedOrReflownMission           = ContinuedOrReflownMission;
            rec.isHosting                           = IsHosting;
            rec.numHumanPlayersInMission            = NumHumanPlayersInMission;
            rec.frontFlyMode                        = FrontFlyMode;
            rec.unknown0x26                         = Unknown0x26;                                                  // int[80]
            rec.unknown0x166                        = Unknown0x166;                                                 // int[8]
            rec.unknown0x186                        = Unknown0x186;                                                 // int[80]
            rec.lastTeamNumber                      = LastTeamNumber;
            rec.lastSelectedMissionType             = LastSelectedMissionType;
            rec.lastSelectedTraining                = LastSelectedTraining;
            rec.lastSelectedMelee                   = LastSelectedMelee;
            rec.lastSelectedTournament              = LastSelectedTournament;
            rec.lastSelectedCombat                  = LastSelectedCombat;
            rec.lastSelectedBattle                  = LastSelectedBattle;
            rec.GameNameString                      = GameNameString;                                               // int[22]
            rec.unknown0x2F8                        = Unknown0x2F8;                                                 // byte[10]
            rec.GameNameString2                     = GameNameString2;                                              // int[22]
            rec.unknown0x318                        = Unknown0x318;                                                 // int[10]
            rec.lastMissionWasNonSpecific           = LastMissionWasNonSpecific;
            rec.unknown0x326                        = Unknown0x326;
            rec.PromoPoints                         = PromoPoints;
            rec.WorsePromoPoints                    = WorsePromoPoints;
            rec.RankAdjustmentApplied               = RankAdjustmentApplied;
            rec.PercentToNextRank                   = PercentToNextRank;
            rec.totalCategoryScore                  = ToPLTCategoryTypeRecord(TotalCategoryScore);                  // int[3]
            rec.numFlownNonSeries                   = ToPLTCategoryTypeRecord(NumFlownNonSeries);                   // int[3]
            rec.numFlownSeries                      = ToPLTCategoryTypeRecord(NumFlownSeries);                      // int[3]
            rec.totalKillCount                      = ToPLTCategoryTypeRecord(TotalKills);                          // int[3]
            rec.numVanillaFriendlyKills             = ToPLTCategoryTypeRecord(FriendlyKills);                       // int[3]
            rec.totalCraftFullKillsExercise         = TotalFullKillsByCraftExercise;                                // int[88]
            rec.totalCraftFullKillsMelee            = TotalFullKillsByCraftMelee;                                   // int[88]
            rec.totalCraftFullKillsCombat           = TotalFullKillsByCraftCombat;                                  // int[88]
            rec.totalCraftSharedKillsExercise       = TotalSharedKillsByCraftExercise;                              // int[88]
            rec.totalCraftSharedKillsMelee          = TotalSharedKillsByCraftMelee;                                 // int[88]
            rec.totalCraftSharedKillsCombat         = TotalSharedKillsByCraftCombat;                                // int[88]
            rec.totalCraftAssistKillsExercise       = TotalAssistsByCraftExercise;                                  // int[88]
            rec.totalCraftAssistKillsMelee          = TotalAssistsByCraftMelee;                                     // int[88]
            rec.totalCraftAssistKillsCombat         = TotalAssistsByCraftCombat;                                    // int[88]
            rec.TotalFullKillsOnPlayerRank          = ToPLTPlayerRankCountRecord(TotalFullKillsByPlayerRating);     // int[3][25]
            rec.TotalSharedKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(TotalSharedKillsByPlayerRating);   // int[3][25]
            rec.TotalAssistKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(TotalAssistsByPlayerRating);       // int[3][25]
            rec.TotalFullKillsOnAIRank              = ToPLTAIRankCountRecord(TotalFullKillsByAIRank);               // int[3][6]
            rec.TotalSharedKillsOnAIRank            = ToPLTAIRankCountRecord(TotalSharedKillsByAIRank);             // int[3][6]
            rec.TotalAssistKillsOnAIRank            = ToPLTAIRankCountRecord(TotalAssistsByAIRank);                 // int[3][6]
            rec.totalHiddenCargoFound               = ToPLTCategoryTypeRecord(TotalHiddenCargoFound);               // int[3]
            rec.totalLaserHit                       = ToPLTCategoryTypeRecord(TotalLaserHit);                       // int[3]
            rec.totalLaserFiredExercise             = TotalLaserFired.Exercise;
            rec.totalLaserFiredMelee                = TotalLaserFired.Melee;
            rec.totalLaserFiredCombat               = TotalLaserFired.CombatEngagement;
            rec.totalWarheadHitExercise             = TotalWarheadHit.Exercise;
            rec.totalWarheadHitMelee                = TotalWarheadHit.Melee;
            rec.totalWarheadHitCombat               = TotalWarheadHit.CombatEngagement;
            rec.totalWarheadFiredExercise           = TotalWarheadFired.Exercise;
            rec.totalWarheadFiredMelee              = TotalWarheadFired.Melee;
            rec.totalWarheadFiredCombat             = TotalWarheadFired.CombatEngagement;
            rec.totalCraftLossesExercise            = TotalCraftLosses.Exercise;
            rec.totalCraftLossesMelee               = TotalCraftLosses.Melee;
            rec.totalCraftLossesCombat              = TotalCraftLosses.CombatEngagement;
            rec.totalLossesFromCollisionExercise    = TotalLossesFromCollisions.Exercise;
            rec.totalLossesFromCollisionMelee       = TotalLossesFromCollisions.Melee;
            rec.totalLossesFromCollisionCombat      = TotalLossesFromCollisions.CombatEngagement;
            rec.totalLossesFromStarshipsExercise    = TotalLossesFromStarships.Exercise;
            rec.totalLossesFromStarshipsMelee       = TotalLossesFromStarships.Melee;
            rec.totalLossesFromStarshipsCombat      = TotalLossesFromStarships.CombatEngagement;
            rec.totalLossesFromMinesExercise        = TotalLossesFromMines.Exercise;
            rec.totalLossesFromMinesMelee           = TotalLossesFromMines.Melee;
            rec.totalLossesFromMinesCombat          = TotalLossesFromMines.CombatEngagement;
            rec.TotalLossesFromPlayerRank           = ToPLTPlayerRankCountRecord(TotalLossesByPlayerRating);        // int[3][25]
            rec.TotalLossesFromAIRank               = ToPLTAIRankCountRecord(TotalLossesByAIRank);                  // int[3][6]
            rec.unknown0x1612                       = Unknown0x1612;                                                // byte[40]
            rec.unknownPlaqueWon                    = UnknownPlaqueWon;
            rec.TournTeamRecords                    = ToPLTTournTeamRecordArray(TournamentTeamRecord);              // PLTTournTeamRecord[10]  (int[10][5])
            rec.numHumanPlayersUNK                  = NumHumanPlayersUNK;
            rec.numTeamsUNK                         = NumTeamsUNK;
            rec.unknown0x170E                       = Unknown0x170E;
            rec.unknown0x1712                       = Unknown0x1712;
            rec.numCombatFlownInLastBattle          = NumCombatFlownInLastBattle;
            rec.unknown0x171A                       = Unknown0x171A;                                                // byte[2052]
            rec.battleCombatMissionID               = BattleCombatMissionID;                                        // int[4]
            rec.unknown0x1F2E                       = Unknown0x1F2E;                                                // byte[1012]
            rec.totalScoreForCurrentBattleUNK       = TotalScoreForCurrentBattleUNK;
            rec.CurrentRank                         = CurrentRank;
            rec.TotalCountMissionsFlown             = TotalCountMissionsFlown;
            rec.RankAchievedOnMissionCount          = RankAchievedOnMissionCount;                                   // int[25]
            rec.RankString                          = RankString;                                                   // char[32]
            rec.debriefMissionScore                 = DebriefMissionScore;
            rec.debriefFullKillsOnPlayer            = DebriefFullKillsOnPlayer;                                     // int[8]
            rec.debriefSharedKillsOnPlayer          = DebriefSharedKillsOnPlayer;                                   // int[8]
            rec.debriefFullKillsOnFG                = DebriefFullKillsOnFG;                                         // int[48]
            rec.debriefSharedKillsOnFG              = DebriefSharedKillsOnFG;                                       // int[48]
            rec.debriefFullKillsByPlayer            = DebriefFullKillsByPlayer;                                     // int[8]
            rec.debriefSharedKillsByPlayer          = DebriefSharedKillsByPlayer;                                   // int[8]
            rec.debriefFullKillsByFG                = DebriefFullKillsByFG;                                         // int[48]
            rec.debriefSharedKillsByFG              = DebriefSharedKillsByFG;                                       // int[48]
            rec.debriefMeleeAIRankFG                = DebriefMeleeAIRankFG;                                         // int[48]
            rec.UnknownRecord1                      = ToPLTCategoryTypeRecord(UnknownRecord1);                      // int[3]
            rec.UnknownRecord2                      = ToPLTCategoryTypeRecord(UnknownRecord2);                      // int[3]
            rec.UnknownRecord3                      = ToPLTCategoryTypeRecord(UnknownRecord3);                      // int[3]
            rec.debriefEnemyKills                   = ToPLTCategoryTypeRecord(DebriefEnemyKills);                   // int[3]
            rec.debriefFriendlyKills                = ToPLTCategoryTypeRecord(DebriefFriendlyKills);                // int[3]
            rec.debriefFullKillsByShipTypeA         = DebriefFullKillsByShipTypeA;                                  // int[88]
            rec.debriefFullKillsByShipTypeB         = DebriefFullKillsByShipTypeB;                                  // int[88]
            rec.debriefFullKillsByShipTypeC         = DebriefFullKillsByShipTypeC;                                  // int[88]
            rec.debriefSharedKillsByShipTypeA       = DebriefSharedKillsByShipTypeA;                                // int[88]
            rec.debriefSharedKillsByShipTypeB       = DebriefSharedKillsByShipTypeB;                                // int[88]
            rec.debriefSharedKillsByShipTypeC       = DebriefSharedKillsByShipTypeC;                                // int[88]
            rec.debriefAssistKillsByShipTypeA       = DebriefAssistKillsByShipTypeA;                                // int[88]
            rec.debriefAssistKillsByShipTypeB       = DebriefAssistKillsByShipTypeB;                                // int[88]
            rec.debriefAssistKillsByShipTypeC       = DebriefAssistKillsByShipTypeC;                                // int[88]
            rec.debriefFullKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(DebriefFullKillsByPlayerRating);   // int[3][25]
            rec.debriefSharedKillsOnPlayerRank      = ToPLTPlayerRankCountRecord(DebriefSharedKillsByPlayerRating); // int[3][25]
            rec.debriefAssistKillsOnPlayerRank      = ToPLTPlayerRankCountRecord(DebriefAssistByPlayerRating);      // int[3][25]
            rec.debriefFullKillsOnAIRank            = ToPLTAIRankCountRecord(DebriefFullKillsByAIRank);             // int[3][6]
            rec.debriefSharedKillsOnAIRank          = ToPLTAIRankCountRecord(DebriefSharedKillsByAIRank);           // int[3][6]
            rec.debriefAssistKillsOnAIRank          = ToPLTAIRankCountRecord(DebriefAssistsByAIRank);               // int[3][6]
            rec.debriefNumHiddenCargoFound          = ToPLTCategoryTypeRecord(DebriefNumHiddenCargoFound);          // int[3]
            rec.debriefNumCannonHits                = ToPLTCategoryTypeRecord(DebriefNumLaserHit);                  // int[3]
            rec.debriefNumCannonFired               = ToPLTCategoryTypeRecord(DebriefNumLaserFired);                // int[3]
            rec.debriefNumWarheadHits               = ToPLTCategoryTypeRecord(DebriefNumWarheadHit);                // int[3]
            rec.debriefNumWarheadFired              = ToPLTCategoryTypeRecord(DebriefNumWarheadFired);              // int[3]
            rec.debriefNumCraftLosses               = ToPLTCategoryTypeRecord(DebriefNumCraftLosses);               // int[3]
            rec.debriefCraftLossesFromCollision     = ToPLTCategoryTypeRecord(DebriefNumLossesFromCollisions);      // int[3]
            rec.debriefCraftLossesFromStarship      = ToPLTCategoryTypeRecord(DebriefNumLossesFromStarships);       // int[3]
            rec.debriefCraftLossesFromMine          = ToPLTCategoryTypeRecord(DebriefNumLossesFromMines);           // int[3]
            rec.debriefLossesFromPlayerRank         = ToPLTPlayerRankCountRecord(DebriefLossesByPlayerRating);      // int[3][25]
            rec.debriefLossesFromAIRank             = ToPLTAIRankCountRecord(DebriefLossesByAIRank);                // int[3][6]
            rec.connectedPlayerData                 = ToPLTConnectedPlayerDataArray(ConnectedPlayer);               // PLTConnectedPlayerData[8]
            rec.debriefTeamResult                   = ToPLTTeamResultRecordArray(DebriefTeamResult);                // PLTTeamResultRecord[10]  (int[10][6])
            rec.lastSelectedFaction                 = LastSelectedFaction;
            rec.rebelSingleplayerData               = rebelSingleplayerData;
            rec.imperialSingleplayerData            = imperialSingleplayerData;
            rec.rebelMultiplayerData                = rebelMultiplayerData;
            rec.imperialMultiplayerData             = imperialMultiplayerData;

            return rec;
        }

        // Convert helper for TournamentTeamRecord[] -> PLTTournTeamRecord[]
        public static PLTTournTeamRecord[] ToPLTTournTeamRecordArray(TournamentTeamRecord[] tournamentTeamRecord)
        {
            PLTTournTeamRecord[] pltTournTeamRecordArray = new PLTTournTeamRecord[Constants.MAX_TEAMS];
            for (uint idx = 0; idx < 10; ++idx)
            {
                pltTournTeamRecordArray[idx].teamParticipationState = tournamentTeamRecord[idx].TeamParticipationState;
                pltTournTeamRecordArray[idx].totalTeamScore = tournamentTeamRecord[idx].TotalTeamScore;
                pltTournTeamRecordArray[idx].numberOfMeleeRankingsFirst = tournamentTeamRecord[idx].NumberOfMeleeRankingsFirst;
                pltTournTeamRecordArray[idx].numberOfMeleeRankingsSecond = tournamentTeamRecord[idx].NumberOfMeleeRankingsSecond;
                pltTournTeamRecordArray[idx].numberOfMeleeRankingsThird = tournamentTeamRecord[idx].NumberOfMeleeRankingsThird;
            }

            return pltTournTeamRecordArray;
        }
    }

    public class TournamentTeamRecord
    {
        public int TeamParticipationState { get; set; }
        public int TotalTeamScore { get; set; }
        public int NumberOfMeleeRankingsFirst { get; set; }
        public int NumberOfMeleeRankingsSecond { get; set; }
        public int NumberOfMeleeRankingsThird { get; set; }

        public TournamentTeamRecord()
        {
        }

        public TournamentTeamRecord(PLTTournTeamRecord tournamentTeamRecord)
        {
            TeamParticipationState = tournamentTeamRecord.teamParticipationState;
            TotalTeamScore = tournamentTeamRecord.totalTeamScore;
            NumberOfMeleeRankingsFirst = tournamentTeamRecord.numberOfMeleeRankingsFirst;
            NumberOfMeleeRankingsSecond = tournamentTeamRecord.numberOfMeleeRankingsSecond;
            NumberOfMeleeRankingsThird = tournamentTeamRecord.numberOfMeleeRankingsThird;
        }
    }
}
