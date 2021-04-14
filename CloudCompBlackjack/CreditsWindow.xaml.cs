﻿using System;
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
using System.Windows.Shapes;

namespace CloudCompBlackjack
{
    /// <summary>
    /// Interaction logic for CreditsWindow.xaml
    /// </summary>
    public partial class CreditsWindow : Window
    {
        public CreditsWindow()
        {
            InitializeComponent();
            this.WindowState = System.Windows.WindowState.Maximized;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnClipboard_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("https://github.com/jackMalone2001/CloudCompBlackjack");
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
