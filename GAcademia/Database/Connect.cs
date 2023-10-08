using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAcademia.Database
{
    class Connect
    {
        public static string servidor = "localhost";
        public static string bancoDados = "dbacademia";
        public static string usuario = "root";
        public static string senha = "";
        public static string porta = "3306";

        static public string dbConnect = $"server={servidor};database={bancoDados};user={usuario};password={senha};port={porta}";
    }
}
