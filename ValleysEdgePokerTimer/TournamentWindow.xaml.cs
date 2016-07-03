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
    /// Interaction logic for TournamentWindow.xaml
    /// </summary>
    public partial class TournamentWindow : Window
    {
        private const int kRoundNum = 8;

        private List<Viewbox> round_labels = new List<Viewbox>(kRoundNum);
        private List<Viewbox> small_blind_labels = new List<Viewbox>(kRoundNum);
        private List<Viewbox> small_blind_inputs = new List<Viewbox>(kRoundNum);
        private List<Viewbox> large_blind_labels = new List<Viewbox>(kRoundNum);
        private List<Viewbox> large_blind_inputs = new List<Viewbox>(kRoundNum);
        private List<Viewbox> duration_labels = new List<Viewbox>(kRoundNum);
        private List<Viewbox> duration_inputs = new List<Viewbox>(kRoundNum);

        public TournamentWindow()
        {
            InitializeComponent();

            for(int i = 0; i < kRoundNum; i++)
            {
                //round label
                TextBlock round_lb = new TextBlock();
                Viewbox round_lb_view = new Viewbox();

                round_lb.Text = "Round " + i;

                Grid.SetRow(round_lb_view, i);
                Grid.SetColumn(round_lb_view, 1);

                round_lb_view.Child = round_lb;
                round_labels.Add(round_lb_view);

                main_grid.Children.Add(round_labels.ElementAt(i));

                //small blind label
                TextBlock small_blind_lb = new TextBlock();
                Viewbox small_blind_lb_view = new Viewbox();

                small_blind_lb.Text = "Small Blind";

                Grid.SetRow(small_blind_lb_view, i);
                Grid.SetColumn(small_blind_lb_view, 2);

                small_blind_lb_view.Child = small_blind_lb;
                small_blind_labels.Add(small_blind_lb_view);

                main_grid.Children.Add(small_blind_labels.ElementAt(i));

                //small blind input
                TextBox small_blind_in = new TextBox();
                Viewbox small_blind_in_view = new Viewbox();

                small_blind_in.Text = "0";

                Grid.SetRow(small_blind_in_view, i);
                Grid.SetColumn(small_blind_in_view, 3);

                small_blind_in_view.Child = small_blind_in;
                small_blind_inputs.Add(small_blind_in_view);

                main_grid.Children.Add(small_blind_inputs.ElementAt(i));

                //large blind label
                TextBlock large_blind_lb = new TextBlock();
                Viewbox large_blind_lb_view = new Viewbox();

                large_blind_lb.Text = "Large Blind";

                Grid.SetRow(large_blind_lb_view, i);
                Grid.SetColumn(large_blind_lb_view, 4);

                large_blind_lb_view.Child = large_blind_lb;
                large_blind_labels.Add(large_blind_lb_view);

                main_grid.Children.Add(large_blind_labels.ElementAt(i));

                //large blind input
                TextBox large_blind_in = new TextBox();
                Viewbox large_blind_in_view = new Viewbox();

                large_blind_in.Text = "0";

                Grid.SetRow(large_blind_in_view, i);
                Grid.SetColumn(large_blind_in_view, 5);

                large_blind_in_view.Child = large_blind_in;
                large_blind_inputs.Add(large_blind_in_view);

                main_grid.Children.Add(large_blind_inputs.ElementAt(i));

                //duration label
                TextBlock duration_lb = new TextBlock();
                Viewbox duration_lb_view = new Viewbox();

                duration_lb.Text = "Duration";

                Grid.SetRow(duration_lb_view, i);
                Grid.SetColumn(duration_lb_view, 6);

                duration_lb_view.Child = duration_lb;
                duration_labels.Add(duration_lb_view);

                main_grid.Children.Add(duration_labels.ElementAt(i));

                //duration input
                TextBox duration_in = new TextBox();
                Viewbox duration_in_view = new Viewbox();

                duration_in.Text = "0";

                Grid.SetRow(duration_in_view, i);
                Grid.SetColumn(duration_in_view, 7);

                duration_in_view.Child = duration_in;
                duration_inputs.Add(duration_in_view);

                main_grid.Children.Add(duration_inputs.ElementAt(i));
            }
        }
    }
}
