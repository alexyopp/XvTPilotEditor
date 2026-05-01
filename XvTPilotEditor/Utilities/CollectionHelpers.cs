using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using XvTPilotEditor.ViewModels;

namespace XvTPilotEditor.Utilities
{
    public static class CollectionHelpers
    {
        // Helper to provide a PropertyChanged handler to elements of an ObservableCollection<NotifyingInt>.
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

        public static void PopulateCollection(ObservableCollection<NotifyingString> target, byte[]? source, PropertyChangedEventHandler? handler)
        {
            target.Clear();
            if (source == null)
            {
                return;
            }

            foreach (var byteData in source)
            {
                var newString = new NotifyingString(byteData.ToString("X2"));
                if (handler != null)
                {
                    newString.PropertyChanged += handler;
                }
                target.Add(newString);
            }
        }

        // Helper to provide a PropertyChanged handler to elements of an ObservableCollection<KillPairViewModel>.
        public static void PopulateCollection(ObservableCollection<KillPairViewModel> target, int[]? sourceFull, PropertyChangedEventHandler? handlerFull, int[]? sourceShared, PropertyChangedEventHandler? handlerShared)
        {
            target.Clear();
            
            // SharedSource not valid if FullSource is null
            if (sourceFull == null)
            {
                return;
            }

            // This should never happen, I don't think?
            if (sourceShared != null && sourceFull.Length != sourceShared.Length)
            {
                Console.WriteLine("Warning: FullKills and SharedKills arrays have different lengths. SharedKills will be ignored.");
            }

            for (int idx = 0; idx < sourceFull.Length; ++idx)
            {
                NotifyingInt fullValue = new NotifyingInt(sourceFull[idx]);
                NotifyingInt? sharedValue = null;
                if (handlerFull != null)
                {
                    fullValue.PropertyChanged += handlerFull;
                }

                if (sourceShared != null && idx < sourceShared.Length)
                {
                    sharedValue = new NotifyingInt(sourceShared[idx]);
                    if (handlerShared != null)
                    {
                        sharedValue.PropertyChanged += handlerShared;
                    }
                }
                target.Add(new KillPairViewModel(fullValue, sharedValue));
            }
        }

        // Helper to combine two ObservableCollection<NotifyingInt> into pairs, preserving references so edits write back.
        public static ObservableCollection<KillPairViewModel> Combine(ObservableCollection<NotifyingInt> FullKills, ObservableCollection<NotifyingInt> SharedKills)
        {
            var newKillPairCollection = new ObservableCollection<KillPairViewModel>();
            var FullKillsLength = FullKills?.Count ?? 0;
            var SharedKillsLength = SharedKills?.Count ?? 0;
            var max = Math.Max(FullKillsLength, SharedKillsLength);

            for (int i = 0; i < max; i++)
            {
                NotifyingInt fullKillValue = (i < FullKillsLength) ? FullKills![i] : new NotifyingInt(0);
                NotifyingInt sharedKillValue = (i < SharedKillsLength) ? SharedKills![i] : new NotifyingInt(0);
                newKillPairCollection.Add(new KillPairViewModel(fullKillValue, sharedKillValue));
            }

            return newKillPairCollection;
        }
    }
}