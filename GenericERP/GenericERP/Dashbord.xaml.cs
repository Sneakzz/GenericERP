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

namespace GenericERP
{
    /// <summary>
    /// Interaction logic for Dashbord.xaml
    /// </summary>
    public partial class Dashbord : Window
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void btnKlanten_Click(object sender, RoutedEventArgs e)
        {
           Klanten p = new Klanten();
            p.Show();

            Dashbord s = new Dashbord();
            App.Current.MainWindow.Close();
            this.Close();
        }
    }
}
