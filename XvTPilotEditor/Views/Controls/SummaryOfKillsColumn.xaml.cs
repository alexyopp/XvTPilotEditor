using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XvTPilotEditor.Views.Controls
{
    /// <summary>
    /// Interaction logic for SummaryOfKillsColumn.xaml
    /// </summary>
    public partial class SummaryOfKillsColumn : UserControl
    {
        public static readonly DependencyProperty TotalKillsValueProperty = DependencyProperty.Register("TotalKillsValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string TotalKillsValue
        {
            get => (string)GetValue(TotalKillsValueProperty);
            set => SetValue(TotalKillsValueProperty, value);
        }
        public static readonly DependencyProperty TotalSharedKillsValueProperty = DependencyProperty.Register("TotalSharedKillsValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string TotalSharedKillsValue
        {
            get => (string)GetValue(TotalSharedKillsValueProperty);
            set => SetValue(TotalSharedKillsValueProperty, value);
        }

        public static readonly DependencyProperty PlayerKillsValueProperty = DependencyProperty.Register("PlayerKillsValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string PlayerKillsValue
        {
            get => (string)GetValue(PlayerKillsValueProperty);
            set => SetValue(PlayerKillsValueProperty, value);
        }
        public static readonly DependencyProperty PlayerSharedKillsValueProperty = DependencyProperty.Register("PlayerSharedKillsValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string PlayerSharedKillsValue
        {
            get => (string)GetValue(PlayerSharedKillsValueProperty);
            set => SetValue(PlayerSharedKillsValueProperty, value);
        }

        public static readonly DependencyProperty NonPlayerKillsValueProperty = DependencyProperty.Register("NonPlayerKillsValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string NonPlayerKillsValue
        {
            get => (string)GetValue(NonPlayerKillsValueProperty);
            set => SetValue(NonPlayerKillsValueProperty, value);
        }
        public static readonly DependencyProperty NonPlayerSharedKillsValueProperty = DependencyProperty.Register("NonPlayerSharedKillsValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string NonPlayerSharedKillsValue
        {
            get => (string)GetValue(NonPlayerSharedKillsValueProperty);
            set => SetValue(NonPlayerSharedKillsValueProperty, value);
        }

        public static readonly DependencyProperty AssistsValueProperty = DependencyProperty.Register("AssistsValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string AssistsValue
        {
            get => (string)GetValue(AssistsValueProperty);
            set => SetValue(AssistsValueProperty, value);
        }

        public static readonly DependencyProperty HiddenCargoFoundValueProperty = DependencyProperty.Register("HiddenCargoFoundValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string HiddenCargoFoundValue
        {
            get => (string)GetValue(HiddenCargoFoundValueProperty);
            set => SetValue(HiddenCargoFoundValueProperty, value);
        }

        public static readonly DependencyProperty LaserAccuracyValueProperty = DependencyProperty.Register("LaserAccuracyValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string LaserAccuracyValue
        {
            get => (string)GetValue(LaserAccuracyValueProperty);
            set => SetValue(LaserAccuracyValueProperty, value);
        }

        public static readonly DependencyProperty WarheadAccuracyValueProperty = DependencyProperty.Register("WarheadAccuracyValue", typeof(string), typeof(SummaryOfKillsColumn));
        public string WarheadAccuracyValue
        {
            get => (string)GetValue(WarheadAccuracyValueProperty);
            set => SetValue(WarheadAccuracyValueProperty, value);
        }

        public SummaryOfKillsColumn()
        {
            InitializeComponent();
            this.DataContext = this;

            TotalKillsValue = "SoKStatColumn";
            TotalSharedKillsValue = "SoKStatColumn";
            PlayerKillsValue = "SoKStatColumn";
            PlayerSharedKillsValue = "SoKStatColumn";
            NonPlayerKillsValue = "SoKStatColumn";
            NonPlayerSharedKillsValue = "SoKStatColumn";
            AssistsValue = "SoKStatColumn";
            HiddenCargoFoundValue = "SoKStatColumn";
            LaserAccuracyValue = "SoKStatColumn";
            WarheadAccuracyValue = "SoKStatColumn";
        }
    }
}
