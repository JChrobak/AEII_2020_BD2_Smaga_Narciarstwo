﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

namespace E_SkiLift.Windows
{
    /// <summary>
    /// Interaction logic for GatePage.xaml
    /// </summary>
    public partial class GatePage : Page
    {
        private readonly MainWindow parentWindow;

        public GatePage(MainWindow parentWindow)
        {
            InitializeComponent();
            this.parentWindow = parentWindow;
        }

        private void validateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ticket validated.\nNOT YET IMPLEMENTED");
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.ShowLoginPage();
        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                parentWindow.ShowSkierSummaryPage(int.Parse(ticketIDSummary.Text));
            } catch(FormatException ex)
            {
                MessageBox.Show("Invalid ticket ID!");
            }
        }
    }
}
