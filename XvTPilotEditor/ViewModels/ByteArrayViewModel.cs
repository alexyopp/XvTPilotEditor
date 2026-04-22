using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    /// <summary>
    /// Small reusable wrapper VM for a byte array.
    /// Holds an ObservableCollection<NotifyingString> and keeps the collection in sync with the
    /// backing byte[] source passed at construction time (writes back on change).
    /// </summary>
    public sealed class ByteArrayViewModel
    {
        public ObservableCollection<NotifyingString> Values { get; } = new();

        // Keep references to the backing array so we can write changes back directly.
        private readonly byte[]? _valuesSource;

        public ByteArrayViewModel(byte[]? valuesSource)
        {
            _valuesSource = valuesSource;

            CollectionHelpers.PopulateCollection(Values, _valuesSource, OnValuesChanged);
        }

        private void OnValuesChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingString.Value))
                return;

            var notifyingString = (NotifyingString)sender!;
            var idx = Values.IndexOf(notifyingString);
            if (_valuesSource != null && idx >= 0 && idx < _valuesSource.Length)
            {
                // TODO: Need to handle invalid input here (non-hex, out of byte range, etc).
                byte.TryParse(notifyingString.Value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out _valuesSource[idx]);
            }
        }
    }
}
