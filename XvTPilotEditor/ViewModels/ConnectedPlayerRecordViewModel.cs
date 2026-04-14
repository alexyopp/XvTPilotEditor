using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public sealed class ConnectedPlayerRecordViewModel : PilotDataViewModelBase
    {
        private ConnectedPlayerRecord ConnectedPlayerRecord;

        public string PilotLongNameUnused
        {
            get => ConnectedPlayerRecord.PilotLongNameUnused;
            set { ConnectedPlayerRecord.PilotLongNameUnused = SetStringProperty(value, Constants.PILOT_NAME_MAX_LENGTH); }
        }

        public string PilotShortName
        {
            get => ConnectedPlayerRecord.PilotShortName;
            set { ConnectedPlayerRecord.PilotShortName = SetStringProperty(value, Constants.PILOT_NAME_MAX_LENGTH); }
        }

        public string FGIndex
        {
            get => ConnectedPlayerRecord.FGIndex.ToString();
            set { ConnectedPlayerRecord.FGIndex = SetIntProperty(value); }
        }

        public string DPPlayerID
        {
            get => ConnectedPlayerRecord.DPPlayerID.ToString();
            set { ConnectedPlayerRecord.DPPlayerID = SetUIntProperty(value); }
        }

        // TODO: Convert to Pilot Rank description (e.g., "Officer 1st Class") instead of raw int?
        public string PilotRank
        {
            get => ConnectedPlayerRecord.PilotRank.ToString();
            set { ConnectedPlayerRecord.PilotRank = SetIntProperty(value); }
        }

        public string PlayerScore
        {
            get => ConnectedPlayerRecord.PlayerScore.ToString();
            set { ConnectedPlayerRecord.PlayerScore = SetIntProperty(value); }
        }

        public string FullKills
        {
            get => ConnectedPlayerRecord.FullKills.ToString();
            set { ConnectedPlayerRecord.FullKills = SetIntProperty(value); }
        }

        public string SharedKills
        {
            get => ConnectedPlayerRecord.SharedKills.ToString();
            set { ConnectedPlayerRecord.SharedKills = SetIntProperty(value); }
        }

        // TODO: What is this?
        public string UnusedInspections
        {
            get => ConnectedPlayerRecord.UnusedInspections.ToString();
            set { ConnectedPlayerRecord.UnusedInspections = SetIntProperty(value); }
        }

        // TODO: Rename to "Assists"?
        public string AssistKills
        {
            get => ConnectedPlayerRecord.AssistKills.ToString();
            set { ConnectedPlayerRecord.AssistKills = SetIntProperty(value); }
        }

        public string Losses
        {
            get => ConnectedPlayerRecord.Losses.ToString();
            set { ConnectedPlayerRecord.Losses = SetIntProperty(value); }
        }

        public string CraftType
        {
            get => ConnectedPlayerRecord.CraftType.ToString();
            set { ConnectedPlayerRecord.CraftType = SetIntProperty(value); }
        }

        public string OptionalCraftIndex
        {
            get => ConnectedPlayerRecord.OptionalCraftIndex.ToString();
            set { ConnectedPlayerRecord.OptionalCraftIndex = SetIntProperty(value); }
        }

        public string OptionalWarhead
        {
            get => ConnectedPlayerRecord.OptionalWarhead.ToString();
            set { ConnectedPlayerRecord.OptionalWarhead = SetIntProperty(value); }
        }

        public string OptionalBeam
        {
            get => ConnectedPlayerRecord.OptionalBeam.ToString();
            set { ConnectedPlayerRecord.OptionalBeam = SetIntProperty(value); }
        }

        public string OptionalCountermeasure
        {
            get => ConnectedPlayerRecord.OptionalCountermeasure.ToString();
            set { ConnectedPlayerRecord.OptionalCountermeasure = SetIntProperty(value); }
        }

        // TODO: What is this?
        public string HasDisconnectedFromHostUNK
        {
            get => ConnectedPlayerRecord.HasDisconnectedFromHostUNK.ToString();
            set { ConnectedPlayerRecord.HasDisconnectedFromHostUNK = SetIntProperty(value); }
        }

        public ConnectedPlayerRecordViewModel(ConnectedPlayerRecord initRecord)
        {
            this.ConnectedPlayerRecord = initRecord;
        }
    }
}
