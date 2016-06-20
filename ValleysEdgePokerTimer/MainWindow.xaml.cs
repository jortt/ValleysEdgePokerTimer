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

namespace ValleysEdgePokerTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            PlayBtn.Source = new BitmapImage(new Uri("/res/Play2.png", UriKind.Relative));
        }

        private void PlayBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            PlayBtn.Source = new BitmapImage(new Uri("/res/Play1.png", UriKind.Relative));
        }

        private void StopBtn_MouseEnter(object sender, MouseEventArgs e)
        {
           StopBtn.Source = new BitmapImage(new Uri("/res/Stop2.png", UriKind.Relative));
        }

        private void StopBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            StopBtn.Source = new BitmapImage(new Uri("/res/Stop1.png", UriKind.Relative));
        }

        private void RewindBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            RewindBtn.Source = new BitmapImage(new Uri("/res/Rwd2.png", UriKind.Relative));
        }

        private void RewindBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            RewindBtn.Source = new BitmapImage(new Uri("/res/Rwd1.png", UriKind.Relative));
        }

        private void FastForwardBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            FastForwardBtn.Source = new BitmapImage(new Uri("/res/Fwd2.png", UriKind.Relative));
        }

        private void FastForwardBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            FastForwardBtn.Source = new BitmapImage(new Uri("/res/Fwd1.png", UriKind.Relative));
        }
    }
}
