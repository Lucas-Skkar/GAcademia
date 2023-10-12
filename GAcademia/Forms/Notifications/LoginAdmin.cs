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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void bnt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("config.txt"))
            {
                writer.WriteLine($"ID={textBoxUsuario.Text}");
                writer.WriteLine($"Pass={textBoxSenha.Text}");
            }
        }
    }
}
