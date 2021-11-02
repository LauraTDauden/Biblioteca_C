using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Queries
    {
        MySqlCommand command;
        public Queries()
        {

        }

        public MySqlCommand Command { get => command; set => command = value; }

        public void readData(String sql, MySqlConnection con)
        {
            Command = new MySqlCommand(sql, con);
        }

        public void updateData(String sql, MySqlConnection con)
        {
            command = new MySqlCommand(sql, con);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

    }
}


