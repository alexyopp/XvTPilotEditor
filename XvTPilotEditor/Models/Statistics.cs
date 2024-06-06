namespace XvTPilotEditor.Models
{
    class Statistics
    {
        public ModeStats Exercise { get; }
        public ModeStats Melee { get; }
        public ModeStats Combat { get; }

        public Statistics()
        {
            Exercise = new ModeStats();
            Melee = new ModeStats();
            Combat = new ModeStats();
        }
    }
}
