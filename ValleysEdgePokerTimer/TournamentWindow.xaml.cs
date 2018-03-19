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
using System.Windows.Shapes;

namespace ValleysEdgePokerTimer
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class TournamentWindow : Window
    {
        private List<RoundOfPlay> rounds_ = new List<RoundOfPlay>();

        public TournamentWindow()
        {
            InitializeComponent();
            rounds_.Add(new RoundOfPlay(60, 10, 20));

            listBox.ItemsSource = rounds_;
        }
    }
}
