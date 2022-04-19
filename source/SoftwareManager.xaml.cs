using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GEcosystem_Hub
{
    /// <summary>
    /// Logica di interazione per SoftwareManager.xaml
    /// </summary>
    public partial class SoftwareManager : Window
    {
        public SoftwareManager()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void launch1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files/Google/Chrome/Application/Chrome.exe");
        }

        private void download1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.google.com/intl/it_it/chrome/",
                UseShellExecute = true
            });
        }
    }
}
