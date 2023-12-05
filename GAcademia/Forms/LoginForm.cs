using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Runtime.InteropServices;
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

        // Constantes necessárias para mover a tela com o mouse.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // Importa as dlls necessárias para mover a tela com o mouse.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Cria novo objeto usando a string de conexão do banco de dados.
        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

        public LoginForm()
        {
            InitializeComponent();
            Database.Connect.LoadFile();
        }

        // Define os valores de ID e Pass com os valores do arquivo "config.txt".
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

                    // Quando o ReadConfigFile é chamado ele descriptografa o arquivo.
                    // Aqui o arquivo volta a ser criptografado.
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

        // Código para fazer login
        private void Btn_login_Click(object sender, EventArgs e)
        {
            // deixa os textos de erro de login e senha invisíveis antes de executar o código
            labelUsuario.Visible = false;
            labelSenha.Visible = false;

            string Usuario = tBoxUsuario.Text;
            string Senha = tBoxSenha.Text;
            string Tipo;

            // Tenta a conexão com o banco de dados selecionando senha, alt(chave salt) e userType onde login for igual o texto do tBoxUsuario.
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
                        // Se existe login com o mesmo nome consultado, pega a senha criptografada e salt do banco de dados e a senha digitada no tBoxSenha.
                        // Usa o pHash para criptografar a senha do tBoxSenha usando a salt do banco de dados.
                        Tipo = dr.GetString(2);
                        byte[] dbPassHash = (byte[])dr["senha"];
                        byte[] salt = (byte[])dr["alt"];
                        byte[] pHash = sHash(Senha, salt);

                        // Compara a senha criptografada do banco de dados com a senha do tBoxSenha criptografada.
                        if (compare(dbPassHash, pHash))
                        {
                            // Se as senhas forem exatas, checa se o tipo de privilégio da conta é admin ou instrutor.
                            if (Tipo != "Admin")
                            {
                                FormMain.privilegio = false;
                            }
                            else
                            {
                                FormMain.privilegio = true;
                            }

                            // Resulta o dialogo ok, usado no Program.cs para chamar a FormMain.
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            // Se as senhas forem diferentes tenta logar como admin padrão.
                            try
                            {
                                loginPadrao();
                            }
                            // Se não conseguir logar, mostra o texto de senha incorreta. 
                            catch
                            {
                                //MessageBox.Show("Senha incorreta.");
                                labelSenha.Visible = true;
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
                            //MessageBox.Show("Usuário não encontrado.");
                            labelUsuario.Visible = true;
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
                    MessageBox.Show("Banco de dados desconectado, use conta admin padrão");
                }
                
            }
            
        }

        // É chamado quando usar o login e senha padrão ou do arquivo "config.txt".
        // Serve para entrar no aplicativo mesmo se não houver conexão com o banco de dados.
        private void loginPadrao()
        {
           
            string Usuario = tBoxUsuario.Text;
            string Senha = tBoxSenha.Text;

            // Checa se o arquivo "config.txt" existe, se sim carrega o LoadAdmin, se não, define os valores de ID e Pass.
            if (File.Exists("config.txt"))
            {
                LoadAdmin();
            }
            else
            {
                ID = "admin";
                Pass = "123456";
            }
            // Checa se os textos do tBoxUsuario e tBoxSenha são iguais ao ID e Pass.
            if (Usuario == ID && Senha == Pass)
            {
                // Testa conexão com o banco de dados
                try
                {
                    MySqlConnection conex = new MySqlConnection(Database.Connect.dbConnect);
                    conex.Open();
                    conex.Close();
                }
                catch
                {
                    // Se não conseguir conexão com o banco de dados, mostra mensagem e checa se o "dBconfig.txt" existe.
                    // Se existe ele abre o FormMain, se não, (esta é possivelmente a primeira execução) mostra a tela de configuração para conectar ao banco de dados.
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

                // Conta padrão é definida como privilégio admin.
                FormMain.privilegio = true;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //MessageBox.Show("Usuário ou senha incorreta");
                if(Usuario == ID)
                {
                    labelSenha.Visible = true;
                }
                else
                {
                    labelUsuario.Visible = true;
                }
            }

        }

        // Fecha a form.
        // Como essa form abre antes da FormMain, fecha-la também finaliza o programa.
        private void bnt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Função que permite arrastar a tela com o mouse.
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Descriptografa o arquivo "config.txt" separando as linhas do "ID" e "Pass"
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

        // Criptografa a senha com a chave "salt".
        // 10000 é a quantidade de interações feitas, quanto maior o valor, maior a segurança e mais lento fica a execução.
        private byte[] sHash(string pass, byte[] salt)
        {
            using (Rfc2898DeriveBytes criptg = new Rfc2898DeriveBytes(pass, salt, 10000))
            {
                return criptg.GetBytes(32);
            }
        }

        // Compara ser os dois arrays são iguais.
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
