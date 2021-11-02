using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
    class Connect
    {
        string connectionString = "datasource = localhost; database = dad_biblioteca; port = 3306; username = root; password = admin1234";
        MySqlConnection con;
        public Connect()
        {
            try
            {
                Con = new MySqlConnection(connectionString);
                Con.Open();
                MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MySqlConnection Con { get => con; set => con = value; }
    }
}
