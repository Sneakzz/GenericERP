using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for Klanten.xaml
    /// </summary>
    public partial class Klanten : Window
    {
        public Klanten()
        {
            InitializeComponent();
        }

        private void btnLaden_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void btnKlantAanmaken_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            connectionString = "\\SQLEXPRESS";

            cnn = new SqlConnection(connectionString);
            sql = "insert into Klanten (voornaam, familienaam, gsm, email, adres, stad, postcode, country)";



            try
            {
                cnn.Open();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("ingegeven");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
