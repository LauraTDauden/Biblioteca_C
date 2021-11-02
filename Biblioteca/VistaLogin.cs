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
    public partial class VistaLogin : Form
    {
        Queries query;
        Connect con;
        public VistaLogin()
        {
            con = new Connect();
            InitializeComponent();
            button_login.Click += new System.EventHandler(this.login);
        }

        private void login(object sender, EventArgs e)
        {
            MessageBox.Show("Login!");
        }

    }
}
