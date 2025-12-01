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

            var pltItem = new ViewModels.CompoundFieldItem
            {
                Key = nameof(PltPilotName),
                Label = "Pilot Name",
                Metadata = "PilotName"
            };
            pltItem.PropertyChanged += Field_PropertyChanged;

            var pl2Item = new ViewModels.CompoundFieldItem
            {
                Key = nameof(PltTotalScore),
                Label = "Total Score",
                Metadata = "TotalScore"
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
                    case nameof(PltTotalScore):
                        PltTotalScore = item.Value ?? string.Empty;
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
