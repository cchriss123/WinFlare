using System.Configuration;
using System.Data;
using System.Windows;
using System.Drawing;
using Forms = System.Windows.Forms;

namespace WinFlare
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var notifyIcon = new Forms.NotifyIcon
            {
                Icon = new Icon("Resources/icon.ico"),
                Visible = true,
                Text = "WinFlare"
            };


        }
    }
}
