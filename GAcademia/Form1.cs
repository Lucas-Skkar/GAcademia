﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAcademia
{
    
    public partial class FormMain : Form
    {
        private Form activeForm;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
        public FormMain()
        {
            InitializeComponent();
            test_bdConnection();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void test_bdConnection()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT aluno, hora, professor, descricao, dia FROM tbagenda", con);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                DataGridAgenda.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
               // MessageBox.Show("Banco de dado desconectado");

                btn_Domingo.Enabled = false;
                btn_Segunda.Enabled = false;
                btn_Terca.Enabled = false;
                btn_quarta.Enabled = false;
                btn_quinta.Enabled = false;
                btn_sexta.Enabled = false;
                btn_sabado.Enabled = false;

               // Form conf = new Forms.Notifications.MySqlConfig();
              //  conf.ShowDialog();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormMain_Load(object sender, EventArgs e)
        {
           /* con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT aluno, hora, professor, descricao, dia FROM tbagenda", con);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            DataGridAgenda.DataSource = dt;
            con.Close();*/
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
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Usuarios(), sender);
        }

        private void btn_Instrutor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Instrutores(), sender);
        }

        private void btn_Men_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Mensalidades(), sender);
        }

        private void btn_Agenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Agenda(), sender);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bnt_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Domingo_Click(object sender, EventArgs e)
        {
            (DataGridAgenda.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia LIKE 'Domingo'");
        }

        private void btn_Segunda_Click(object sender, EventArgs e)
        {
            (DataGridAgenda.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia LIKE 'Segunda'");
        }

        private void btn_Terca_Click(object sender, EventArgs e)
        {
            (DataGridAgenda.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia LIKE 'Terça'");
        }

        private void btn_quarta_Click(object sender, EventArgs e)
        {
            (DataGridAgenda.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia LIKE 'Quarta'");
        }

        private void btn_quinta_Click(object sender, EventArgs e)
        {
            (DataGridAgenda.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia LIKE 'Quinta'");
        }

        private void btn_sexta_Click(object sender, EventArgs e)
        {
            (DataGridAgenda.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia LIKE 'Sexta'");
        }

        private void btn_sabado_Click(object sender, EventArgs e)
        {
            (DataGridAgenda.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia LIKE 'Sábado'");
        }

        private void btn_confg_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Configuracao(), sender);
        }
    }
}
