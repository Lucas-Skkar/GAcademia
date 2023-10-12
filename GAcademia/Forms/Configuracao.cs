using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAcademia.Forms
{
    public partial class Configuracao : Form
    {
        private Form activeForm;
        public Configuracao()
        {
            InitializeComponent();
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
            OpenChildForm(new Forms.Notifications.LoginAdmin(), sender);
        }

        private void btn_db_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Notifications.MySqlConfig(), sender);
        }
    }
}
