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
        public Faction Rebel                { get; }
        public Faction Imperial             { get; }

        public Pilot()
        {
            RatingHistory = new RatingHistory();

            Rebel = new Faction();
            Imperial = new Faction();
        }
    }
}
