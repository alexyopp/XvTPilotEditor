using System.Windows;
using System.Windows.Controls;
using XvTPilotEditor.ViewModels;

namespace XvTPilotEditor.Views.Controls
{
    /// <summary>
    /// Interaction logic for MissionCategoryRecordView.xaml
    /// </summary>
    public partial class MissionCategoryRecordView : UserControl
    {
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string), typeof(MissionCategoryRecordView), new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register(nameof(Data), typeof(MissionCategoryRecordViewModel), typeof(MissionCategoryRecordView), new PropertyMetadata());

        public MissionCategoryRecordViewModel Data
        {
            get => (MissionCategoryRecordViewModel)GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }

        public MissionCategoryRecordView()
        {
            InitializeComponent();
        }
    }
}
