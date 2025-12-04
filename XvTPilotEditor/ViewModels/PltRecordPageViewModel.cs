using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using XvTPilotEditor.Models;
using XvTPilotEditor.Views;

namespace XvTPilotEditor.ViewModels
{
    public class PltRecordPageViewModel : PilotRecordViewModel
    {
        private bool _suppressFieldValueChange;

        // Exposed collection the FilterableCompoundList will bind to
        public ObservableCollection<ViewModels.CompoundFieldItem> Fields { get; } = new ObservableCollection<ViewModels.CompoundFieldItem>();

        internal PltRecordPageViewModel(CompletePilotRecord pilotRecord) : base(pilotRecord)
        {
            BuildFields();
            RefreshFieldsFromRecords();
        }

        public new void UpdatePilotRecord(CompletePilotRecord pilotRecord)
        {
            base.UpdatePilotRecord(pilotRecord);

            // Notify all public properties
            NotifyAllPublicPropertiesChanged();

            // Update UI field items to reflect new underlying records
            RefreshFieldsFromRecords();
        }

        private void BuildFields()
        {
            Fields.Clear();

            AddField(nameof(PltPilotName),                  "Pilot Name",                           "PilotName");
            AddField(nameof(PltTotalScore),                 "Total Score",                          "TotalScore");
            AddField(nameof(PltContinuedOrReflownMission),  "Continued Or Reflown Mission",         "ContinuedOrReflownMission");
            AddField(nameof(PltIsHosting),                  "Is Hosting",                           "IsHosting");
            AddField(nameof(PltNumHumanPlayersInMission),   "Number of Human Players In Mission",   "NumHumanPlayersInMission");
            AddField(nameof(PltFrontFlyMode),               "Front Fly Mode",                       "FrontFlyMode");
            AddField(nameof(PltPromoPoints),                "Promotion Points",                     "PromotionPoints");
            AddField(nameof(PltWorsePromoPoints),           "Worse Promo Points",                   "WorsePromoPoints");
            AddField(nameof(PltRankAdjustmentApplied),      "Rank Adjustment Applied",              "RankAdjustmentApplied");
            AddField(nameof(PltPercentToNextRank),          "Percent To Next Rank",                 "PercentToNextRankd");
            AddField(nameof(PltCurrentRank),                "Current Rank",                         "CurrentRank");
            AddField(nameof(PltTotalCountMissionsFlown),    "Total Missions Flown",                 "TotalCountMissionsFlown");
            AddField(nameof(PltRankString),                 "Rank String",                          "RankString");
            AddField(nameof(PltDebriefMissionScore),        "DebriefMissionScore",                  "DebriefMissionScore");
        }

        private void AddField(string key, string label, string metadata)
        {
            var item = new ViewModels.CompoundFieldItem { Key = key, Label = label, Metadata = metadata };
            item.PropertyChanged += Field_PropertyChanged;
            Fields.Add(item);
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
                    case nameof(PltTotalScore):
                        PltTotalScore = item.Value ?? string.Empty;
                        break;
                    case nameof(PltPlayerID):
                        PltPlayerID = item.Value ?? string.Empty;
                        break;
                    case nameof(PltContinuedOrReflownMission):
                        PltContinuedOrReflownMission = item.Value ?? string.Empty;
                        break;
                    case nameof(PltIsHosting):
                        PltIsHosting = item.Value ?? string.Empty;
                        break;
                    case nameof(PltNumHumanPlayersInMission):
                        PltNumHumanPlayersInMission = item.Value ?? string.Empty;
                        break;
                    case nameof(PltFrontFlyMode):
                        PltFrontFlyMode = item.Value ?? string.Empty;
                        break;
                    case nameof(PltPromoPoints):
                        PltPromoPoints = item.Value ?? string.Empty;
                        break;
                    case nameof(PltWorsePromoPoints):
                        PltWorsePromoPoints = item.Value ?? string.Empty;
                        break;
                    case nameof(PltRankAdjustmentApplied):
                        PltRankAdjustmentApplied = item.Value ?? string.Empty;
                        break;
                    case nameof(PltPercentToNextRank):
                        PltPercentToNextRank = item.Value ?? string.Empty;
                        break;
                    case nameof(PltCurrentRank):
                        PltCurrentRank = item.Value ?? string.Empty;
                        break;
                    case nameof(PltTotalCountMissionsFlown):
                        PltTotalCountMissionsFlown = item.Value ?? string.Empty;
                        break;
                    case nameof(PltRankString):
                        PltRankString = item.Value ?? string.Empty;
                        break;
                    case nameof(PltDebriefMissionScore):
                        PltDebriefMissionScore = item.Value ?? string.Empty;
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
                    else if (f.Key == nameof(PltTotalScore))
                    {
                        f.Value = this.PltTotalScore ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltPlayerID))
                    {
                        f.Value = this.PltPlayerID ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltContinuedOrReflownMission))
                    {
                        f.Value = this.PltContinuedOrReflownMission ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltIsHosting))
                    {
                        f.Value = this.PltIsHosting ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltNumHumanPlayersInMission))
                    {
                        f.Value = this.PltNumHumanPlayersInMission ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltFrontFlyMode))
                    {
                        f.Value = this.PltFrontFlyMode ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltPromoPoints))
                    {
                        f.Value = this.PltPromoPoints ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltWorsePromoPoints))
                    {
                        f.Value = this.PltWorsePromoPoints ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltRankAdjustmentApplied))
                    {
                        f.Value = this.PltRankAdjustmentApplied ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltPercentToNextRank))
                    {
                        f.Value = this.PltPercentToNextRank ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltCurrentRank))
                    {
                        f.Value = this.PltCurrentRank ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltTotalCountMissionsFlown))
                    {
                        f.Value = this.PltTotalCountMissionsFlown ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltRankString))
                    {
                        f.Value = this.PltRankString ?? string.Empty;
                    }
                    else if (f.Key == nameof(PltDebriefMissionScore))
                    {
                        f.Value = this.PltDebriefMissionScore ?? string.Empty;
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
