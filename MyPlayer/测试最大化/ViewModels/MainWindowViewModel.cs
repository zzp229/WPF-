using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using 测试最大化.ViewModels.Helper;

namespace 测试最大化.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public MainWindowViewModel()
        {
            closeCommand = new RelayCommand(ExecuteCloseCommand, CanExecuteCloseCommand);
            pauseCommand = new RelayCommand(pauseMethod, CanExecuteCloseCommand);
            startCommand = new RelayCommand(startMethod, CanExecuteCloseCommand);
            popMediaIsOpenCmd = new RelayCommand(popMediaIsOpenMethod, CanExecuteCloseCommand);
        }




        #region CommandMethod
        /// <summary>
        /// 标记是否在弹出
        /// </summary>
        /// <param name="obj"></param>
        private void popMediaIsOpenMethod(object obj)
        {
            if (!popMediaIsOpen)
                popMediaIsOpen = !popMediaIsOpen;
            else
            {
                Debug.WriteLine("已经打开了");
            }
        }

        private void startMethod(object obj) => startMediaEvent?.Invoke();
        private bool CanExecuteCloseCommand(object obj) => true;
        private void ExecuteCloseCommand(object obj) => Application.Current.Shutdown();
        private void pauseMethod(object obj) => pauseMediaEvent?.Invoke();
        #endregion



        #region Property

        private Visibility btnVisiable;
        /// <summary>
        /// 控制按钮是否显示
        /// </summary>
        public Visibility BtnVisiable
        {
            get { return btnVisiable; }
            set
            {
                btnVisiable = value;
                OnPropertyChanged(nameof(BtnVisiable));
            }
        }

        private bool _popMediaIsOpen;
        /// <summary>
        /// 是否拉开
        /// </summary>
        public bool popMediaIsOpen
        {
            get { return _popMediaIsOpen; }
            set 
            { 
                _popMediaIsOpen = value; 
                OnPropertyChanged(nameof(popMediaIsOpen));
            }
        }

        private bool _isVideoFullscreen;
        /// <summary>
        /// 视频是否全屏
        /// </summary>
        public bool isVideoFullscreen
        {
            get => _isVideoFullscreen;
            set
            {
                _isVideoFullscreen = value;
                OnPropertyChanged(nameof(isVideoFullscreen));
                // 可以在这里触发一些状态改变的事件
            }
        }

        #endregion

        #region Command

        public ICommand closeCommand {  get; }
        public ICommand pauseCommand { get; }
        public ICommand startCommand { get; }
        public ICommand popMediaIsOpenCmd { get; }
        #endregion



        #region Action (给ViewModel订阅，在这里调用Command)
        // 停止播放事件
        public event Action pauseMediaEvent;
        public event Action startMediaEvent;
        #endregion




        // 通知属性要实现的
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
