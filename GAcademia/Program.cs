using System;
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

            // Abre a tela de login antes da FormMain. 
            Forms.LoginForm fl = new Forms.LoginForm();
            DialogResult dr = fl.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }
        }

    }
}
