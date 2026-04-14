using System.Windows;
using System.Windows.Controls;

namespace XvTPilotEditor.Views.Controls
{
    /// <summary>
    /// Interaction logic for KillsTuple.xaml
    /// </summary>
    public partial class KillsTuple : UserControl
    {
        public static readonly DependencyProperty KillsValueProperty = DependencyProperty.Register(nameof(KillsValue), typeof(string), typeof(KillsTuple), new PropertyMetadata(string.Empty));
        public string KillsValue
        {
            get => (string)GetValue(KillsValueProperty);
            set => SetValue(KillsValueProperty, value);
        }

        public static readonly DependencyProperty SharedKillsValueProperty = DependencyProperty.Register(nameof(SharedKillsValue), typeof(string), typeof(KillsTuple), new PropertyMetadata(string.Empty));
        public string SharedKillsValue
        {
            get => (string)GetValue(SharedKillsValueProperty);
            set => SetValue(SharedKillsValueProperty, value);
        }

        public KillsTuple()
        {
            InitializeComponent();
        }
    }
}
