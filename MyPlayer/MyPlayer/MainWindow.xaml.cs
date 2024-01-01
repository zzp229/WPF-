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
using System.Windows.Threading;

namespace MyPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        MainWindowViewModel mainWindowViewModel;
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;

            // 快捷键
            //this.KeyDown += MainWindow_KeyDown;
        }

        // 快捷键
        //private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.F)
        //    {
        //        myPlayer.Width = win.ActualWidth;  // container 是 Grid 的名称
        //        myPlayer.Height = win.ActualHeight;
        //    }
        //}


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 绑定MVVM
            mainWindowViewModel = new MainWindowViewModel();
            this.DataContext = mainWindowViewModel;


            timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromMilliseconds(500),
            };
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        // 进度条和视频同步
        private void Timer_Tick(object? sender, EventArgs e)
        {
            seekBar.Value = myPlayer.Position.TotalSeconds;
        }

        private void btnPaly_Click(object sender, RoutedEventArgs e)
        {
            myPlayer.Play();
            Dispatcher.Invoke(new Action(() =>
            {
                this.lblStatus.Content = "播放中";
            }));
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            myPlayer.Pause();
            Dispatcher.Invoke(new Action(() =>
            {
                this.lblStatus.Content = "暂停";
            }));
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            //myPlayer.SpeedRatio += 1;
        }

        // 视频拖拽过来
        private void Window_Drop(object sender, DragEventArgs e)
        {
            // 拖拽过来的是文件
            if (((DataObject)e.Data).GetFileDropList()[0] is string filename)
            {
                myPlayer.Source = new Uri(filename, UriKind.Relative);
                myPlayer.LoadedBehavior = MediaState.Manual;
                myPlayer.UnloadedBehavior = MediaState.Manual;
                myPlayer.Play();
            }
        }

        // 视频开始播放的事件
        private void myPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            TimeSpan timeSpan = myPlayer.NaturalDuration.TimeSpan;
            seekBar.Maximum = timeSpan.TotalSeconds;
            mainWindowViewModel.MediaPosition = myPlayer.Position.TotalSeconds;


            Dispatcher.Invoke(new Action(() =>
            {
                this.lblStatus.Content = "播放中";
            }));
        }


        // 进度拖拽事件
        private void seekBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myPlayer.Position = TimeSpan.FromSeconds(mainWindowViewModel.MediaPosition);
        }

        // 关闭按钮
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button?.Name == "btn_close")
            {
                Application.Current.Shutdown();
            }
            else if (button?.Name == "btn_maximize")
            {
                // 最大化和正常之间取反
                if (this.WindowState == WindowState.Maximized)
                {
                    // 窗口处于最大化状态
                    this.WindowState = WindowState.Normal;
                    myPlayer.Width = SystemParameters.PrimaryScreenWidth / 2;
                    myPlayer.Height = SystemParameters.PrimaryScreenHeight / 2;
                    win.Width = SystemParameters.PrimaryScreenWidth / 2;
                    win.Height = SystemParameters.PrimaryScreenHeight / 2;
                }
                else
                {
                    // 窗口不处于最大化状态
                    win.WindowState = WindowState.Maximized;
                    this.Top = 0;
                    this.Left = 0;
                    myPlayer.Width = SystemParameters.PrimaryScreenWidth;
                    myPlayer.Height = SystemParameters.PrimaryScreenHeight;
                    win.Width = SystemParameters.PrimaryScreenWidth;
                    win.Height = SystemParameters.PrimaryScreenHeight;
                }

            }
            else
            {
                this.WindowState = WindowState.Minimized;
            }
        }



        
        private void MediaButton_Click(object sender, RoutedEventArgs e)
        {
            // 开着的就关掉
            if (MediaPopup.IsOpen)
            {
                MediaPopup.IsOpen = false;
            } else
            {
                MediaPopup.IsOpen = true;
            }
        }

        // 选择文件
        private void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            // 实现选择文件的功能
        }

        // 选择文件夹
        private void SelectFolder_Click(object sender, RoutedEventArgs e)
        {
            // 实现选择文件夹的功能
        }



        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        private void ToggleFullScreen()
        {
            if (mainWindowViewModel.IsFullScreen)
            {
                // 进入全屏模式
                this.WindowStyle = WindowStyle.None;
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                // 退出全屏模式
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                this.WindowState = WindowState.Normal;
            }
        }

        private void ToggleFullScreenExecute()
        {
            mainWindowViewModel.IsFullScreen = !mainWindowViewModel.IsFullScreen;
            ToggleFullScreen();
        }


    }
}
