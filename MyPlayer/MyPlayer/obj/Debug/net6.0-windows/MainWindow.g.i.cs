// Updated by XamlIntelliSenseFileGenerator 2024/1/2 16:40:54
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5FCD4FDBBA551DE513E8C15ABDF0054750A84004"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MyPlayer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MyPlayer
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid container;

#line default
#line hidden


#line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label media_palying;

#line default
#line hidden


#line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_minimize;

#line default
#line hidden


#line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_maximize;

#line default
#line hidden


#line 49 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;

#line default
#line hidden


#line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MediaButton;

#line default
#line hidden


#line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup MediaPopup;

#line default
#line hidden


#line 69 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myPlayer;

#line default
#line hidden


#line 81 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider seekBar;

#line default
#line hidden


#line 89 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStatus;

#line default
#line hidden


#line 105 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPaly;

#line default
#line hidden


#line 107 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPause;

#line default
#line hidden


#line 109 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyPlayer;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.win = ((MyPlayer.MainWindow)(target));

#line 12 "..\..\..\MainWindow.xaml"
                    this.win.Drop += new System.Windows.DragEventHandler(this.Window_Drop);

#line default
#line hidden
                    return;
                case 2:
                    this.container = ((System.Windows.Controls.Grid)(target));

#line 33 "..\..\..\MainWindow.xaml"
                    this.container.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);

#line default
#line hidden
                    return;
                case 3:
                    this.media_palying = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.btn_minimize = ((System.Windows.Controls.Button)(target));

#line 47 "..\..\..\MainWindow.xaml"
                    this.btn_minimize.Click += new System.Windows.RoutedEventHandler(this.Close_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btn_maximize = ((System.Windows.Controls.Button)(target));

#line 48 "..\..\..\MainWindow.xaml"
                    this.btn_maximize.Click += new System.Windows.RoutedEventHandler(this.Close_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btn_close = ((System.Windows.Controls.Button)(target));

#line 49 "..\..\..\MainWindow.xaml"
                    this.btn_close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.MediaButton = ((System.Windows.Controls.Button)(target));

#line 55 "..\..\..\MainWindow.xaml"
                    this.MediaButton.Click += new System.Windows.RoutedEventHandler(this.MediaButton_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.MediaPopup = ((System.Windows.Controls.Primitives.Popup)(target));
                    return;
                case 9:

#line 58 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SelectFile_Click);

#line default
#line hidden
                    return;
                case 10:

#line 59 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SelectFolder_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.myPlayer = ((System.Windows.Controls.MediaElement)(target));

#line 73 "..\..\..\MainWindow.xaml"
                    this.myPlayer.MediaOpened += new System.Windows.RoutedEventHandler(this.myPlayer_MediaOpened);

#line default
#line hidden
                    return;
                case 12:
                    this.seekBar = ((System.Windows.Controls.Slider)(target));

#line 85 "..\..\..\MainWindow.xaml"
                    this.seekBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.seekBar_ValueChanged);

#line default
#line hidden
                    return;
                case 13:
                    this.lblStatus = ((System.Windows.Controls.Label)(target));
                    return;
                case 14:
                    this.btnPaly = ((System.Windows.Controls.Button)(target));

#line 106 "..\..\..\MainWindow.xaml"
                    this.btnPaly.Click += new System.Windows.RoutedEventHandler(this.btnPaly_Click);

#line default
#line hidden
                    return;
                case 15:
                    this.btnPause = ((System.Windows.Controls.Button)(target));

#line 108 "..\..\..\MainWindow.xaml"
                    this.btnPause.Click += new System.Windows.RoutedEventHandler(this.btnPause_Click);

#line default
#line hidden
                    return;
                case 16:
                    this.btnStop = ((System.Windows.Controls.Button)(target));

#line 110 "..\..\..\MainWindow.xaml"
                    this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window win;
    }
}

