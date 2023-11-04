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
using ComponentFactory.Krypton.Toolkit;
using static GAcademia.UserControlMySqlConfig;

namespace GAcademia.Forms
{
    public partial class LoginForm : KryptonForm
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
        }

        public void LoadAdmin()
        {
            try
            {
                if (File.Exists("config.txt"))
                {
                    ReadConfigFile();
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
                    string criptografar = $"{ID}\n{Pass}";
                    string encryptedData = DataEncryptor.Encrypt(criptografar);
                    using (StreamWriter writer = new StreamWriter("config.txt"))
                    {
                        writer.Write(encryptedData);
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
            MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

            string Usuario = tBoxUsuario.Text;
            string Senha = tBoxSenha.Text;
            string Tipo;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT login, senha, userType FROM tbusuario WHERE login = @Login AND senha = @Senha", con);
                cmd.Parameters.AddWithValue("@Login", Usuario);
                cmd.Parameters.AddWithValue("@Senha", Senha);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Tipo = dr.GetString(2);
                    if (Tipo != "Admin")
                    {
                        FormMain.privilegio = false;
                    }
                    else
                    {
                        FormMain.privilegio = true;
                    }

                    this.DialogResult = DialogResult.OK;

                }
                else if (dr.HasRows == false)
                {
                    loginPadrao();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreta");
                }

                dr.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Banco de dados desconectado, use admin padrão");
                loginPadrao();
            }
            
        }

        private void loginPadrao()
        {
           
            string Usuario = tBoxUsuario.Text;
            string Senha = tBoxSenha.Text;
           

            if (File.Exists("config.txt"))
            {
                LoadAdmin();
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
                    MySqlConnection connection = new MySqlConnection(Database.Connect.dbConnect);
                    connection.Open();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Banco de dado desconectado");
                    Form conf = new Forms.Notifications.MySqlConfig();
                    conf.ShowDialog();
                }

                FormMain.privilegio = true;
                this.DialogResult = DialogResult.OK;
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

        private static void ReadConfigFile()
        {
            
                string encryptedData;
                using (StreamReader reader = new StreamReader("config.txt"))
                {
                    encryptedData = reader.ReadToEnd();
                }

                string decryptedData = DataEncryptor.Decrypt(encryptedData);

                string[] dataParts = decryptedData.Split('\n');
                if (dataParts.Length == 2)
                {
                    string ID = dataParts[0];
                    string Pass = dataParts[1];

                    using (StreamWriter writer = new StreamWriter("config.txt"))
                    {
                        writer.WriteLine($"ID={ID}");
                        writer.WriteLine($"Pass={Pass}");
                    }
                }
            
        }
    }
}
