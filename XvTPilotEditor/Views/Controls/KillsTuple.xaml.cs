using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for KillsTuple.xaml
    /// </summary>
    public partial class KillsTuple : UserControl
    {
        public static readonly DependencyProperty KillsValueProperty = DependencyProperty.Register("KillsValue", typeof(string), typeof(KillsTuple));
        public string KillsValue
        {
            get => (string)GetValue(KillsValueProperty);
            set => SetValue(KillsValueProperty, value);
        }

        public static readonly DependencyProperty SharedKillsValueProperty = DependencyProperty.Register("SharedKillsValue", typeof(string), typeof(KillsTuple));
        public string SharedKillsValue
        {
            get => (string)GetValue(SharedKillsValueProperty);
            set => SetValue(SharedKillsValueProperty, value);
        }

        public KillsTuple()
        {
            InitializeComponent();
            this.DataContext = this;

            KillsValue = "KillsTuple";
            SharedKillsValue = "KillsTuple";
        }
    }
}
