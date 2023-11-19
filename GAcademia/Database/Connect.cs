using System.IO;
using static GAcademia.UserControlMySqlConfig;

namespace GAcademia.Database
{
    class Connect
    {
        // valores padrões para conexão com MySql
        public static string servidor = "localhost";
        public static string bancoDados = "dbacademia";
        public static string usuario = "root";
        public static string senha = "";
        public static string porta = "3306";

        // string de conexão com MySql, deve ser chamado sempre que precisar abrir conexão com o banco de dados.
        static public string dbConnect = $"server={servidor};database={bancoDados};user={usuario};password={senha};port={porta}";

        // Sobrescreve os valores padrões de conexão com os valores do arquivo configurado.
        public static void LoadFile()
        {
            try
            { 
                if (File.Exists("dBconfig.txt"))
                {
                    ReadConfigFile();
                    string[] linhas = File.ReadAllLines("dBconfig.txt");
                    foreach (string linha in linhas)
                    {
                        string[] partes = linha.Split('=');
                        if (partes.Length == 2)
                        {
                            string chave = partes[0];
                            string valor = partes[1];

                            switch (chave)
                            {
                                case "servidor":
                                    servidor = valor;
                                    break;
                                case "bancoDados":
                                    bancoDados = valor;
                                    break;
                                case "usuario":
                                    usuario = valor;
                                    break;
                                case "senha":
                                    senha = valor;
                                    break;
                                case "porta":
                                    porta = valor;
                                    break;
                            }
                        }
                    }

                    dbConnect = $"server={servidor};database={bancoDados};user={usuario};password={senha};port={porta}";

                    string dataToEncrypt = $"{servidor}\n{bancoDados}\n{usuario}\n{senha}\n{porta}";
                    string encryptedData = DataEncryptor.Encrypt(dataToEncrypt);
                    using (StreamWriter writer = new StreamWriter("dBconfig.txt"))
                    {
                        writer.Write(encryptedData);
                    }

                }
            }
            catch
            {
            }
        }

        // Descriptografa o arquivo com as configurações de conexão salvas previamente.
        private static void ReadConfigFile()
        {
            try
            {
                string encryptedData;
                using (StreamReader reader = new StreamReader("dBconfig.txt"))
                {
                    encryptedData = reader.ReadToEnd();
                }

                string decryptedData = DataEncryptor.Decrypt(encryptedData);

                string[] dataParts = decryptedData.Split('\n');
                if (dataParts.Length == 5)
                {
                     string servidor = dataParts[0];
                     string bancoDados = dataParts[1];
                     string usuario = dataParts[2];
                     string senha = dataParts[3];
                     string porta = dataParts[4];

                    using (StreamWriter writer = new StreamWriter("dBconfig.txt"))
                    {
                        writer.WriteLine($"servidor={servidor}");
                        writer.WriteLine($"bancoDados={bancoDados}");
                        writer.WriteLine($"usuario={usuario}");
                        writer.WriteLine($"senha={senha}");
                        writer.WriteLine($"porta={porta}");
                    }
                }
            }
            catch
            {
            }
        }
    }
}
