using System.ComponentModel;
using System.Collections.ObjectModel;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    /// <summary>
    /// Small reusable wrapper VM for a Mission Category Record matrix (Exercise / Melee / Combat).
    /// Holds three ObservableCollection<KillPairViewModel> and keeps the collections in sync with
    /// the backing int[] sources passed at construction time (writes back on change).
    /// </summary>
    public sealed class MissionCategoryRecordMatrixViewModel
    {
        public ObservableCollection<KillPairViewModel> Exercise { get; } = new();
        public ObservableCollection<KillPairViewModel> Melee    { get; } = new();
        public ObservableCollection<KillPairViewModel> Combat   { get; } = new();

        // Keep references to the backing arrays so we can write changes back directly.
        private readonly int[]? _exerciseFullSource;
        private readonly int[]? _exerciseSharedSource;
        private readonly int[]? _meleeFullSource;
        private readonly int[]? _meleeSharedSource;
        private readonly int[]? _combatFullSource;
        private readonly int[]? _combatSharedSource;

        public MissionCategoryRecordMatrixViewModel(int[]? exerciseFullSource,          int[]? meleeFullSource = null,      int[]? combatFullSource = null,
                                                    int[]? exerciseSharedSource = null, int[]? meleeSharedSource = null,    int[]? combatSharedSource = null)
        {
            _exerciseFullSource = exerciseFullSource;
            _exerciseSharedSource = exerciseSharedSource;
            _meleeFullSource = meleeFullSource;
            _meleeSharedSource = meleeSharedSource;
            _combatFullSource = combatFullSource;
            _combatSharedSource = combatSharedSource;

            CollectionHelpers.PopulateCollection(Exercise,  _exerciseFullSource,    OnExerciseChanged,  _exerciseSharedSource, OnExerciseChanged);
            CollectionHelpers.PopulateCollection(Melee,     _meleeFullSource,       OnMeleeChanged,     _meleeSharedSource,     OnMeleeChanged);
            CollectionHelpers.PopulateCollection(Combat,    _combatFullSource,      OnCombatChanged,    _combatSharedSource,    OnCombatChanged);
        }

        private void OnExerciseChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingInt.Value))
                return;

            if (sender != null)
            {
                var ni = (NotifyingInt)sender;
                if (FindIndex(ni, Exercise, out int idx, out int pairVal))
                {
                    if (pairVal == 0 && _exerciseFullSource != null && idx >= 0 && idx < _exerciseFullSource.Length)
                    {
                        _exerciseFullSource[idx] = ni.Value;
                    }
                    else if (pairVal == 1 && _exerciseSharedSource != null && idx >= 0 && idx < _exerciseSharedSource.Length)
                    {
                        _exerciseSharedSource[idx] = ni.Value;
                    }
                }
            }
        }

        private void OnMeleeChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingInt.Value))
                return;

            if (sender != null)
            {
                var ni = (NotifyingInt)sender;
                if (FindIndex(ni, Melee, out int idx, out int pairVal))
                {
                    if (pairVal == 0 && _meleeFullSource != null && idx >= 0 && idx < _meleeFullSource.Length)
                    {
                        _meleeFullSource[idx] = ni.Value;
                    }
                    else if (pairVal == 1 && _meleeSharedSource != null && idx >= 0 && idx < _meleeSharedSource.Length)
                    {
                        _meleeSharedSource[idx] = ni.Value;
                    }
                }
            }
        }

        private void OnCombatChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingInt.Value))
                return;

            if (sender != null)
            {
                var ni = (NotifyingInt)sender;
                if (FindIndex(ni, Combat, out int idx, out int pairVal))
                {
                    if (pairVal == 0 && _combatFullSource != null && idx >= 0 && idx < _combatFullSource.Length)
                    {
                        _combatFullSource[idx] = ni.Value;
                    }
                    else if (pairVal == 1 && _combatSharedSource != null && idx >= 0 && idx < _combatSharedSource.Length)
                    {
                        _combatSharedSource[idx] = ni.Value;
                    }
                }
            }
        }

        private bool FindIndex(NotifyingInt ni, ObservableCollection<KillPairViewModel> collection, out int idx, out int pairVal)
        {
            idx = 0;
            pairVal = 0;
            foreach (var pair in collection)
            {
                if (pair.Full == ni)
                {
                    pairVal = 0;
                    return true;
                }
                else if (pair.Shared == ni)
                {
                    pairVal = 1;
                    return true;
                }
                idx++;
            }
            return false;
        }
    }
}