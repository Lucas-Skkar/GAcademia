using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAcademia.Forms.Notifications
{
    public partial class MySqlConfig : Form
    {
        public MySqlConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Connect.servidor = "'"+textBoxServidor+"'";
            Database.Connect.bancoDados = "'"+textBoxBancoDados+"'";
            Database.Connect.usuario = "'"+textBoxUsuario+"'";
            Database.Connect.senha = "'"+textBoxSenha+"'";
            Database.Connect.porta = "'"+textBoxPorta+"'";
        }
    }
}
