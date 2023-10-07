using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAcademia.Database
{
    class Connect
    {
        private const string servidor = "localhost";
        private const string bancoDados = "dbacademia";
        private const string usuario = "root";
        private const string senha = "";
        private const string porta = "3306";

        static public string dbConnect = $"server={servidor};database={bancoDados};user={usuario};password={senha};port={porta}";
    }
}
