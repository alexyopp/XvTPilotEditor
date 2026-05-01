using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    /// <summary>
    /// Small container pairing a Full and Shared NotifyingInt so the UI can render both together.
    /// Shared may be null to indicate "no second value" and the UI will hide the second editor.
    /// </summary>
    public sealed class KillPairViewModel
    {
        public NotifyingInt Full { get; }
        public NotifyingInt? Shared { get; }

        public bool HasShared => Shared != null;

        public KillPairViewModel(NotifyingInt full, NotifyingInt? shared)
        {
            Full = full ?? new NotifyingInt(0);
            Shared = shared;
        }
    }
}
