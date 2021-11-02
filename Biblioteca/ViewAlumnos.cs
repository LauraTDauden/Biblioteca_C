using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class ViewAlumnos : Form
    {
        Queries query;
        Connect con;
        public ViewAlumnos()
        {
            con = new Connect();
            InitializeComponent();
            button_Alta.Click += new System.EventHandler(this.Alta);
            button_Baja.Click += new System.EventHandler(this.Baja);
            button_Modificar.Click += new System.EventHandler(this.Modificar);
            button_Listar.Click += new System.EventHandler(this.Listar);
            textBox_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buscar);
        }

        private void Alta(object sender, EventArgs e)
        {
            MessageBox.Show("¡ALTA!");
        }

        private void Baja(object sender, EventArgs e)
        {
            MessageBox.Show("¡BAJA!");
        }

        private void Modificar(object sender, EventArgs e)
        {
            MessageBox.Show("¡MODIFICAR!");
        }

        private void Listar(object sender, EventArgs e)
        {
            query = new Queries();
            if (string.IsNullOrWhiteSpace(textBox_buscar.Text))
            {
                query.createCommand("SELECT * FROM alumnos", con.Con);
            }
            else
            {
                String texto = textBox_buscar.Text.Trim();
                query.createCommand("SELECT * FROM alumnos WHERE dni LIKE '" + texto + "%'"
                    + "OR nombre LIKE '" + texto + "%'"
                    + "OR apellido1 LIKE '" + texto + "%'"
                    + "OR apellido2 LIKE '" + texto + "%'", con.Con);
            }
            new Table(query.Command, dataGrid);
        }

        private void Buscar(object sender, EventArgs e)
        {
            query = new Queries();
            String texto = textBox_buscar.Text.Trim();
            query.createCommand("SELECT * FROM alumnos WHERE dni LIKE '" + texto + "%'"
                    + "OR nombre LIKE '" + texto + "%'"
                    + "OR apellido1 LIKE '" + texto + "%'"
                    + "OR apellido2 LIKE '" + texto + "%'", con.Con);
            new Table(query.Command, dataGrid);
        }
    }
}
