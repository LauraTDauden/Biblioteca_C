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
        MySqlDataReader reader;
        public Queries()
        {

        }
        /*
         * NOTA ACERCA DE LOS MÉTODOS DE LAS QUERIES:
         * ExecuteScalar: devuelve un solo valor
         * ExecuteReader: devuelve un resultset
         * ExecuteNonQuery: no devuelve resultados (devuelve solo el número
         * de columnas afectadas), muy usado con UPDATE, INSERT, etc.
         */ 

        public MySqlCommand Command { get => command; set => command = value; }
        public MySqlDataReader Reader { get => reader; set => reader = value; }

        public void createCommand(String sql, MySqlConnection con)
        {
            Command = new MySqlCommand(sql, con);
        }

        public void updateData(String sql, MySqlConnection con)
        {
            Command = new MySqlCommand(sql, con);
            reader = command.ExecuteReader();
            closeReader();
        }

        public void closeReader()
        {
            if (reader != null)
            {
                reader.Close();
            }
        }

    }
}


