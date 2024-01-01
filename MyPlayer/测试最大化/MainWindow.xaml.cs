using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using 测试最大化.ViewModels;

namespace 测试最大化
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;

            this.KeyDown += Window_KeyDown;
            
        }


        // 这个快捷键好像没有办法抽离到ViewModel
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F)
            {
                if (this.WindowState != System.Windows.WindowState.Maximized)
                {
                    // 隐藏其他 UI 元素
                    viewModel.BtnVisiable = Visibility.Collapsed;   // 隐藏

                    // 修改 Grid 的行定义，以便 MediaElement 可以占据整个 Grid
                    Grid.SetRowSpan(myBorder, 3);   
                    this.MainGrid.RowDefinitions[0].Height = new GridLength(0);
                    this.MainGrid.RowDefinitions[2].Height = new GridLength(0);

                    // 设置窗口状态为最大化
                    this.WindowState = System.Windows.WindowState.Maximized;
                }
                else
                {
                    // 恢复其他 UI 元素的可见性
                    viewModel.BtnVisiable = Visibility.Visible;

                    // 恢复 Grid 的行定义
                    Grid.SetRowSpan(myBorder, 1);
                    this.MainGrid.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
                    this.MainGrid.RowDefinitions[1].Height = new GridLength(9, GridUnitType.Star);
                    this.MainGrid.RowDefinitions[2].Height = new GridLength(1, GridUnitType.Star);

                    // 恢复窗口状态
                    this.WindowState = System.Windows.WindowState.Normal;
                }
            }
        }




        private void a_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Maximized;
        }


        private void b_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Normal;
        }

        private void Window_Drop(object sender, DragEventArgs e)
        {
            if (((DataObject)e.Data).GetFileDropList()[0] is string filename)
            {
                myMediaElement.Source = new Uri(filename, UriKind.Relative);
                myMediaElement.LoadedBehavior = MediaState.Manual;
                myMediaElement.UnloadedBehavior = MediaState.Manual;
                myMediaElement.Play();
            }
        }
    }
}
