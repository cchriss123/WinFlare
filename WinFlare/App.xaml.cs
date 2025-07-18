﻿using System.Windows;
using Forms = System.Windows.Forms;

namespace WinFlare
{
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = new MainWindow();
            mainWindow.Show(); 
            mainWindow.Activate(); 


            Console.WriteLine("WinFlare started successfully.");
            Console.WriteLine("Cash Locations: " + string.Join(", ", Casher.CashLocations()));



            mainWindow.StateChanged += (s, args) =>
            {
                if (mainWindow.WindowState == WindowState.Minimized)
                {
                    mainWindow.Hide();
                }
            };

            var notifyIcon = new Forms.NotifyIcon
            {
                Icon = new Icon("Resources/icon.ico"),
                Visible = true,
                Text = "WinFlare",
            };

            notifyIcon.Click += (sender, args) =>
            {
                mainWindow.Show();
                mainWindow.WindowState = WindowState.Normal;
                mainWindow.Activate();
            };

        }
    }
}
