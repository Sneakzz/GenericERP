using System;
using System.Collections.Generic;
using System.Data;
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
             FillCmb();
        }

        private void btnLaden_Click(object sender, RoutedEventArgs e)
        {
         
        }

        void FillCmb()
        {
            cmbLand.Items.Add("België");
        }

        private void btnKlantAanmaken_Click(object sender, RoutedEventArgs e)
        {
            string connetionString = null;
            string sql = null;

            // All the info required to reach your db. See connectionstrings.com
            connetionString = "Server=DESKTOP-RE8EGMK\\SQLEXPRESS; Database=ERP;Trusted_Connection=True";

            // Prepare a proper parameterized query 
            sql = "insert into Klanten ([voornaam], [familienaam], [gsm], [email], [adres], [stad], [postcode], [country]) values(@first,@last,gsm,@email,@adres,@stad,@postcode,@country)";

            // Create the connection (and be sure to dispose it at the end)
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    cnn.Open();

                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@first", SqlDbType.NVarChar).Value = txtNaam.Text;
                        cmd.Parameters.Add("@last", SqlDbType.NVarChar).Value = txtFamilieNaam.Text;
                        cmd.Parameters.Add("@gsm", SqlDbType.NChar).Value = txtGsm.Text;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                        cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = txtAdres.Text;
                        cmd.Parameters.Add("@stad", SqlDbType.VarChar).Value = txtStad.Text;
                        cmd.Parameters.Add("@postcode", SqlDbType.Int.ToString()).Value = txtPostcode.Text;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = cmbLand.SelectedItem;
                        

                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Row inserted!!");
                        else
                            // Well this should never really happen
                            MessageBox.Show("No row inserted");
                    }
                }



                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
        }
        }
    }

