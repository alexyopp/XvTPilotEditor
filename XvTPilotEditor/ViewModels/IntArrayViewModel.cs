using System.Collections.ObjectModel;
using System.ComponentModel;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    /// <summary>
    /// Small reusable wrapper VM for an integer array.
    /// Holds an ObservableCollection<NotifyingInt> and keeps the collection in sync with the
    /// backing int[] source passed at construction time (writes back on change).
    /// </summary>
    public sealed class IntArrayViewModel
    {
        public ObservableCollection<NotifyingInt> Values { get; } = new();

        // Keep references to the backing array so we can write changes back directly.
        private readonly int[]? _valuesSource;

        public IntArrayViewModel(int[]? valuesSource)
        {
            _valuesSource = valuesSource;

            CollectionHelpers.PopulateCollection(Values, _valuesSource, OnValuesChanged);
        }

        private void OnValuesChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingInt.Value))
                return;

            var ni = (NotifyingInt)sender!;
            var idx = Values.IndexOf(ni);
            if (_valuesSource != null && idx >= 0 && idx < _valuesSource.Length)
            {
                _valuesSource[idx] = ni.Value;
            }
        }
    }
}
