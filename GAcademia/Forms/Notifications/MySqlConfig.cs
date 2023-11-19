using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace GAcademia.Forms.Notifications
{
    public partial class MySqlConfig : KryptonForm
    {
        public MySqlConfig()
        {
            InitializeComponent();
        }

        // Carrega o LoadFile e testa a conexão com o banco de dados.
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
                MessageBox.Show("Servidor não encontrado, tenha certeza de ter salvo as informações antes de clicar em Conectar e que o servidor esteja ligado.");
            }
        }
       
    }
}
