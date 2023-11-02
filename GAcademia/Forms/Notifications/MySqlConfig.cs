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
using ComponentFactory.Krypton.Toolkit;

namespace GAcademia.Forms.Notifications
{
    public partial class MySqlConfig : KryptonForm
    {
        public MySqlConfig()
        {
            InitializeComponent();
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
