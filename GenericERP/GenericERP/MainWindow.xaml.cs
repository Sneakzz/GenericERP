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

namespace GenericERP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        string mainLogin = "Admin";
        string password = "Admin";

        private void btnLogi_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text != mainLogin || pwbPassword.Password != password)
            {
                MessageBox.Show("verkeerde login naam");               
            }
         
            Dashbord p  = new Dashbord();
            p.Show();
            MainWindow c = new MainWindow();
            App.Current.MainWindow.Close();
           
        }


        private void pwbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLogin.Text != mainLogin || pwbPassword.Password != password)
            {
                MessageBox.Show("verkeerde login naam");
            }

            Dashbord p = new Dashbord();
            p.Show();
            MainWindow c = new MainWindow();
            App.Current.MainWindow.Close();
        }
    }
}
