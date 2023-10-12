using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAcademia.Database
{
    class Connect
    {
        public static string servidor = "localhost";
        public static string bancoDados = "dbacademia";
        public static string usuario = "";
        public static string senha = "";
        public static string porta = "3306";

        static public string dbConnect = $"server={servidor};database={bancoDados};user={usuario};password={senha};port={porta}";

        public static void LoadFile()
        {
            try
            {
                if (File.Exists("dBconfig.txt"))
                {
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

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar valores do arquivo: " + ex.Message);
            }
        }
    }
}
