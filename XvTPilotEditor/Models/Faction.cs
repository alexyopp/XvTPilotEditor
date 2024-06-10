namespace XvTPilotEditor.Models
{
    public class Faction
    {
        public Statistics Statistics { get; }
        public MissionHistory SinglePlayer { get; }
        public MissionHistory Multiplayer { get; }

        public Faction()
        {
            Statistics = new Statistics();
            SinglePlayer = new MissionHistory();
            Multiplayer = new MissionHistory();
        }
    }
}
