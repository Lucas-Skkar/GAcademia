using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAcademia
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms.LoginForm fl = new Forms.LoginForm();
            DialogResult dr = fl.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
