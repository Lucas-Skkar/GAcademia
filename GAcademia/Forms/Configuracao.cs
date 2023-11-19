using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static GAcademia.UserControlMySqlConfig;
using System.Security.Cryptography;

namespace GAcademia.Forms
{
    public partial class Configuracao : Form
    {
        private Form activeForm;
        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
        public Configuracao()
        {
            InitializeComponent();

            // Deixa o painel "PanelTrocarLoginPadrao" visível e os outros painéis invisíveis ao abrir a forma.
            PanelTrocarLoginPadrao.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelNewLogin.Visible = false;
            PanelEmail.Visible = false;
        }

        private void Configuracao_Load(object sender, EventArgs e)
        {
            // Cria a lista "Privilegio" e adiciona ao "ComboBoxPrivilegio".
            var Priv = new List<Privilegio>();
            Priv.Add(new Privilegio() { privId = 1, privNome = "Admin" });
            Priv.Add(new Privilegio() { privId = 2, privNome = "Instrutor" });

            ComboBoxPrivilegio.DataSource = Priv;
            ComboBoxPrivilegio.DisplayMember = "privNome";
            ComboBoxPrivilegio.Text = "Selecione o tipo de usuário";

            // Adiciona ao "ComboBoxSelect" os dados da tabela "tbusuario".
            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT idusuario, login FROM tbusuario", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Login");
                ComboBoxSelect.DataSource = ds.Tables["Login"];
                ComboBoxSelect.DisplayMember = "login";
                ComboBoxSelect.ValueMember = "idusuario";
                ComboBoxSelect.Text = "Selecionar login usuário";

                con.Close();
            }
            catch (Exception)
            {
               // MessageBox.Show("Banco de dado desconectado.");
            }

