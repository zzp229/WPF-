using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace MyPlayer
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        
        public MainWindowViewModel()
        {
            ToggleMediaStretchCommand = new RelayCommand(ToggleMediaStretchExecute);

            ToggleFullScreenCommand = new RelayCommand(ToggleFullScreenExecute);
        }



        #region Property
        private double mediaPosition;

        public double MediaPosition
        {
            get { return mediaPosition; }
            set 
            { 
                mediaPosition = value; 
                OnPropertyChanged(nameof(MediaPosition));
            }
        }

        #endregion


        #region Command
        public ICommand ToggleMediaStretchCommand { get; private set; }
        private Stretch mediaStretch = Stretch.Uniform;
        #endregion



        private void ToggleMediaStretchExecute()
        {
            // 切换MediaElement的Stretch属性
            if (mediaStretch == Stretch.Uniform)
            {
                mediaStretch = Stretch.Fill;
            }
            else
            {
                mediaStretch = Stretch.Uniform;
            }

            OnPropertyChanged(nameof(MediaStretch));

            Debug.WriteLine("点击了F");
        }

        public Stretch MediaStretch
        {
            get { return mediaStretch; }
        }



        #region MvvmLight自带的
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion




        #region 处理全屏
        private bool isFullScreen = false;

        public bool IsFullScreen
        {
            get { return isFullScreen; }
            set
            {
                if (isFullScreen != value)
                {
                    isFullScreen = value;
                    OnPropertyChanged(nameof(IsFullScreen));
                }
            }
        }

        public ICommand ToggleFullScreenCommand { get; private set; }


        private void ToggleFullScreenExecute()
        {
            IsFullScreen = !IsFullScreen;
        }
        #endregion




    }
}
