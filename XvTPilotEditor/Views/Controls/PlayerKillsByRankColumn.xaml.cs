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
using static XvTPilotEditor.ViewModels.PlayerKillsByRankViewModel;

namespace XvTPilotEditor.Views.Controls
{
    /// <summary>
    /// Interaction logic for PlayerKillsByRankColumn.xaml
    /// </summary>
    public partial class PlayerKillsByRankColumn : UserControl
    {
        //public static readonly DependencyProperty PlayerKillsByRankValueProperty = DependencyProperty.Register("PlayerKillsByRankValue", typeof(Dictionary<PilotRating, PlayerKillByRankItem>), typeof(PlayerKillsByRankColumn));
        //public Dictionary<PilotRating, PlayerKillByRankItem> PlayerKillsByRankValue
        //{
        //    get => (Dictionary<PilotRating, PlayerKillByRankItem>)GetValue(PlayerKillsByRankValueProperty);
        //    set => SetValue(PlayerKillsByRankValueProperty, value);
        //}

        public PlayerKillsByRankColumn()
        {
            InitializeComponent();
        }
    }
}
