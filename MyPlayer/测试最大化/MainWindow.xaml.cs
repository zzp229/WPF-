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
            
            this.Loaded += MainWindow_Loaded;

            this.KeyDown += Window_KeyDown;
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = viewModel;
            // 订阅事件
            viewModel.pauseMediaEvent += () => myMediaElement.Pause();
            viewModel.startMediaEvent += () => myMediaElement.Play();
        }



        WindowState oldWinState;
        // 这个快捷键抽离到ViewModel中比较复杂
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F)
            {
                // 这个是全屏的
                //if (this.WindowState != System.Windows.WindowState.Maximized)
                if (Grid.GetRowSpan(myBorder) == 1)
                {
                    VideoMax();
                }
                else
                {
                    // 恢复其他 UI 元素的可见性
                    viewModel.BtnVisiable = Visibility.Visible;

                    // 恢复 Grid 的行定义
                    Grid.SetRowSpan(myBorder, 1);
                    this.MainGrid.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
                    this.MainGrid.RowDefinitions[1].Height = new GridLength(7, GridUnitType.Star);
                    this.MainGrid.RowDefinitions[2].Height = new GridLength(2, GridUnitType.Star);

                    // 恢复窗口状态
                    this.WindowState = oldWinState;
                }
            }
        }


        // 视频最大化需要的操作
        public void VideoMax()
        {
            // 隐藏其他 UI 元素
            viewModel.BtnVisiable = Visibility.Collapsed;   // 隐藏

            // 修改 Grid 的行定义，以便 MediaElement 可以占据整个 Grid
            Grid.SetRowSpan(myBorder, 3);
            this.MainGrid.RowDefinitions[0].Height = new GridLength(0);
            this.MainGrid.RowDefinitions[2].Height = new GridLength(0);

            // 设置窗口状态为最大化
            oldWinState = WindowState;  // 记录当前窗口状态
            this.WindowState = System.Windows.WindowState.Maximized;
        }




        private void a_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
                this.btn_NormalAndMaximum.Content = "正常";

            } else
            {
                this.WindowState = WindowState.Normal;
                this.btn_NormalAndMaximum.Content = "最大";
            }
            
        }


        private void b_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Normal;
        }

        // 往播放器中拖拽视频处理
        private void Window_Drop(object sender, DragEventArgs e)
        {
            // 可以将文件集合抽离到ViewModel中处理（现在先抽离Source）
            if (((DataObject)e.Data).GetFileDropList()[0] is string filename)
            {
                viewModel.mediaSource = new Uri(filename, UriKind.Relative);    // 直接更新ViewModel的Source绑定，方便后面更新资源
                myMediaElement.LoadedBehavior = MediaState.Manual;
                myMediaElement.UnloadedBehavior = MediaState.Manual;
                myMediaElement.Play();
            }
        }


        //窗口拖动
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        // 有些地方是不需要拖拽的
        private void NoDrag(object sender, MouseButtonEventArgs e) => e.Handled = true;
        
    }
}
