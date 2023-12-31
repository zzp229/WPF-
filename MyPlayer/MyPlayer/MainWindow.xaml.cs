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

namespace MyPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            myPlayer.Source = new Uri("D:\\desktop\\tmp\\trailer.mp4");
            myPlayer.Play();
        }

        private void btnPaly_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
