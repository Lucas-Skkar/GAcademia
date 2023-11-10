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
using System.Security.Cryptography;

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
                string sql = "SELECT senha, alt, userType FROM tbusuario WHERE login =@Login";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Login", Usuario);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        Tipo = dr.GetString(2);
                        byte[] dbPassHash = (byte[])dr["senha"];
                        byte[] salt = (byte[])dr["alt"];
                        byte[] pHash = sHash(Senha, salt);

                        if (compare(dbPassHash, pHash))
                        {
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
                        else
                        {
                            try
                            {
                                loginPadrao();
                            }
                            catch
                            {
                                MessageBox.Show("Senha incorreta.");
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            loginPadrao();
                        }
                        catch
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }

                con.Close();
            }
            catch
            {
                try
                {
                    loginPadrao();
                }
                catch
                {
                    MessageBox.Show("Banco de dados desconectado, use admin padrão");
                }
                
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
                    if (File.Exists("dBconfig.txt"))
                    {
                    }
                    else
                    {
                        Form conf = new Forms.Notifications.MySqlConfig();
                        conf.ShowDialog();
                    }
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

        private byte[] sHash(string pass, byte[] salt)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(pass, salt, 10000))
            {
                return pbkdf2.GetBytes(32); // 32 bytes = 256 bits
            }
        }

        private bool compare(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
