using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

namespace Skrivebord
{
//    private DispatcherTimer timer;
//    private string[] //billeder

//        timer = new DispatcherTimer();
//    timer.interval = TimeSpan.FromMinutes(1);
//        timer.Tick += Timer_Tick;

//        }

//EventPrivateKey void ChangeBackgroundImage();

//SystemParametersInfo(SPI_SETDESKTOPWALLPAPER, 0, imagePath(currentIndex), spif_updateinfile);){ 
//}
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object viewModel;

        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            timer.Tick += new EventHandler(WaitingEvent);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
            //InitializeComponent();
        }

        public void WaitingEvent(object Source , EventArgs e)
        {
            /*    MainWindow win = new MainWindow();
                         this.Hide();
                win.Show();
                timer.Stop(); */
            string image = "C:\\Users\\zbcsioh\\Desktop\\H2\\GUI\\Skrivebord\\Skrivebord\\Images\\billede.jpg";
            SetDesktopBackground(image);
        }

     

        private void Button_Click(object sender, DragEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void ButtonAddImage_Click(object sender, RoutedEventArgs e)
        {
            string image = "C:\\Users\\zbcsioh\\Desktop\\H2\\GUI\\Skrivebord\\Skrivebord\\Images\\Pizza1.jpg";
            SetDesktopBackground(image);

        }

        private void ButtonShowMessage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void ButtonAddText_Click(object sender, RoutedEventArgs e)
        {
            string image2 = "C:\\Users\\zbcsioh\\Desktop\\H2\\GUI\\Skrivebord\\Skrivebord\\Images\\Pizza2.png";
            SetDesktopBackground(image2);
        }
        private void SetDesktopBackground(string sFile_FullPath)
        {
            const int SET_DESKTOP_BACKGROUND = 20;
            const int UPDATE_INI_FILE = 1;
            const int SEND_WINDOWS_INI_CHANGE = 2;

            Win32.SystemParametersInfo(SET_DESKTOP_BACKGROUND, 0,sFile_FullPath, UPDATE_INI_FILE | SEND_WINDOWS_INI_CHANGE);
        }

        private void ButtonAddImage3_Click(object sender, RoutedEventArgs e)
        {
            string image3 = "C:\\Users\\zbcsioh\\Desktop\\H2\\GUI\\Skrivebord\\Skrivebord\\Images\\billede.jpg";
            SetDesktopBackground(image3);
        }
    }
}
