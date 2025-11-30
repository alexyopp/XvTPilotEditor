using System.ComponentModel;

namespace XvTPilotEditor.ViewModels
{
    // Generic data item that the compound list can render and filter.
    public class CompoundFieldItem : INotifyPropertyChanged
    {
        private string _value = string.Empty;

        public string Key { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;

        // Value shown/edited by the compound control.
        public string Value
        {
            get => _value;
            set { if (_value == value) return; _value = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value))); }
        }

        // Freeform metadata used by the filter (tags, category, extra searchable text)
        public string Metadata { get; set; } = string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}