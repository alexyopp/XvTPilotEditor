using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    /// <summary>
    /// Small container pairing a Full and Shared NotifyingInt so the UI can render both together.
    /// </summary>
    public sealed class KillPairViewModel
    {
        public NotifyingInt Full { get; }
        public NotifyingInt Shared { get; }

        public KillPairViewModel(NotifyingInt full, NotifyingInt shared)
        {
            Full = full ?? new NotifyingInt(0);
            Shared = shared ?? new NotifyingInt(0);
        }
    }
}