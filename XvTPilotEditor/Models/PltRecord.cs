using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.Models
{
    public class PltRecord : PilotRecordBase
    {
        // TODO: Consider creating directly from filebytes/exporting filebytes, rather than PilotFileSchema objects.

        //  Note the difference in types between the Plt and Pl2 versions; probably can homogenize these in the future
        public int                      LastSelectedFaction { get; set; }

        public int                      lastTeamNumber                  { get; set; }
        public int                      lastSelectedMissionType         { get; set; }
        public int                      lastSelectedTraining            { get; set; }
        public int                      lastSelectedMelee               { get; set; }
        public int                      lastSelectedTournament          { get; set; }
        public int                      lastSelectedCombat              { get; set; }
        public int                      lastSelectedBattle              { get; set; }
        public string                   GameNameString                  { get; set; }           = string.Empty;
        public byte[]                   unknown0x2F8                    { get; private set; }   = Array.Empty<byte>();
        public string                   GameNameString2                 { get; set; }           = string.Empty;
        public byte[]                   unknown0x318                    { get; private set; }   = Array.Empty<byte>();
        public int                      lastMissionWasNonSpecific       { get; set; }
        public int                      unknown0x326                    { get; set; }
        public int[]                    totalCraftFullKillsExercise     { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftFullKillsMelee        { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftFullKillsCombat       { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftSharedKillsExercise   { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftSharedKillsMelee      { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftSharedKillsCombat     { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftAssistKillsExercise   { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftAssistKillsMelee      { get; private set; }   = Array.Empty<int>();
        public int[]                    totalCraftAssistKillsCombat     { get; private set; }   = Array.Empty<int>();
        public byte[]                   unknown0x1612                   { get; private set; }   = Array.Empty<byte>();
        public int                      unknownPlaqueWon                { get; set; }
        public PLTTournTeamRecord[]     TournTeamRecords                { get; private set; }   = Array.Empty<PLTTournTeamRecord>();
        public int                      numHumanPlayersUNK              { get; set; }
        public int                      numTeamsUNK                     { get; set; }
        public int                      unknown0x170E                   { get; set; }
        public int                      unknown0x1712                   { get; set; }
        public int                      numCombatFlownInLastBattle      { get; set; }
        public byte[]                   unknown0x171A                   { get; private set; }   = Array.Empty<byte>();
        public int[]                    battleCombatMissionID           { get; private set; }   = Array.Empty<int>();
        public byte[]                   unknown0x1F2E                   { get; private set; }   = Array.Empty<byte>();
        public int                      totalScoreForCurrentBattleUNK   { get; set; }
        public PLTCategoryTypeRecord    UnknownRecord1                  { get; private set; }
        public PLTCategoryTypeRecord    UnknownRecord2                  { get; private set; }
        public PLTCategoryTypeRecord    UnknownRecord3                  { get; private set; }
        public PLTCategoryTypeRecord    debriefEnemyKills               { get; private set; }
        public PLTCategoryTypeRecord    debriefFriendlyKills            { get; private set; }
        public int[]                    debriefFullKillsByShipTypeA     { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefFullKillsByShipTypeB     { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefFullKillsByShipTypeC     { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefSharedKillsByShipTypeA   { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefSharedKillsByShipTypeB   { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefSharedKillsByShipTypeC   { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefAssistKillsByShipTypeA   { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefAssistKillsByShipTypeB   { get; private set; }   = Array.Empty<int>();
        public int[]                    debriefAssistKillsByShipTypeC   { get; private set; }   = Array.Empty<int>();
        public PLTPlayerRankCountRecord debriefFullKillsOnPlayerRank    { get; private set; }
        public PLTPlayerRankCountRecord debriefSharedKillsOnPlayerRank  { get; private set; }
        public PLTPlayerRankCountRecord debriefAssistKillsOnPlayerRank  { get; private set; }
        public PLTAIRankCountRecord     debriefFullKillsOnAIRank        { get; private set; }
        public PLTAIRankCountRecord     debriefSharedKillsOnAIRank      { get; private set; }
        public PLTAIRankCountRecord     debriefAssistKillsOnAIRank      { get; private set; }
        public PLTCategoryTypeRecord    debriefNumHiddenCargoFound      { get; private set; }
        public PLTCategoryTypeRecord    debriefNumCannonHits            { get; private set; }
        public PLTCategoryTypeRecord    debriefNumCannonFired           { get; private set; }
        public PLTCategoryTypeRecord    debriefNumWarheadHits           { get; private set; }
        public PLTCategoryTypeRecord    debriefNumWarheadFired          { get; private set; }
        public PLTCategoryTypeRecord    debriefNumCraftLosses           { get; private set; }
        public PLTCategoryTypeRecord    debriefCraftLossesFromCollision { get; private set; }
        public PLTCategoryTypeRecord    debriefCraftLossesFromStarship  { get; private set; }
        public PLTCategoryTypeRecord    debriefCraftLossesFromMine      { get; private set; }
        public PLTPlayerRankCountRecord debriefLossesFromPlayerRank     { get; private set; }
        public PLTAIRankCountRecord     debriefLossesFromAIRank         { get; private set; }

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
            lastTeamNumber                      = pltFile.lastTeamNumber;
            lastSelectedMissionType             = pltFile.lastSelectedMissionType;
            lastSelectedTraining                = pltFile.lastSelectedTraining;
            lastSelectedMelee                   = pltFile.lastSelectedMelee;
            lastSelectedTournament              = pltFile.lastSelectedTournament;
            lastSelectedCombat                  = pltFile.lastSelectedCombat;
            lastSelectedBattle                  = pltFile.lastSelectedBattle;
            GameNameString                      = pltFile.GameNameString ?? string.Empty;
            unknown0x2F8                        = pltFile.unknown0x2F8 ?? Array.Empty<byte>();
            GameNameString2                     = pltFile.GameNameString2 ?? string.Empty;
            unknown0x318                        = pltFile.unknown0x318 ?? Array.Empty<byte>();
            lastMissionWasNonSpecific           = pltFile.lastMissionWasNonSpecific;
            unknown0x326                        = pltFile.unknown0x326;
            PromoPoints                         = pltFile.PromoPoints;
            WorsePromoPoints                    = pltFile.WorsePromoPoints;
            RankAdjustmentApplied               = pltFile.RankAdjustmentApplied;
            PercentToNextRank                   = pltFile.PercentToNextRank;
            TotalCategoryScore                  = new MissionCategoryRecord(pltFile.totalCategoryScore);
            NumFlownNonSeries                   = new MissionCategoryRecord(pltFile.numFlownNonSeries);
            NumFlownSeries                      = new MissionCategoryRecord(pltFile.numFlownSeries);
            TotalKills                          = new MissionCategoryRecord(pltFile.totalKillCount);
            FriendlyKills                       = new MissionCategoryRecord(pltFile.numVanillaFriendlyKills);
            totalCraftFullKillsExercise         = pltFile.totalCraftFullKillsExercise ?? Array.Empty<int>();
            totalCraftFullKillsMelee            = pltFile.totalCraftFullKillsMelee ?? Array.Empty<int>();
            totalCraftFullKillsCombat           = pltFile.totalCraftFullKillsCombat ?? Array.Empty<int>();
            totalCraftSharedKillsExercise       = pltFile.totalCraftSharedKillsExercise ?? Array.Empty<int>();
            totalCraftSharedKillsMelee          = pltFile.totalCraftSharedKillsMelee ?? Array.Empty<int>();
            totalCraftSharedKillsCombat         = pltFile.totalCraftSharedKillsCombat ?? Array.Empty<int>();
            totalCraftAssistKillsExercise       = pltFile.totalCraftAssistKillsExercise ?? Array.Empty<int>();
            totalCraftAssistKillsMelee          = pltFile.totalCraftAssistKillsMelee ?? Array.Empty<int>();
            totalCraftAssistKillsCombat         = pltFile.totalCraftAssistKillsCombat ?? Array.Empty<int>();
            TotalFullKillsOnPlayerRating        = new MissionCategoryRecordByPlayerRating(pltFile.TotalFullKillsOnPlayerRank);
            TotalSharedKillsOnPlayerRating      = new MissionCategoryRecordByPlayerRating(pltFile.TotalSharedKillsOnPlayerRank);
            TotalAssistsOnPlayerRating          = new MissionCategoryRecordByPlayerRating(pltFile.TotalAssistKillsOnPlayerRank);
            TotalFullKillsOnAIRank              = new MissionCategoryRecordByAIRating(pltFile.TotalFullKillsOnAIRank);
            TotalSharedKillsOnAIRank            = new MissionCategoryRecordByAIRating(pltFile.TotalSharedKillsOnAIRank);
            TotalAssistsOnAIRank                = new MissionCategoryRecordByAIRating(pltFile.TotalAssistKillsOnAIRank);
            TotalHiddenCargoFound               = new MissionCategoryRecord(pltFile.totalHiddenCargoFound);
            TotalLaserHit                       = new MissionCategoryRecord(pltFile.totalLaserHit);
            TotalLaserFired                     = new MissionCategoryRecord(pltFile.totalLaserFiredExercise, pltFile.totalLaserFiredMelee, pltFile.totalLaserFiredCombat);
            TotalWarheadHit                     = new MissionCategoryRecord(pltFile.totalWarheadHitExercise, pltFile.totalWarheadHitMelee, pltFile.totalWarheadHitCombat);
            TotalWarheadFired                   = new MissionCategoryRecord(pltFile.totalWarheadFiredExercise, pltFile.totalWarheadFiredMelee, pltFile.totalWarheadFiredCombat);
            TotalCraftLosses                    = new MissionCategoryRecord(pltFile.totalCraftLossesExercise, pltFile.totalCraftLossesMelee, pltFile.totalCraftLossesCombat);
            TotalLossesFromCollisions           = new MissionCategoryRecord(pltFile.totalLossesFromCollisionExercise, pltFile.totalLossesFromCollisionMelee, pltFile.totalLossesFromCollisionCombat);
            TotalLossesFromStarships            = new MissionCategoryRecord(pltFile.totalLossesFromStarshipsExercise, pltFile.totalLossesFromStarshipsMelee, pltFile.totalLossesFromStarshipsCombat);
            TotalLossesFromMines                = new MissionCategoryRecord(pltFile.totalLossesFromMinesExercise, pltFile.totalLossesFromMinesMelee, pltFile.totalLossesFromMinesCombat);
            TotalLossesFromPlayerRank           = new MissionCategoryRecordByPlayerRating(pltFile.TotalLossesFromPlayerRank);
            TotalLossesFromAIRank               = new MissionCategoryRecordByAIRating(pltFile.TotalLossesFromAIRank);
            unknown0x1612                       = pltFile.unknown0x1612 ?? Array.Empty<byte>();
            unknownPlaqueWon                    = pltFile.unknownPlaqueWon;
            TournTeamRecords                    = pltFile.TournTeamRecords ?? Array.Empty<PLTTournTeamRecord>();
            numHumanPlayersUNK                  = pltFile.numHumanPlayersUNK;
            numTeamsUNK                         = pltFile.numTeamsUNK;
            unknown0x170E                       = pltFile.unknown0x170E;
            unknown0x1712                       = pltFile.unknown0x1712;
            numCombatFlownInLastBattle          = pltFile.numCombatFlownInLastBattle;
            unknown0x171A                       = pltFile.unknown0x171A ?? Array.Empty<byte>();
            battleCombatMissionID               = pltFile.battleCombatMissionID ?? Array.Empty<int>();
            unknown0x1F2E                       = pltFile.unknown0x1F2E ?? Array.Empty<byte>();
            totalScoreForCurrentBattleUNK       = pltFile.totalScoreForCurrentBattleUNK;
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
            UnknownRecord1                      = pltFile.UnknownRecord1;
            UnknownRecord2                      = pltFile.UnknownRecord2;
            UnknownRecord3                      = pltFile.UnknownRecord3;
            debriefEnemyKills                   = pltFile.debriefEnemyKills;
            debriefFriendlyKills                = pltFile.debriefFriendlyKills;
            debriefFullKillsByShipTypeA         = pltFile.debriefFullKillsByShipTypeA ?? Array.Empty<int>();
            debriefFullKillsByShipTypeB         = pltFile.debriefFullKillsByShipTypeB ?? Array.Empty<int>();
            debriefFullKillsByShipTypeC         = pltFile.debriefFullKillsByShipTypeC ?? Array.Empty<int>();
            debriefSharedKillsByShipTypeA       = pltFile.debriefSharedKillsByShipTypeA ?? Array.Empty<int>();
            debriefSharedKillsByShipTypeB       = pltFile.debriefSharedKillsByShipTypeB ?? Array.Empty<int>();
            debriefSharedKillsByShipTypeC       = pltFile.debriefSharedKillsByShipTypeC ?? Array.Empty<int>();
            debriefAssistKillsByShipTypeA       = pltFile.debriefAssistKillsByShipTypeA ?? Array.Empty<int>();
            debriefAssistKillsByShipTypeB       = pltFile.debriefAssistKillsByShipTypeB ?? Array.Empty<int>();
            debriefAssistKillsByShipTypeC       = pltFile.debriefAssistKillsByShipTypeC ?? Array.Empty<int>();
            debriefFullKillsOnPlayerRank        = pltFile.debriefFullKillsOnPlayerRank;
            debriefSharedKillsOnPlayerRank      = pltFile.debriefSharedKillsOnPlayerRank;
            debriefAssistKillsOnPlayerRank      = pltFile.debriefAssistKillsOnPlayerRank;
            debriefFullKillsOnAIRank            = pltFile.debriefFullKillsOnAIRank;
            debriefSharedKillsOnAIRank          = pltFile.debriefSharedKillsOnAIRank;
            debriefAssistKillsOnAIRank          = pltFile.debriefAssistKillsOnAIRank;
            debriefNumHiddenCargoFound          = pltFile.debriefNumHiddenCargoFound;
            debriefNumCannonHits                = pltFile.debriefNumCannonHits;
            debriefNumCannonFired               = pltFile.debriefNumCannonFired;
            debriefNumWarheadHits               = pltFile.debriefNumWarheadHits;
            debriefNumWarheadFired              = pltFile.debriefNumWarheadFired;
            debriefNumCraftLosses               = pltFile.debriefNumCraftLosses;
            debriefCraftLossesFromCollision     = pltFile.debriefCraftLossesFromCollision;
            debriefCraftLossesFromStarship      = pltFile.debriefCraftLossesFromStarship;
            debriefCraftLossesFromMine          = pltFile.debriefCraftLossesFromMine;
            debriefLossesFromPlayerRank         = pltFile.debriefLossesFromPlayerRank;
            debriefLossesFromAIRank             = pltFile.debriefLossesFromAIRank;

            ConnectedPlayer = new ConnectedPlayerRecord[Constants.MAX_CONNECTED_PLAYERS];
            for (uint idx = 0; idx < Constants.MAX_CONNECTED_PLAYERS; ++idx)
            {
                ConnectedPlayer[idx] = new ConnectedPlayerRecord(pltFile.connectedPlayerData[idx]);
            }

            DebriefTeamResult = new TeamResultRecord[10]; // TODO: Why 10?  I mean, that's what's defined in the file, but what is the in-game significance?
            for (uint idx = 0; idx < 10; ++idx)
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
            rec.unknown0x26                         = Unknown0x26;                                                  // int[10]
            rec.unknown0x166                        = Unknown0x166;                                                 // int[10]
            rec.unknown0x186                        = Unknown0x186;                                                 // int[10]
            rec.lastTeamNumber                      = lastTeamNumber;
            rec.lastSelectedMissionType             = lastSelectedMissionType;
            rec.lastSelectedTraining                = lastSelectedTraining;
            rec.lastSelectedMelee                   = lastSelectedMelee;
            rec.lastSelectedTournament              = lastSelectedTournament;
            rec.lastSelectedCombat                  = lastSelectedCombat;
            rec.lastSelectedBattle                  = lastSelectedBattle;
            rec.GameNameString                      = GameNameString;                                               // int[22]
            rec.unknown0x2F8                        = unknown0x2F8;                                                 // int[10]
            rec.GameNameString2                     = GameNameString2;                                              // int[22]
            rec.unknown0x318                        = unknown0x318;                                                 // int[10]
            rec.lastMissionWasNonSpecific           = lastMissionWasNonSpecific;
            rec.unknown0x326                        = unknown0x326;
            rec.PromoPoints                         = PromoPoints;
            rec.WorsePromoPoints                    = WorsePromoPoints;
            rec.RankAdjustmentApplied               = RankAdjustmentApplied;
            rec.PercentToNextRank                   = PercentToNextRank;
            rec.totalCategoryScore                  = ToPLTCategoryTypeRecord(TotalCategoryScore);                  // int[3]
            rec.numFlownNonSeries                   = ToPLTCategoryTypeRecord(NumFlownNonSeries);                   // int[3]
            rec.numFlownSeries                      = ToPLTCategoryTypeRecord(NumFlownSeries);                      // int[3]
            rec.totalKillCount                      = ToPLTCategoryTypeRecord(TotalKills);                          // int[3]
            rec.numVanillaFriendlyKills             = ToPLTCategoryTypeRecord(FriendlyKills);                       // int[3]
            rec.totalCraftFullKillsExercise         = totalCraftFullKillsExercise;                                  // int[88]
            rec.totalCraftFullKillsMelee            = totalCraftFullKillsMelee;                                     // int[88]
            rec.totalCraftFullKillsCombat           = totalCraftFullKillsCombat;                                    // int[88]
            rec.totalCraftSharedKillsExercise       = totalCraftSharedKillsExercise;                                // int[88]
            rec.totalCraftSharedKillsMelee          = totalCraftSharedKillsMelee;                                   // int[88]
            rec.totalCraftSharedKillsCombat         = totalCraftSharedKillsCombat;                                  // int[88]
            rec.totalCraftAssistKillsExercise       = totalCraftAssistKillsExercise;                                // int[88]
            rec.totalCraftAssistKillsMelee          = totalCraftAssistKillsMelee;                                   // int[88]
            rec.totalCraftAssistKillsCombat         = totalCraftAssistKillsCombat;                                  // int[88]
            rec.TotalFullKillsOnPlayerRank          = ToPLTPlayerRankCountRecord(TotalFullKillsOnPlayerRating);     // int[3][25]
            rec.TotalSharedKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(TotalSharedKillsOnPlayerRating);   // int[3][25]
            rec.TotalAssistKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(TotalAssistsOnPlayerRating);       // int[3][25]
            rec.TotalFullKillsOnAIRank              = ToPLTAIRankCountRecord(TotalFullKillsOnAIRank);               // int[3][6]
            rec.TotalSharedKillsOnAIRank            = ToPLTAIRankCountRecord(TotalSharedKillsOnAIRank);             // int[3][6]
            rec.TotalAssistKillsOnAIRank            = ToPLTAIRankCountRecord(TotalAssistsOnAIRank);                 // int[3][6]
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
            rec.TotalLossesFromPlayerRank           = ToPLTPlayerRankCountRecord(TotalLossesFromPlayerRank);        // int[3][25]
            rec.TotalLossesFromAIRank               = ToPLTAIRankCountRecord(TotalLossesFromAIRank);                // int[3][6]
            rec.unknown0x1612                       = unknown0x1612;                                                // byte[40]
            rec.unknownPlaqueWon                    = unknownPlaqueWon;
            rec.TournTeamRecords                    = TournTeamRecords;                                             // int[10][5]
            rec.numHumanPlayersUNK                  = numHumanPlayersUNK;
            rec.numTeamsUNK                         = numTeamsUNK;
            rec.unknown0x170E                       = unknown0x170E;
            rec.unknown0x1712                       = unknown0x1712;
            rec.numCombatFlownInLastBattle          = numCombatFlownInLastBattle;
            rec.unknown0x171A                       = unknown0x171A;                                                // byte[2052]
            rec.battleCombatMissionID               = battleCombatMissionID;                                        // int[4]
            rec.unknown0x1F2E                       = unknown0x1F2E;                                                // byte[1012]
            rec.totalScoreForCurrentBattleUNK       = totalScoreForCurrentBattleUNK;
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
            rec.UnknownRecord1                      = UnknownRecord1;                                               // int[3]
            rec.UnknownRecord2                      = UnknownRecord2;                                               // int[3]
            rec.UnknownRecord3                      = UnknownRecord3;                                               // int[3]
            rec.debriefEnemyKills                   = debriefEnemyKills;                                            // int[3]
            rec.debriefFriendlyKills                = debriefFriendlyKills;                                         // int[3]
            rec.debriefFullKillsByShipTypeA         = debriefFullKillsByShipTypeA;                                  // int[88]
            rec.debriefFullKillsByShipTypeB         = debriefFullKillsByShipTypeB;                                  // int[88]
            rec.debriefFullKillsByShipTypeC         = debriefFullKillsByShipTypeC;                                  // int[88]
            rec.debriefSharedKillsByShipTypeA       = debriefSharedKillsByShipTypeA;                                // int[88]
            rec.debriefSharedKillsByShipTypeB       = debriefSharedKillsByShipTypeB;                                // int[88]
            rec.debriefSharedKillsByShipTypeC       = debriefSharedKillsByShipTypeC;                                // int[88]
            rec.debriefAssistKillsByShipTypeA       = debriefAssistKillsByShipTypeA;                                // int[88]
            rec.debriefAssistKillsByShipTypeB       = debriefAssistKillsByShipTypeB;                                // int[88]
            rec.debriefAssistKillsByShipTypeC       = debriefAssistKillsByShipTypeC;                                // int[88]
            rec.debriefFullKillsOnPlayerRank        = debriefFullKillsOnPlayerRank;                                 // int[3][25]
            rec.debriefSharedKillsOnPlayerRank      = debriefSharedKillsOnPlayerRank;                               // int[3][25]
            rec.debriefAssistKillsOnPlayerRank      = debriefAssistKillsOnPlayerRank;                               // int[3][25]
            rec.debriefFullKillsOnAIRank            = debriefFullKillsOnAIRank;                                     // int[3][6]
            rec.debriefSharedKillsOnAIRank          = debriefSharedKillsOnAIRank;                                   // int[3][6]
            rec.debriefAssistKillsOnAIRank          = debriefAssistKillsOnAIRank;                                   // int[3][6]
            rec.debriefNumHiddenCargoFound          = debriefNumHiddenCargoFound;                                   // int[3]
            rec.debriefNumCannonHits                = debriefNumCannonHits;                                         // int[3]
            rec.debriefNumCannonFired               = debriefNumCannonFired;                                        // int[3]
            rec.debriefNumWarheadHits               = debriefNumWarheadHits;                                        // int[3]
            rec.debriefNumWarheadFired              = debriefNumWarheadFired;                                       // int[3]
            rec.debriefNumCraftLosses               = debriefNumCraftLosses;                                        // int[3]
            rec.debriefCraftLossesFromCollision     = debriefCraftLossesFromCollision;                              // int[3]
            rec.debriefCraftLossesFromStarship      = debriefCraftLossesFromStarship;                               // int[3]
            rec.debriefCraftLossesFromMine          = debriefCraftLossesFromMine;                                   // int[3]
            rec.debriefLossesFromPlayerRank         = debriefLossesFromPlayerRank;                                  // int[3][25]
            rec.debriefLossesFromAIRank             = debriefLossesFromAIRank;                                      // int[3][6]
            rec.connectedPlayerData                 = ToPLTConnectedPlayerDataArray(ConnectedPlayer);               // PLTConnectedPlayerData[8]
            rec.debriefTeamResult                   = ToPLTTeamResultRecordArray(DebriefTeamResult);                // PLTTeamResultRecord[10]  (int[10][6])
            rec.lastSelectedFaction                 = LastSelectedFaction;
            rec.rebelSingleplayerData               = rebelSingleplayerData;
            rec.imperialSingleplayerData            = imperialSingleplayerData;
            rec.rebelMultiplayerData                = rebelMultiplayerData;
            rec.imperialMultiplayerData             = imperialMultiplayerData;

            return rec;
        }
    }
}
