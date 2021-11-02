using Biblioteca.dto;
using System;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class VistaLogin : Form
    {
        Queries query;
        Connect con;
        Usuario usuario;
        public VistaLogin()
        {
            con = new Connect();
            InitializeComponent();
            button_login.Click += new System.EventHandler(this.login);
            button_salir.Click += new System.EventHandler(this.salir);
        }

        private void login(object sender, EventArgs e)
        {
            if (validar())
            {
                MessageBox.Show("CORRECTO");
                
                //PARA OCULTAR UNA VISTA Y MOSTRAR OTRA NUEVA:
                ViewAlumnos view = new ViewAlumnos();
                view.Con = con;
                this.Hide();
                view.Visible = true;
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña introducidos no son correctos, pruebe de nuevo.");
            }
            query.closeReader();

        }

        private void salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargarUsuario()
        {
            usuario = new Usuario();
            usuario.nombreUsuario = textBox_user.Text.Trim();
            usuario.clave = textBox_password.Text.Trim();
        }

        private Boolean validar()
        {
            cargarUsuario();
            query = new Queries();
            //var sql = "SELECT * FROM usuarios WHERE usuario = '" + usuario.nombreUsuario + "' and clave = '" + usuario.clave + "'";
            var sql = "SELECT * FROM usuarios WHERE usuario = @usuario and clave = @clave";
            query.createCommand(sql, con.Con);
            query.Command.Parameters.AddWithValue("@usuario", usuario.nombreUsuario);
            query.Command.Parameters.AddWithValue("@clave", usuario.clave); 
            query.Reader = query.Command.ExecuteReader();
            return query.Reader.Read();            
        }

    }
}
