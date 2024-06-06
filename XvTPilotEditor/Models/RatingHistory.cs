using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    class RatingHistory
    {
        public List<PilotRating> RatingAchievedOnMissionNumber { get; }

        public RatingHistory()
        {
            RatingAchievedOnMissionNumber = new List<PilotRating>((int)PilotRating.MAX_PILOT_RATINGS);
        }
    }
}