            if (File.Exists("eConfig.txt"))
            {
                labelIportante.Visible = false;
            }
            else
            {
                labelIportante.Visible = true;
            }
        }

        // Mostra no "textBoxLoginN" e "ComboBoxPrivilegio" os valores da tabela "tbusuario".
        private void ComboBoxSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Ao selecionar um login no "ComboBoxSelect", o texto do "TextBoxIdUser" recebe o ValueMember.
            TextBoxIdUser.Text = ComboBoxSelect.GetItemText(ComboBoxSelect.SelectedValue);
            if (TextBoxIdUser.Text != "")
            {
                try
                {
                    con.Open();

                    string sql = "SELECT login, senha, userType FROM tbusuario WHERE idusuario =@id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", TextBoxIdUser.Text);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        textBoxLoginN.Text = dr.GetValue(0).ToString();
                        //textBoxSenhaN.Text = dr.GetValue(1).ToString();
                        ComboBoxPrivilegio.Text = dr.GetValue(2).ToString();
                    }
                    dr.Close();
                    con.Close();
                }
                catch
                {

                }
            }
        }

        private class Privilegio
        {
            public int privId { get; set; }
            public string privNome { get; set; }
        }

        // Permite abrir outras formas dentro dessa forma.
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

        // Torna painel "PanelTrocarLoginPadrao" visível e os outros painéis invisíveis.
        private void btn_Login_Click(object sender, EventArgs e)
        {
            PanelTrocarLoginPadrao.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelNewLogin.Visible = false;
            PanelEmail.Visible = false;
        }

        // Torna painel "PanelMySqlConfig" visível e os outros painéis invisíveis.
        private void btn_db_Click(object sender, EventArgs e)
        {
            PanelMySqlConfig.Visible = true;
            PanelTrocarLoginPadrao.Visible = false;
            PanelNewLogin.Visible = false;
            PanelEmail.Visible = false;
        }

        // Torna painel "PanelNewLogin" visível e os outros painéis invisíveis.
        private void btn_NewLogin_Click(object sender, EventArgs e)
        {
            PanelNewLogin.Visible = true;
            PanelTrocarLoginPadrao.Visible = false;
            PanelMySqlConfig.Visible = false;
            PanelEmail.Visible = false;
        }

        // Torna painel "PanelEmail" visível e os outros painéis invisíveis.
        private void btn_ConfigEmail_Click(object sender, EventArgs e)
        {
            PanelEmail.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelTrocarLoginPadrao.Visible = false;
            PanelNewLogin.Visible = false;
        }

        // Pega os valores do LoadFile (encontrado em Database.Connect) e tenta se conectar com o banco de dados.
        private void btn_testConnect_Click(object sender, EventArgs e)
        {
            Database.Connect.LoadFile();

            try
            {
                con.Open();
                con.Close();
                MessageBox.Show("Conexão bem sucedida!");
            }
            catch
            {
                MessageBox.Show("Falha na conexão!");
            }
           
        }

        // Salva os textos do "textBoxUsuario" e "textBoxSenha" no arquivo "config.txt" e o criptografa.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ID = textBoxUsuario.Text;
            string Pass = textBoxSenha.Text;

            string criptografar = $"{ID}\n{Pass}";
            string encryptedData = DataEncryptor.Encrypt(criptografar);
            using (StreamWriter writer = new StreamWriter("config.txt"))
            {
                writer.Write(encryptedData);
            }
            
            MessageBox.Show("Administrador padrão alterada com sucesso. Caso esqueça a senha, delete o arquivo config.txt na pasta raiz");
        }

        // Cria novo login user usando o banco de dados, permite criar conta tipo administrador e istrutor.
        // Salva os textos de "textBoxLoginN", "textBoxSenhaN" e "ComboBoxPrivilegio" na tabela "tbusuario".
        private void bnt_salvarN_Click(object sender, EventArgs e)
        {
            // Checa se os textbox e combobox não estão vazios.
            if (textBoxInfLoginN.Text != "" && textBoxSenhaN.Text != "" && ComboBoxPrivilegio.Text != "")
            {
                // Deixa invisível os textos de erro antes de executar o resto do código. 
                labelLogin.Visible = false;
                labelSenha.Visible = false;

                // Checa se o texto do "textBoxLoginN" tem quatro ou mais caracteres.
                if (textBoxLoginN.Text.Length >= 4)
                {
                    // Checa se o texto do "textBoxSenhaN" tem seis ou mais caracteres. 
                    if (textBoxSenhaN.Text.Length >= 6)
                    {
                        if (MessageBox.Show("Deseja adicionar esse usuário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // Checa se já existe um login com o mesmo nome do texto do "textBoxLoginN".
                            con.Open();

                            MySqlCommand check_usName = new MySqlCommand("SELECT * FROM tbusuario WHERE (`login` = @Log)", con);
                            check_usName.Parameters.AddWithValue("@Log", textBoxLoginN.Text);
                            MySqlDataReader reader = check_usName.ExecuteReader();
                            
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login já existe.");
                                con.Close();
                            }
                            else
                            {
                                con.Close();

                                string Login = textBoxLoginN.Text;
                                string Senha = textBoxSenhaN.Text;
                                string Tipo = ComboBoxPrivilegio.Text;

                                try
                                {
                                    byte[] salt = GerarSalt(); // Chama o "GerarSalt" para gera a chave salt.
                                    byte[] critptogafado = pHash(Senha, salt); // Chama o "pHash" para criptografar a senha.

                                    // Adiciona os novos registros na tabela "tbusuario" com a senha já criptografada. 
                                    con.Open();

                                    string sql = "INSERT INTO tbusuario (`login`, `senha`, `userType`, `alt`) VALUES (@Login, @Senha, @Tipo, @Salt)";
                                    MySqlCommand cmd = new MySqlCommand(sql, con);
                                    cmd.Parameters.AddWithValue("@Login", Login);
                                    cmd.Parameters.AddWithValue("@Senha", critptogafado);
                                    cmd.Parameters.AddWithValue("@Tipo", Tipo);
                                    cmd.Parameters.AddWithValue("@Salt", salt);

                                    int rAfetada = cmd.ExecuteNonQuery();

                                    // Checa se teve "row" afetada.
                                    if (rAfetada > 0)
                                    {
                                        MessageBox.Show("Usuário adicionado com sucesso!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erro ao inserir o registro.");
                                    }

                                    con.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("Erro! Banco de dados desconectado.");
                                }
                            }
                        }
                                
                    }
                    // Se a senha tem menos de seis caracteres, o texto "labelSenha" fica visível.
                    else
                    {
                        labelSenha.Visible = true;
                    }
                }
                // Se o login tem menos de quatro caracteres, o texto "labelLogin" fica visível.
                else
                {
                    labelLogin.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Erro! Um ou mais campos estão vazios");
            }
        }

        // Gera uma chave aleatória.
        private byte[] GerarSalt()
        {
            byte[] salt = new byte[16];
            using (RNGCryptoServiceProvider gCrypto = new RNGCryptoServiceProvider())
            {
                gCrypto.GetBytes(salt);
            }
            return salt;
        }

        // Pega a senha e criptografa usando o "salt" como chave de criptografia.
        private byte[] pHash(string pass, byte[] salt)
        {
            using (Rfc2898DeriveBytes r = new Rfc2898DeriveBytes(pass, salt, 10000))
            {
                return r.GetBytes(32);
            }
        }

        // Atualiza os dados da tabela "tbusuario" onde "idusuario" é igual a "TextBoxIdUser".
        // O sistema de criptografia da senha é o mesmo do adicionar.
        private void btn_UpdateN_Click(object sender, EventArgs e)
        {
            if(TextBoxIdUser.Text != "")
            {
                if (textBoxInfLoginN.Text != "" && textBoxSenhaN.Text != "" && ComboBoxPrivilegio.Text != "")
                {
                    string Login = textBoxLoginN.Text;
                    string Senha = textBoxSenhaN.Text;
                    string Tipo = ComboBoxPrivilegio.Text;

                    labelLogin.Visible = false;
                    labelSenha.Visible = false;

                    // Checa se o texto do "textBoxLoginN" tem quatro ou mais caracteres.
                    if (textBoxLoginN.Text.Length >= 4)
                    {
                        // Checa se o texto do "textBoxSenhaN" tem seis ou mais caracteres. 
                        if (textBoxSenhaN.Text.Length >= 6)
                        {
                            try
                            {
                                byte[] salt = GerarSalt();
                                byte[] critptogafado = pHash(Senha, salt);

                                con.Open();

                                string sql = "UPDATE tbusuario SET `login`=@Login, `senha`=@Senha, `userType`=@Tipo, `alt`=@Salt WHERE `idusuario`=@id";
                                MySqlCommand cmd = new MySqlCommand(sql, con);
                                cmd.Parameters.AddWithValue("@id", TextBoxIdUser.Text);
                                cmd.Parameters.AddWithValue("@Login", Login);
                                cmd.Parameters.AddWithValue("@Senha", critptogafado);
                                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                                cmd.Parameters.AddWithValue("@Salt", salt);

                                int rAfetada = cmd.ExecuteNonQuery();
                                if (rAfetada > 0)
                                {
                                    MessageBox.Show("Usuário atualizado com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao atualizar o registro.");
                                }

                                con.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Erro! Banco de dados desconectado.");
                            }
                        }
                        // Se a senha tem menos de seis caracteres, o texto "labelSenha" fica visível.
                        else
                        {
                            labelSenha.Visible = true;
                        }
                    }
                    // Se o login tem menos de quatro caracteres, o texto "labelLogin" fica visível.
                    else
                    {
                        labelLogin.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Erro! Um ou mais campos estão vazios");
                }
            }
        }

        // Deleta o row da tabela "tbusuario" onde "idusuario" é igual ao texto do "TextBoxIdUser".
        private void btn_DeleteN_Click(object sender, EventArgs e)
        {
            if (TextBoxIdUser.Text != "")
            {
                if (MessageBox.Show("Deseja remover esse login?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string id = TextBoxIdUser.Text;
                        con.Open();
                        string sql = "DELETE FROM tbusuario WHERE `idusuario` = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Dispose();
                        MessageBox.Show("Login de usuário deletado");
                    }
                    catch
                    {

                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Selecione um login de usuário");
            }
        }

        // Salva os textos do "TextBoxEmail" e "TextBoxEmailSenha" no arquivo "eConfig.txt" e o criptografa.
        // Se o arquivo não existir, cria ele.
        private void btn_SalvarEmail_Click(object sender, EventArgs e)
        {
            string emailOrigen = TextBoxEmail.Text;
            string emailSenha = TextBoxEmailSenha.Text;

            string dataToEncrypt = $"{emailOrigen}\n{emailSenha}";

            string encryptedData = DataEncryptor.Encrypt(dataToEncrypt);

            using (StreamWriter writer = new StreamWriter("eConfig.txt"))
            {
                writer.Write(encryptedData);
            }

            MessageBox.Show("Email salvo");
        }

        
    }
}
