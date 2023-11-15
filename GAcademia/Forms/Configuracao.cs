﻿using MySql.Data.MySqlClient;
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
            PanelTrocarLoginPadrao.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelNewLogin.Visible = false;
            PanelEmail.Visible = false;
        }

        private void Configuracao_Load(object sender, EventArgs e)
        {
            var Priv = new List<Privilegio>();
            Priv.Add(new Privilegio() { privId = 1, privNome = "Admin" });
            Priv.Add(new Privilegio() { privId = 2, privNome = "Instrutor" });

            ComboBoxPrivilegio.DataSource = Priv;
            ComboBoxPrivilegio.DisplayMember = "privNome";
            ComboBoxPrivilegio.Text = "Selecione o tipo de usuário";


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

        private void ComboBoxSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
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
            PanelTrocarLoginPadrao.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelNewLogin.Visible = false;
            PanelEmail.Visible = false;

        }

        private void btn_db_Click(object sender, EventArgs e)
        {
            PanelMySqlConfig.Visible = true;
            PanelTrocarLoginPadrao.Visible = false;
            PanelNewLogin.Visible = false;
            PanelEmail.Visible = false;
        }

        private void btn_NewLogin_Click(object sender, EventArgs e)
        {
            PanelNewLogin.Visible = true;
            PanelTrocarLoginPadrao.Visible = false;
            PanelMySqlConfig.Visible = false;
            PanelEmail.Visible = false;
        }

        private void btn_ConfigEmail_Click(object sender, EventArgs e)
        {
            PanelEmail.Visible = true;
            PanelMySqlConfig.Visible = false;
            PanelTrocarLoginPadrao.Visible = false;
            PanelNewLogin.Visible = false;
        }

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

        private void bnt_salvarN_Click(object sender, EventArgs e)
        {
            if (textBoxInfLoginN.Text != "" && textBoxSenhaN.Text != "" && ComboBoxPrivilegio.Text != "")
            {
                labelLogin.Visible = false;
                labelSenha.Visible = false;

                if (textBoxLoginN.Text.Length >= 4)
                {
                    if(textBoxSenhaN.Text.Length >= 6)
                    {
                        if (MessageBox.Show("Deseja adicionar esse usuário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
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
                                    byte[] salt = GerarSalt();
                                    byte[] critptogafado = pHash(Senha, salt);

                                    con.Open();

                                    string sql = "INSERT INTO tbusuario (`login`, `senha`, `userType`, `alt`) VALUES (@Login, @Senha, @Tipo, @Salt)";
                                    MySqlCommand cmd = new MySqlCommand(sql, con);
                                    cmd.Parameters.AddWithValue("@Login", Login);
                                    cmd.Parameters.AddWithValue("@Senha", critptogafado);
                                    cmd.Parameters.AddWithValue("@Tipo", Tipo);
                                    cmd.Parameters.AddWithValue("@Salt", salt);

                                    int rAfetada = cmd.ExecuteNonQuery();
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
                    else
                    {
                        labelSenha.Visible = true;
                    }
                }
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

        private byte[] GerarSalt()
        {
            byte[] salt = new byte[16];
            using (RNGCryptoServiceProvider gCrypto = new RNGCryptoServiceProvider())
            {
                gCrypto.GetBytes(salt);
            }
            return salt;
        }

        private byte[] pHash(string pass, byte[] salt)
        {
            using (Rfc2898DeriveBytes r = new Rfc2898DeriveBytes(pass, salt, 10000))
            {
                return r.GetBytes(32);
            }
        }

        private void btn_UpdateN_Click(object sender, EventArgs e)
        {
            if(TextBoxIdUser.Text != "")
            {
                if (textBoxInfLoginN.Text != "" && textBoxSenhaN.Text != "" && ComboBoxPrivilegio.Text != "")
                {
                    string Login = textBoxLoginN.Text;
                    string Senha = textBoxSenhaN.Text;
                    string Tipo = ComboBoxPrivilegio.Text;

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
                else
                {
                    MessageBox.Show("Erro! Um ou mais campos estão vazios");
                }
            }
        }

        private void btn_DeleteN_Click(object sender, EventArgs e)
        {
            if (TextBoxIdUser.Text != "")
            {
                if (MessageBox.Show("Deseja remover esse agendamento?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
