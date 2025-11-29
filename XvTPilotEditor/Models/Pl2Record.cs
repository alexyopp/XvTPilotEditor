using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.Models
{
    public class Pl2Record : PilotRecordBase
    {
        // TODO: Consider creating directly from filebytes/exporting filebytes, rather than PilotFileSchema objects.

        //  Note the difference in types between the Plt and Pl2 versions; probably can homogenize these in the future
        public uint                         LastSelectedFaction             { get; set; }

        public int                          activeMissionTeam               { get; set; }
        public int                          MissionFolderIndex              { get; set; }
        public int[]                        SelectedIDNumOfMissionCategory  { get; private set; }   = Array.Empty<int>();
        public string                       GameName                        { get; set; }           = string.Empty;
        public string                       LastGameName                    { get; set; }           = string.Empty;
        public int                          isMissionCategorySeries         { get; set; }
        public int                          activeMissionIDNum              { get; set; }
        public int[]                        TotalKillCountByCraftType       { get; private set; }   = Array.Empty<int>();
        public PLTTournamentProgressState   activeTournament                { get; private set; }
        public PLTBattleProgressState       activeBattle                    { get; private set; }
        public PL2DebriefRecord             debrief                         { get; private set; }

        public PL2FactionRecord[]           faction                         { get; private set; }   = Array.Empty<PL2FactionRecord>();
        public PL2CampaignProgressState     activeCampaign                  { get; private set; }
        public sbyte[]                      gap45E1E                        { get; private set; }   = Array.Empty<sbyte>();
        public PLTBattleState[]             spBattleState                   { get; private set; }   = Array.Empty<PLTBattleState>();
        public PLTBattleState[]             mpBattleState                   { get; private set; }   = Array.Empty<PLTBattleState>();
        public PL2CampaignState[]           spCampaignState                 { get; private set; }   = Array.Empty<PL2CampaignState>();
        public PL2CampaignState[]           mpCampaignHostState             { get; private set; }   = Array.Empty<PL2CampaignState>();
        public PL2CampaignState[]           mpCampaignClientState           { get; private set; }   = Array.Empty<PL2CampaignState>();
        public int[]                        anonymous_259                   { get; private set; }   = Array.Empty<int>();
        public ushort                       anonymous_260                   { get; set; }
        public ushort                       anonymous_261                   { get; set; }

        private PL2FileRecord _pl2Data;
        public PL2FileRecord Pl2Data { get => _pl2Data; }

        public Pl2Record()
        {
        }

        public Pl2Record(PL2FileRecord pl2File)
        {
            FillFromPl2(pl2File);
        }

        public void FillFromPl2(PL2FileRecord pl2File)
        {
            _pl2Data = pl2File;

            PilotName                        = pl2File.PilotName ?? string.Empty;
            TotalScore                       = pl2File.TotalScore;
            PlayerID                         = pl2File.PlayerID;
            ContinuedOrReflownMission        = pl2File.continuedOrReflownMission;
            IsHosting                        = pl2File.isHosting;
            NumHumanPlayersInMission         = pl2File.numHumanPlayersInMission;
            FrontFlyMode                     = pl2File.frontFlyMode;
            Unknown0x26                      = pl2File.unknown0x26 ?? Array.Empty<int>();
            Unknown0x166                     = pl2File.unknown0x166 ?? Array.Empty<int>();
            Unknown0x186                     = pl2File.unknown0x186 ?? Array.Empty<int>();
            activeMissionTeam                = pl2File.activeMissionTeam;
            MissionFolderIndex               = pl2File.MissionFolderIndex;
            SelectedIDNumOfMissionCategory   = pl2File.SelectedIDNumOfMissionCategory ?? Array.Empty<int>();
            GameName                         = pl2File.GameName ?? string.Empty;
            LastGameName                     = pl2File.LastGameName ?? string.Empty;
            isMissionCategorySeries          = pl2File.isMissionCategorySeries;
            activeMissionIDNum               = pl2File.activeMissionIDNum;
            PromoPoints                      = pl2File.PromoPoints;
            WorsePromoPoints                 = pl2File.WorsePromoPoints;
            RankAdjustmentApplied            = pl2File.RankAdjustmentApplied;
            PercentToNextRank                = pl2File.PercentToNextRank;
            TotalCategoryScore               = new MissionCategoryRecord(pl2File.totalScoreEMC);
            NumFlownNonSeries                = new MissionCategoryRecord(pl2File.numFlownNonSeriesEMC);
            NumFlownSeries                   = new MissionCategoryRecord(pl2File.numFlownSeriesEMC);
            TotalKills                       = new MissionCategoryRecord(pl2File.totalKillCountEMC);
            FriendlyKills                    = new MissionCategoryRecord(pl2File.totalFriendlyKillCountEMC);
            TotalKillCountByCraftType        = pl2File.TotalKillCountByCraftType ?? Array.Empty<int>();
            TotalFullKillsOnPlayerRating     = new MissionCategoryRecordByPlayerRating(pl2File.TotalFullKillsOnPlayerRank);
            TotalSharedKillsOnPlayerRating   = new MissionCategoryRecordByPlayerRating(pl2File.TotalSharedKillsOnPlayerRank);
            TotalAssistsOnPlayerRating       = new MissionCategoryRecordByPlayerRating(pl2File.TotalAssistKillsOnPlayerRank);
            TotalFullKillsOnAIRank           = new MissionCategoryRecordByAIRating(pl2File.TotalFullKillsOnAIRank);
            TotalSharedKillsOnAIRank         = new MissionCategoryRecordByAIRating(pl2File.TotalSharedKillsOnAIRank);
            TotalAssistsOnAIRank             = new MissionCategoryRecordByAIRating(pl2File.TotalAssistKillsOnAIRank);
            TotalHiddenCargoFound            = new MissionCategoryRecord(pl2File.TotalHiddenCargoFoundEMC);
            TotalLaserHit                    = new MissionCategoryRecord(pl2File.TotalLaserHitEMC);
            TotalLaserFired                  = new MissionCategoryRecord(pl2File.TotalLaserFiredEMC);
            TotalWarheadHit                  = new MissionCategoryRecord(pl2File.TotalWarheadHitEMC);
            TotalWarheadFired                = new MissionCategoryRecord(pl2File.TotalWarheadFiredEMC);
            TotalCraftLosses                 = new MissionCategoryRecord(pl2File.TotalCraftLossesEMC);
            TotalLossesFromCollisions        = new MissionCategoryRecord(pl2File.TotalLossesFromCollisionEMC);
            TotalLossesFromStarships         = new MissionCategoryRecord(pl2File.TotalLossesFromStarshipsEMC);
            TotalLossesFromMines             = new MissionCategoryRecord(pl2File.TotalLossesFromMinesEMC);
            TotalLossesFromPlayerRank        = new MissionCategoryRecordByPlayerRating(pl2File.TotalLossesFromPlayerRank);
            TotalLossesFromAIRank            = new MissionCategoryRecordByAIRating(pl2File.TotalLossesFromAIRank);
            activeTournament                 = pl2File.activeTournament;
            activeBattle                     = pl2File.activeBattle;
            CurrentRank                      = pl2File.CurrentRank;
            TotalCountMissionsFlown          = pl2File.TotalCountMissionsFlown;
            RankAchievedOnMissionCount       = pl2File.RankAchievedOnMissionCount ?? Array.Empty<int>();
            RankString                       = pl2File.RankString ?? string.Empty;
            DebriefMissionScore              = pl2File.debriefMissionScore;
            DebriefFullKillsOnPlayer         = pl2File.debriefFullKillsOnPlayer ?? Array.Empty<int>();
            DebriefSharedKillsOnPlayer       = pl2File.debriefSharedKillsOnPlayer ?? Array.Empty<int>();
            DebriefFullKillsOnFG             = pl2File.debriefFullKillsOnFG ?? Array.Empty<int>();
            DebriefSharedKillsOnFG           = pl2File.debriefSharedKillsOnFG ?? Array.Empty<int>();
            DebriefFullKillsByPlayer         = pl2File.debriefFullKillsByPlayer ?? Array.Empty<int>();
            DebriefSharedKillsByPlayer       = pl2File.debriefSharedKillsByPlayer ?? Array.Empty<int>();
            DebriefFullKillsByFG             = pl2File.debriefFullKillsByFG ?? Array.Empty<int>();
            DebriefSharedKillsByFG           = pl2File.debriefSharedKillsByFG ?? Array.Empty<int>();
            DebriefMeleeAIRankFG             = pl2File.debriefMeleeAIRankFG ?? Array.Empty<int>();
            debrief                          = pl2File.debrief;

            ConnectedPlayer = new ConnectedPlayerRecord[Constants.MAX_CONNECTED_PLAYERS];
            for (uint idx = 0; idx < Constants.MAX_CONNECTED_PLAYERS; ++idx)
            {
                ConnectedPlayer[idx] = new ConnectedPlayerRecord(pl2File.connectedPlayerData[idx]);
            }

            DebriefTeamResult = new TeamResultRecord[10]; // TODO: Why 10?  I mean, that's what's defined in the file, but what is the in-game significance?
            for (uint idx = 0; idx < 10; ++idx)
            {
                DebriefTeamResult[idx] = new TeamResultRecord(pl2File.debriefTeamResult[idx]);
            }

            LastSelectedFaction              = pl2File.SelectedFaction;
            faction                          = pl2File.faction ?? Array.Empty<PL2FactionRecord>();
            activeCampaign                   = pl2File.activeCampaign;
            gap45E1E                         = pl2File.gap45E1E ?? Array.Empty<sbyte>();
            spBattleState                    = pl2File.spBattleState ?? Array.Empty<PLTBattleState>();
            mpBattleState                    = pl2File.mpBattleState ?? Array.Empty<PLTBattleState>();
            spCampaignState                  = pl2File.spCampaignState ?? Array.Empty<PL2CampaignState>();
            mpCampaignHostState              = pl2File.mpCampaignHostState ?? Array.Empty<PL2CampaignState>();
            mpCampaignClientState            = pl2File.mpCampaignClientState ?? Array.Empty<PL2CampaignState>();
            anonymous_259                    = pl2File.anonymous_259 ?? Array.Empty<int>();
            anonymous_260                    = pl2File.anonymous_260;
            anonymous_261                    = pl2File.anonymous_261;
        }

        /// <summary>
        /// Create a PL2FileRecord populated from this PilotRecord (PL2 fields).
        /// Only fields that are present on PilotRecord are set; other fields remain default.
        /// </summary>
        public PL2FileRecord ToPl2FileRecord()
        {
            var rec = new PL2FileRecord();

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
            rec.activeMissionTeam                   = activeMissionTeam;
            rec.MissionFolderIndex                  = MissionFolderIndex;
            rec.SelectedIDNumOfMissionCategory      = SelectedIDNumOfMissionCategory;                               // int[6]
            rec.GameName                            = GameName;                                                     // char[32]
            rec.LastGameName                        = LastGameName;                                                 // char[32]
            rec.isMissionCategorySeries             = isMissionCategorySeries;
            rec.activeMissionIDNum                  = activeMissionIDNum;
            rec.PromoPoints                         = PromoPoints;
            rec.WorsePromoPoints                    = WorsePromoPoints;
            rec.RankAdjustmentApplied               = RankAdjustmentApplied;
            rec.PercentToNextRank                   = PercentToNextRank;
            rec.totalScoreEMC                       = ToIntArray(TotalCategoryScore);                               // int[3]
            rec.numFlownNonSeriesEMC                = ToIntArray(NumFlownNonSeries);                                // int[3]
            rec.numFlownSeriesEMC                   = ToIntArray(NumFlownSeries);                                   // int[3]
            rec.totalKillCountEMC                   = ToIntArray(TotalKills);                                       // int[3]
            rec.totalFriendlyKillCountEMC           = ToIntArray(FriendlyKills);                                    // int[3]
            rec.TotalKillCountByCraftType           = TotalKillCountByCraftType;                                    // int[900]
            rec.TotalFullKillsOnPlayerRank          = ToPLTPlayerRankCountRecord(TotalFullKillsOnPlayerRating);     // int[3][25]
            rec.TotalSharedKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(TotalSharedKillsOnPlayerRating);   // int[3][25]
            rec.TotalAssistKillsOnPlayerRank        = ToPLTPlayerRankCountRecord(TotalAssistsOnPlayerRating);       // int[3][25]
            rec.TotalFullKillsOnAIRank              = ToPLTAIRankCountRecord(TotalFullKillsOnAIRank);               // int[3][6]
            rec.TotalSharedKillsOnAIRank            = ToPLTAIRankCountRecord(TotalSharedKillsOnAIRank);             // int[3][6]
            rec.TotalAssistKillsOnAIRank            = ToPLTAIRankCountRecord(TotalAssistsOnAIRank);                 // int[3][6]
            rec.TotalHiddenCargoFoundEMC            = ToIntArray(TotalHiddenCargoFound);                            // int[3]
            rec.TotalLaserHitEMC                    = ToIntArray(TotalLaserHit);                                    // int[3]
            rec.TotalLaserFiredEMC                  = ToIntArray(TotalLaserFired);                                  // int[3]
            rec.TotalWarheadHitEMC                  = ToIntArray(TotalWarheadHit);                                  // int[3]
            rec.TotalWarheadFiredEMC                = ToIntArray(TotalWarheadFired);                                // int[3]
            rec.TotalCraftLossesEMC                 = ToIntArray(TotalCraftLosses);                                 // int[3]
            rec.TotalLossesFromCollisionEMC         = ToIntArray(TotalLossesFromCollisions);                        // int[3]
            rec.TotalLossesFromStarshipsEMC         = ToIntArray(TotalLossesFromStarships);                         // int[3]
            rec.TotalLossesFromMinesEMC             = ToIntArray(TotalLossesFromMines);                             // int[3]
            rec.TotalLossesFromPlayerRank           = ToPLTPlayerRankCountRecord(TotalLossesFromPlayerRank);        // int[3][25]
            rec.TotalLossesFromAIRank               = ToPLTAIRankCountRecord(TotalLossesFromAIRank);                // int[3][6]
            rec.activeTournament                    = activeTournament;
            rec.activeBattle                        = activeBattle;
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
            rec.debrief                             = debrief;
            rec.connectedPlayerData                 = ToPLTConnectedPlayerDataArray(ConnectedPlayer);               // PLTConnectedPlayerData[8]
            rec.debriefTeamResult                   = ToPLTTeamResultRecordArray(DebriefTeamResult);                // PLTTeamResultRecord[10]  (int[10][6])
            rec.SelectedFaction                     = LastSelectedFaction;
            rec.faction                             = faction;
            rec.activeCampaign                      = activeCampaign;
            rec.gap45E1E                            = gap45E1E;                                                     // sbyte[4]
            rec.spBattleState                       = spBattleState;
            rec.mpBattleState                       = mpBattleState;
            rec.spCampaignState                     = spCampaignState;
            rec.mpCampaignHostState                 = mpCampaignHostState;
            rec.mpCampaignClientState               = mpCampaignClientState;
            rec.anonymous_259                       = anonymous_259;
            rec.anonymous_260                       = anonymous_260;
            rec.anonymous_261                       = anonymous_261;

            return rec;
        }
    }
}
