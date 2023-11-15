using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace GAcademia
{
    public partial class UserControlMySqlConfig : UserControl
    {
        public UserControlMySqlConfig()
        {
            InitializeComponent();
            textBoxServidor.Text = Database.Connect.servidor;
            textBoxBancoDados.Text = Database.Connect.bancoDados;
            textBoxUsuario.Text = Database.Connect.usuario;
            textBoxSenha.Text = Database.Connect.senha;
            textBoxPorta.Text = Database.Connect.porta;
        }

        public class DataEncryptor
        {
            private const string key = "apenasfazendotes"; // Key para criptografia (16 caracteres)

            public static string Encrypt(string plainText)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key);
                    aesAlg.IV = aesAlg.Key;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                        }

                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }

            public static string Decrypt(string cipherText)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key);
                    aesAlg.IV = aesAlg.Key;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string servidor = textBoxServidor.Text;
            string bancoDados = textBoxBancoDados.Text;
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            string porta = textBoxPorta.Text;

            string dataToEncrypt = $"{servidor}\n{bancoDados}\n{usuario}\n{senha}\n{porta}";

            string encryptedData = DataEncryptor.Encrypt(dataToEncrypt);

            using (StreamWriter writer = new StreamWriter("dBconfig.txt"))
            {
                writer.Write(encryptedData);
            }

            MessageBox.Show("Configuração salva");
        }
    }
}
