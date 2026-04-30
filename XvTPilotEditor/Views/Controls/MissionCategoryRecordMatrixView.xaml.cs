using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using XvTPilotEditor.ViewModels;

namespace XvTPilotEditor.Views.Controls
{
    /// <summary>
    /// Interaction logic for MissionCategoryRecordMatrixView.xaml
    /// </summary>
    public partial class MissionCategoryRecordMatrixView : UserControl
    {
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string), typeof(MissionCategoryRecordMatrixView), new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register(nameof(Data), typeof(MissionCategoryRecordMatrixViewModel), typeof(MissionCategoryRecordMatrixView), new PropertyMetadata());

        public MissionCategoryRecordMatrixViewModel Data
        {
            get => (MissionCategoryRecordMatrixViewModel)GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }

        public static readonly DependencyProperty IndexConverterProperty =
            DependencyProperty.Register(nameof(IndexConverter), typeof(IValueConverter), typeof(MissionCategoryRecordMatrixView), new PropertyMetadata(null));
        
        public IValueConverter? IndexConverter
        {
            get => (IValueConverter?)GetValue(IndexConverterProperty);
            set => SetValue(IndexConverterProperty, value);
        }

        public MissionCategoryRecordMatrixView()
        {
            InitializeComponent();
        }
    }
}
