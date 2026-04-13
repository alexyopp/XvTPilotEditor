using System.ComponentModel;
using System.Collections.ObjectModel;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    /// <summary>
    /// Small reusable wrapper VM for a Mission Category Record matrix (Exercise / Melee / Combat).
    /// Holds three ObservableCollection<NotifyingInt> and keeps the collections in sync with the
    /// backing int[] sources passed at construction time (writes back on change).
    /// </summary>
    public sealed class MissionCategoryRecordMatrixViewModel
    {
        public ObservableCollection<NotifyingInt> Exercise { get; } = new();
        public ObservableCollection<NotifyingInt> Melee { get; } = new();
        public ObservableCollection<NotifyingInt> Combat { get; } = new();

        // Keep references to the backing arrays so we can write changes back directly.
        private readonly int[]? _exerciseSource;
        private readonly int[]? _meleeSource;
        private readonly int[]? _combatSource;

        public MissionCategoryRecordMatrixViewModel(int[]? exerciseSource, int[]? meleeSource, int[]? combatSource)
        {
            _exerciseSource = exerciseSource;
            _meleeSource = meleeSource;
            _combatSource = combatSource;

            CollectionHelpers.PopulateCollection(Exercise, _exerciseSource, OnExerciseChanged);
            CollectionHelpers.PopulateCollection(Melee, _meleeSource, OnMeleeChanged);
            CollectionHelpers.PopulateCollection(Combat, _combatSource, OnCombatChanged);
        }

        private void OnExerciseChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingInt.Value))
                return;

            var ni = (NotifyingInt)sender!;
            var idx = Exercise.IndexOf(ni);
            if (_exerciseSource != null && idx >= 0 && idx < _exerciseSource.Length)
            {
                _exerciseSource[idx] = ni.Value;
            }
        }

        private void OnMeleeChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingInt.Value))
                return;

            var ni = (NotifyingInt)sender!;
            var idx = Melee.IndexOf(ni);
            if (_meleeSource != null && idx >= 0 && idx < _meleeSource.Length)
            {
                _meleeSource[idx] = ni.Value;
            }
        }

        private void OnCombatChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (e?.PropertyName != nameof(NotifyingInt.Value))
                return;

            var ni = (NotifyingInt)sender!;
            var idx = Combat.IndexOf(ni);
            if (_combatSource != null && idx >= 0 && idx < _combatSource.Length)
            {
                _combatSource[idx] = ni.Value;
            }
        }
    }
}