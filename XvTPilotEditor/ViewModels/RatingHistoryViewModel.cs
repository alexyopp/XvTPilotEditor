using System.Collections.Generic;
using System;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class RatingHistoryItem
    {
        public uint MissionAchieved { get; set; }

        public RatingHistoryItem(uint missionAchieved)
        {
            this.MissionAchieved = missionAchieved;
        }
    }

    public class RatingHistoryViewModel : PageViewModel
    {
        public Dictionary<PilotRating, RatingHistoryItem> PlayerRankHistory { get; }

        private PilotModel activePilotModel;

        internal RatingHistoryViewModel(PilotModel pilotModel)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;

            this.PlayerRankHistory = new Dictionary<PilotRating, RatingHistoryItem>();

            foreach (PilotRating rating in Enum.GetValues<PilotRating>())
            {
                uint missionNumber = activePilotModel.RatingHistory.RatingAchievedOnMissionNumber[rating];
                PlayerRankHistory.Add(
                    rating,
                    new RatingHistoryItem(missionNumber));
            }
        }
    }
}
