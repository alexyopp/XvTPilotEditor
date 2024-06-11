using System;
using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class RatingHistory
    {
        public Dictionary<PilotRating, uint> RatingAchievedOnMissionNumber { get; set; }

        public RatingHistory()
        {
            RatingAchievedOnMissionNumber = new Dictionary<PilotRating, uint>();

            foreach (PilotRating pilotRating in Enum.GetValues<PilotRating>())
            {
                RatingAchievedOnMissionNumber.Add(pilotRating, 0);
            }
        }
    }
}
