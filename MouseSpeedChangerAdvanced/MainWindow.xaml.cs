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
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MouseSpeedChangerAdvanced
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public NotifyIcon icon = new NotifyIcon();
       
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModels();
            ShowInTaskbar = false;
            icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(@"./megu_fvK_icon.ico");
            icon.DoubleClick += (s, args) => ShowMainWindow();
            icon.Visible = true;
            CreateContextMenu();
        }
        private void CreateContextMenu()
        {
            icon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            icon.ContextMenuStrip.Items.Add("App").Click += (s, e) => ShowMainWindow();
            icon.ContextMenuStrip.Items.Add("Exit").Click += (s, e) => ExitApplication();
        }
        private void ShowMainWindow()
        {
            if (this.IsVisible)
            {
                if (this.WindowState == WindowState.Minimized)
                {
                    this.WindowState = WindowState.Normal;
                }
                this.Activate();
            }
            else
            {
                this.Show();
            }
        }
        private void ExitApplication()
        {
            System.Windows.Application.Current.Shutdown();
        }
      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ExitApplication();
        }
    }
}
