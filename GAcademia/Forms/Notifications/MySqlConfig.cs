using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void bnt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Database.Connect.LoadFile();

            try
            {
                MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
                con.Open();
                con.Close();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Servidor não encontrado, tenha certeza de ter salvo as informações antes de clicar em Conectar");
            }
        }
    }
}
