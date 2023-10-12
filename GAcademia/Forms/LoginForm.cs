using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAcademia.Forms
{
    public partial class LoginForm : Form
    {
        string ID;
        string Pass;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();
            Database.Connect.LoadFile();
            LoadAdmin();
        }

        public void LoadAdmin()
        {
            try
            {
                if (File.Exists("config.txt"))
                {
                    string[] linhas = File.ReadAllLines("config.txt");
                    foreach (string linha in linhas)
                    {
                        string[] partes = linha.Split('=');
                        if (partes.Length == 2)
                        {
                            string chave = partes[0];
                            string valor = partes[1];

                            switch (chave)
                            {
                                case "ID":
                                    ID = valor;
                                    break;
                                case "Pass":
                                    Pass = valor;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar valores do arquivo: " + ex.Message);
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string Usuario = tBoxUsuario.Text;
            string Senha = tBoxSenha.Text;

            if (File.Exists("config.txt"))
            {
            }
            else
            {
                ID = "admin";
                Pass = "123456";
            }
            if (Usuario == ID && Senha == Pass)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
                    con.Open();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Banco de dado desconectado");
                    Form conf = new Forms.Notifications.MySqlConfig();
                    conf.ShowDialog();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta");
            }
        }

        private void bnt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
