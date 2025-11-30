using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using XvTPilotEditor.Models;
using XvTPilotEditor.Views;

namespace XvTPilotEditor.ViewModels
{
    public class CombinedPilotRecordPageViewModel : ViewModelBase
    {
        private bool _suppressFieldValueChange;

        public string PltPilotName
        {
            get => pltRecord.PilotName;
            set
            {
                if (value.Length > Constants.PILOT_NAME_MAX_LENGTH)
                {
                    MessageBox.Show("Pilot name must be no more than " + Constants.PILOT_NAME_MAX_LENGTH + " characters long.", "Invalid Pilot Name");
                    return;
                }

                pltRecord.PilotName = value;
                OnPropertyChanged(nameof(PltPilotName));
            }
        }
        public string Pl2PilotName
        {
            get => pl2Record.PilotName;
            set
            {
                if (value.Length > Constants.PILOT_NAME_MAX_LENGTH)
                {
                    MessageBox.Show("Pilot name must be no more than " + Constants.PILOT_NAME_MAX_LENGTH + " characters long.", "Invalid Pilot Name");
                    return;
                }

                pl2Record.PilotName = value;
                OnPropertyChanged(nameof(Pl2PilotName));
            }
        }

        public string PltTotalScore
        {
            get => pltRecord.TotalScore.ToString();
            set
            {
                int totalScore;
                if (int.TryParse(value, out totalScore))
                {
                    pltRecord.TotalScore = totalScore;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Pl2TotalScore
        {
            get => pl2Record.TotalScore.ToString();
            set
            {
                int totalScore;
                if (int.TryParse(value, out totalScore))
                {
                    pl2Record.TotalScore = totalScore;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public uint PltPlayerID { get; private set; }
        public uint Pl2PlayerID { get; private set; }

        public int PltContinuedOrReflownMission { get; private set; }
        public int Pl2ContinuedOrReflownMission { get; private set; }

        public int PltIsHosting { get; private set; }
        public int Pl2IsHosting { get; private set; }

        public int PltNumHumanPlayersInMission { get; private set; }
        public int Pl2NumHumanPlayersInMission { get; private set; }

        public int PltFrontFlyMode { get; private set; }
        public int Pl2FrontFlyMode { get; private set; }

        public int[] PltUnknown0x26 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x26 { get; private set; } = Array.Empty<int>();

        public int[] PltUnknown0x166 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x166 { get; private set; } = Array.Empty<int>();

        public int[] PltUnknown0x186 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x186 { get; private set; } = Array.Empty<int>();

        //...

        public int PltPromoPoints { get; private set; }
        public int Pl2PromoPoints { get; private set; }

        public int PltWorsePromoPoints { get; private set; }
        public int Pl2WorsePromoPoints { get; private set; }

        public int PltRankAdjustmentApplied { get; private set; }
        public int Pl2RankAdjustmentApplied { get; private set; }

        public int PltPercentToNextRank { get; private set; }
        public int Pl2PercentToNextRank { get; private set; }

        public MissionCategoryRecord PltTotalCategoryScore { get; private set; }
        public MissionCategoryRecord Pl2TotalCategoryScore { get; private set; }

        public MissionCategoryRecord PltNumFlownNonSeries { get; private set; }
        public MissionCategoryRecord Pl2NumFlownNonSeries { get; private set; }

        public MissionCategoryRecord PltNumFlownSeries { get; private set; }
        public MissionCategoryRecord Pl2NumFlownSeries { get; private set; }

        public MissionCategoryRecord PltTotalKills { get; private set; }
        public MissionCategoryRecord Pl2TotalKills { get; private set; }

        public MissionCategoryRecord PltFriendlyKills { get; private set; }
        public MissionCategoryRecord Pl2FriendlyKills { get; private set; }

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

        public MissionCategoryRecord PltTotalHiddenCargoFound { get; private set; }
        public MissionCategoryRecord Pl2TotalHiddenCargoFound { get; private set; }

        public MissionCategoryRecord PltTotalLaserHit { get; private set; }
        public MissionCategoryRecord Pl2TotalLaserHit { get; private set; }

        public MissionCategoryRecord PltTotalLaserFired { get; private set; }
        public MissionCategoryRecord Pl2TotalLaserFired { get; private set; }

        public MissionCategoryRecord PltTotalWarheadHit { get; private set; }
        public MissionCategoryRecord Pl2TotalWarheadHit { get; private set; }

        public MissionCategoryRecord PltTotalWarheadFired { get; private set; }
        public MissionCategoryRecord Pl2TotalWarheadFired { get; private set; }

        public MissionCategoryRecord PltTotalCraftLosses { get; private set; }
        public MissionCategoryRecord Pl2TotalCraftLosses { get; private set; }

        public MissionCategoryRecord PltTotalLossesFromCollisions { get; private set; }
        public MissionCategoryRecord Pl2TotalLossesFromCollisions { get; private set; }

        public MissionCategoryRecord PltTotalLossesFromStarships { get; private set; }
        public MissionCategoryRecord Pl2TotalLossesFromStarships { get; private set; }

        public MissionCategoryRecord PltTotalLossesFromMines { get; private set; }
        public MissionCategoryRecord Pl2TotalLossesFromMines { get; private set; }

        public MissionCategoryRecordByPlayerRating PltTotalLossesFromPlayerRank { get; private set; }
        public MissionCategoryRecordByPlayerRating Pl2TotalLossesFromPlayerRank { get; private set; }

        public MissionCategoryRecordByAIRating PltTotalLossesFromAIRank { get; private set; }
        public MissionCategoryRecordByAIRating Pl2TotalLossesFromAIRank { get; private set; }

        //...

        public uint PltCurrentRank { get; private set; }
        public uint Pl2CurrentRank { get; private set; }

        public int PltTotalCountMissionsFlown { get; private set; }
        public int Pl2TotalCountMissionsFlown { get; private set; }

        public int[] PltRankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();
        public int[] Pl2RankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();

        public string PltRankString { get; private set; } = string.Empty;
        public string Pl2RankString { get; private set; } = string.Empty;

        public int PltDebriefMissionScore { get; private set; }
        public int Pl2DebriefMissionScore { get; private set; }

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
        public int PltLastSelectedFaction { get; private set; }
        public uint Pl2LastSelectedFaction { get; private set; }

        // Exposed collection the FilterableCompoundList will bind to
        public ObservableCollection<ViewModels.CompoundFieldItem> Fields { get; } = new ObservableCollection<ViewModels.CompoundFieldItem>();

        private PltRecord pltRecord;
        private Pl2Record pl2Record;

        internal CombinedPilotRecordPageViewModel(PltRecord pltRecord, Pl2Record pl2Record)
        {
            this.pltRecord = pltRecord ?? new PltRecord();
            this.pl2Record = pl2Record ?? new Pl2Record();

            BuildFields();
            RefreshFieldsFromRecords();
        }

        public void UpdatePilotRecord(PltRecord pltRecord, Pl2Record pl2Record)
        {
            this.pltRecord = pltRecord ?? new PltRecord();
            this.pl2Record = pl2Record ?? new Pl2Record();

            // Notify all public properties
            NotifyAllPublicPropertiesChanged();

            // Update UI field items to reflect new underlying records
            RefreshFieldsFromRecords();
        }

        private void BuildFields()
        {
            Fields.Clear();

            var pltItem = new ViewModels.CompoundFieldItem
            {
                Key = nameof(PltPilotName),
                Label = "PLT Pilot Name",
                Metadata = "PLT;PilotName"
            };
            pltItem.PropertyChanged += Field_PropertyChanged;

            var pl2Item = new ViewModels.CompoundFieldItem
            {
                Key = nameof(Pl2PilotName),
                Label = "PL2 Pilot Name",
                Metadata = "PL2;PilotName"
            };
            pl2Item.PropertyChanged += Field_PropertyChanged;

            Fields.Add(pltItem);
            Fields.Add(pl2Item);
        }

        private void Field_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (_suppressFieldValueChange) return;
            if (e.PropertyName != nameof(ViewModels.CompoundFieldItem.Value)) return;
            if (sender is not ViewModels.CompoundFieldItem item) return;

            try
            {
                _suppressFieldValueChange = true;

                switch (item.Key)
                {
                    case nameof(PltPilotName):
                        // route through property to run validation and raise OnPropertyChanged
                        PltPilotName = item.Value ?? string.Empty;
                        break;
                    case nameof(Pl2PilotName):
                        Pl2PilotName = item.Value ?? string.Empty;
                        break;
                }

                // After underlying record changed, re-sync the Fields with canonical values
                RefreshFieldsFromRecords();
            }
            finally
            {
                _suppressFieldValueChange = false;
            }
        }

        private void RefreshFieldsFromRecords()
        {
            try
            {
                _suppressFieldValueChange = true;

                foreach (var f in Fields)
                {
                    if (f.Key == nameof(PltPilotName))
                    {
                        f.Value = this.PltPilotName ?? string.Empty;
                    }
                    else if (f.Key == nameof(Pl2PilotName))
                    {
                        f.Value = this.Pl2PilotName ?? string.Empty;
                    }
                }
            }
            finally
            {
                _suppressFieldValueChange = false;
            }
        }

        private void NotifyAllPublicPropertiesChanged()
        {
            var props = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var p in props)
            {
                OnPropertyChanged(p.Name);
            }
        }
    }
}
