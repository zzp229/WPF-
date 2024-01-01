using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }



        #region CommandMethod
        private bool CanExecuteCloseCommand(object obj)
        {
            return true;
        }
        private void ExecuteCloseCommand(object obj)
        {
            Application.Current.Shutdown();
        }
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
        #endregion

        #region Command
        public ICommand closeCommand {  get; }
        #endregion




        // 通知属性要实现的
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
