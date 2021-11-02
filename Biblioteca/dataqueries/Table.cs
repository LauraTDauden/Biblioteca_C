using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    class Table
    {
        MySqlDataAdapter adapt;
        public Table(MySqlCommand command, DataGridView dataGrid)
        {
            adapt = new MySqlDataAdapter();
            adapt.SelectCommand = command;

            DataTable dtable = new DataTable();
            adapt.Fill(dtable);
            dataGrid.DataSource = dtable;
        }
    }
}
