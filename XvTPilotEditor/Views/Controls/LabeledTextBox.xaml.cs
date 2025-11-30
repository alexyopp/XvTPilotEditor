using System.Windows;
using System.Windows.Controls;

namespace XvTPilotEditor.Views.Controls
{
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string), typeof(LabeledTextBox), new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(nameof(Value), typeof(string), typeof(LabeledTextBox), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        // Optional searchable metadata - freeform text the filter will inspect.
        public static readonly DependencyProperty MetadataProperty =
            DependencyProperty.Register(nameof(Metadata), typeof(string), typeof(LabeledTextBox), new PropertyMetadata(string.Empty));

        public string Metadata
        {
            get => (string)GetValue(MetadataProperty);
            set => SetValue(MetadataProperty, value);
        }
    }
}