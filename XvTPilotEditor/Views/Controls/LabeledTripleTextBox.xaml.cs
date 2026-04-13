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
    /// Interaction logic for LabeledTripleTextBox.xaml
    /// </summary>
    public partial class LabeledTripleTextBox : UserControl
    {
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string), typeof(LabeledTripleTextBox), new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty TextBox1ContentProperty =
            DependencyProperty.Register(nameof(TextBox1Content), typeof(string), typeof(LabeledTripleTextBox), new PropertyMetadata(string.Empty));

        public string TextBox1Content
        {
            get => (string)GetValue(TextBox1ContentProperty);
            set => SetValue(TextBox1ContentProperty, value);
        }

        public static readonly DependencyProperty TextBox2ContentProperty =
            DependencyProperty.Register(nameof(TextBox2Content), typeof(string), typeof(LabeledTripleTextBox), new PropertyMetadata(string.Empty));

        public string TextBox2Content
        {
            get => (string)GetValue(TextBox2ContentProperty);
            set => SetValue(TextBox2ContentProperty, value);
        }

        public static readonly DependencyProperty TextBox3ContentProperty =
            DependencyProperty.Register(nameof(TextBox3Content), typeof(string), typeof(LabeledTripleTextBox), new PropertyMetadata(string.Empty));

        public string TextBox3Content
        {
            get => (string)GetValue(TextBox3ContentProperty);
            set => SetValue(TextBox3ContentProperty, value);
        }

        public LabeledTripleTextBox()
        {
            InitializeComponent();
        }
    }
}
