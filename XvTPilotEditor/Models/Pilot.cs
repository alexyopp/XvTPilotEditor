using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTPilotEditor.Models
{
    public class Pilot
    {
        private const uint MAX_NAME_LENGTH = 12;

        private string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                if (value.Length > MAX_NAME_LENGTH)
                {
                    throw new Exception($"Attempt to set {value} to PilotData.Name.\nMaximum allowable characters ({MAX_NAME_LENGTH})exceeded).");
                }

                name = value;
            }
        }

        public PilotRating CurrentRating    { get; set; }
        public int TotalScore               { get; set; }       //  Not a calculated value!
        public uint TotalMissions           { get; set; }       //  Sum of Rebel.TotalMissions and Imperial.TotalMissions?

        public RatingHistory RatingHistory  { get; }
        // NOTE: Intentionally choosing to break factions at this point (rather than deeper in the
        //          hierarchy); branching higher makes things simpler to understand (for example,
        //          can ignore an entire faction, but still have all options available.
        public Dictionary<XvTPilotEditor.Faction, Models.Faction> FactionData { get; }

        public Pilot()
        {
            RatingHistory = new RatingHistory();

            FactionData = new Dictionary<XvTPilotEditor.Faction, Models.Faction>();
            foreach (XvTPilotEditor.Faction faction in Enum.GetValues<XvTPilotEditor.Faction>())
            {
                FactionData.Add(faction, new Models.Faction());
            }
        }
    }
}
