using System.Collections.ObjectModel;
using System.ComponentModel;

namespace XvTPilotEditor.Utilities
{
    public static class CollectionHelpers
    {
        public static void PopulateCollection(ObservableCollection<NotifyingInt> target, int[]? source, PropertyChangedEventHandler? handler)
        {
            target.Clear();
            if (source == null)
            {
                return;
            }

            foreach (var v in source)
            {
                var ni = new NotifyingInt(v);
                if (handler != null)
                {
                    ni.PropertyChanged += handler;
                }
                target.Add(ni);
            }
        }
    }
}