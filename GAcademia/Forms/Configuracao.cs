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
using static GAcademia.UserControlMySqlConfig;

namespace GAcademia.Forms
{
    public partial class Configuracao : Form
    {
        private Form activeForm;
        public Configuracao()
        {
            InitializeComponent();
            PanelTrocarLoginPadrao.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelNewLogin.Visible = false;

            var Priv = new List<Privilegio>();
            Priv.Add(new Privilegio() { privId = 1, privNome = "Admin" });
            Priv.Add(new Privilegio() { privId = 2, privNome = "Instrutor" });

            ComboBoxPrivilegio.DataSource = Priv;
            ComboBoxPrivilegio.DisplayMember = "privNome";
            ComboBoxPrivilegio.Text = "Selecione o tipo de usuário";
        }

        private class Privilegio
        {
            public int privId { get; set; }
            public string privNome { get; set; }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildrens.Controls.Add(childForm);
            this.panelChildrens.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.Notifications.LoginAdmin(), sender);
            PanelTrocarLoginPadrao.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelNewLogin.Visible = false;

        }

        private void btn_db_Click(object sender, EventArgs e)
        {
            PanelMySqlConfig.Visible = true;
            PanelTrocarLoginPadrao.Visible = false;
            PanelNewLogin.Visible = false;
        }

        private void btn_NewLogin_Click(object sender, EventArgs e)
        {
            PanelNewLogin.Visible = true;
            PanelTrocarLoginPadrao.Visible = false;
            PanelMySqlConfig.Visible = false;
        }

        private void btn_testConnect_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
                con.Open();
                con.Close();
                MessageBox.Show("Conexão bem sucedida!");
            }
            catch
            {
                MessageBox.Show("Falha na conexão!");
            }
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ID = textBoxUsuario.Text;
            string Pass = textBoxSenha.Text;

            /* using (StreamWriter writer = new StreamWriter("config.txt"))
             {
                 writer.WriteLine($"ID={textBoxUsuario.Text}");
                 writer.WriteLine($"Pass={textBoxSenha.Text}");
             }*/
            
            string criptografar = $"{ID}\n{Pass}";

            string encryptedData = DataEncryptor.Encrypt(criptografar);

            using (StreamWriter writer = new StreamWriter("config.txt"))
            {
                writer.Write(encryptedData);
            }
            
            MessageBox.Show("Senha alterada com sucesso. Caso esqueça a senha, delete o arquivo config.txt na pasta raiz");
        }

        private void bnt_salvarN_Click(object sender, EventArgs e)
        {
            if(textBoxInfLoginN.Text !="" && textBoxSenhaN.Text !="" && ComboBoxPrivilegio.SelectedIndex != 0)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
                    con.Open();

                    string sql = "INSERT INTO tbusuario (`login`, `senha`, `userType`) VALUES (@Login, @Senha, @Tipo)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Login", textBoxInfLoginN.Text);
                    cmd.Parameters.AddWithValue("@Senha", textBoxSenhaN.Text);
                    cmd.Parameters.AddWithValue("@Tipo", ComboBoxPrivilegio.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário adicionado com sucesso!");
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Erro! Banco de dados desconectado.");
                }
            }
            else
            {
                MessageBox.Show("Erro! Um ou mais campos estão vazios");
            }
            
        }
    }
}
