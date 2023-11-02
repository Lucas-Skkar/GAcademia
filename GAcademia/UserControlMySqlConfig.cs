using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace GAcademia
{
    public partial class UserControlMySqlConfig : UserControl
    {
        public UserControlMySqlConfig()
        {
            InitializeComponent();
            textBoxServidor.Text = Database.Connect.servidor;
            textBoxBancoDados.Text = Database.Connect.bancoDados;
            textBoxUsuario.Text = Database.Connect.usuario;
            textBoxSenha.Text = Database.Connect.senha;
            textBoxPorta.Text = Database.Connect.porta;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("dBconfig.txt"))
            {
                writer.WriteLine($"servidor={textBoxServidor.Text}");
                writer.WriteLine($"bancoDados={textBoxBancoDados.Text}");
                writer.WriteLine($"usuario={textBoxUsuario.Text}");
                writer.WriteLine($"senha={textBoxSenha.Text}");
                writer.WriteLine($"porta={textBoxPorta.Text}");
            }
        }
 
    }
}
