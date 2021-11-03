using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
    class Connect
    {       
        //string connectionString = "datasource = localhost; database = dad_biblioteca; port = 3306; username = root; password = admin1234";
        private static MySqlConnection con;
        public static Connect connect; //instancia singleton
        private Connect()
        {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["MyUrl"].ConnectionString;
                con.Open();
                MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static MySqlConnection getCon()
        {
            if(con == null)
            {
                connect = new Connect(); 
            }
            return con;
        }
       
    }
}
