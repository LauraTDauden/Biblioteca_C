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
        //string consulta = "SELECT * FROM alumnos";
        MySqlCommand command;
        public Queries(String consulta, MySqlConnection con)
        {
            Command = new MySqlCommand(consulta, con);
        }

        public MySqlCommand Command { get => command; set => command = value; }
    }
}
