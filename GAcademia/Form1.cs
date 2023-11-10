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
using ComponentFactory.Krypton.Toolkit;

namespace GAcademia
{
    public partial class FormMain : KryptonForm
    {
        private Rectangle btn_DomingoOriginal;
        private Rectangle btn_SegundaOriginal;
        private Rectangle btn_TercaOriginal;
        private Rectangle btn_quartaOriginal;
        private Rectangle btn_quintaOriginal;
        private Rectangle btn_sextaOriginal;
        private Rectangle btn_sabadoOriginal;
        //private Rectangle DataGridAgendaOriginal;

        private Size formOriginal;

        public static bool privilegio = false;
        private Form activeForm;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
        public FormMain()
        {
            InitializeComponent();
            test_bdConnection();

            formOriginal = this.Size;
            btn_DomingoOriginal = new Rectangle (btn_Domingo.Location.X, btn_Domingo.Location.Y, btn_Domingo.Width, btn_Domingo.Height);
            btn_SegundaOriginal = new Rectangle(btn_Segunda.Location.X, btn_Segunda.Location.Y, btn_Segunda.Width, btn_Segunda.Height);
            btn_TercaOriginal = new Rectangle(btn_Terca.Location.X, btn_Terca.Location.Y, btn_Terca.Width, btn_Terca.Height);
            btn_quartaOriginal = new Rectangle(btn_quarta.Location.X, btn_quarta.Location.Y, btn_quarta.Width, btn_quarta.Height);
            btn_quintaOriginal = new Rectangle(btn_quinta.Location.X, btn_quinta.Location.Y, btn_quinta.Width, btn_quinta.Height);
            btn_sextaOriginal = new Rectangle(btn_sexta.Location.X, btn_sexta.Location.Y, btn_sexta.Width, btn_sexta.Height);
            btn_sabadoOriginal = new Rectangle(btn_sabado.Location.X, btn_sabado.Location.Y, btn_sabado.Width, btn_sabado.Height);
            //DataGridAgendaOriginal = new Rectangle(DataGridAgenda.Location.X, DataGridAgenda.Location.Y, DataGridAgenda.Width, DataGridAgenda.Height);
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
            if (privilegio == false)
            {
                btn_Financas.Enabled = false;
                btn_confg.Enabled = false;
            }
            try
            {
                con.Open();

                DateTime hoje = DateTime.Today;
                DateTime mesPassado = hoje.AddMonths(-1);
                string nomeMesPassado = mesPassado.ToString("MMMM");
                string nomeMesAtual = hoje.ToString("MMMM");

                string sql = "SELECT * FROM tbmensalidades WHERE mes = @mesPassado";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mesPassado", nomeMesPassado);

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                cmd.Cancel();
                cmd.Dispose();

                foreach (DataRow row in dt.Rows)
                {
                    string idAluno = row["FK_idaluno"].ToString();
                    MySqlCommand verificaCmd = new MySqlCommand("SELECT COUNT(*) FROM tbmensalidades WHERE mes = @mesAtual AND FK_idaluno = @IdAluno", con);
                    verificaCmd.Parameters.AddWithValue("@mesAtual", nomeMesAtual);
                    verificaCmd.Parameters.AddWithValue("@IdAluno", idAluno);
                    int count = Convert.ToInt32(verificaCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MySqlCommand command = new MySqlCommand("INSERT INTO tbmensalidades (mes, dia, status, valor, data_pag, FK_idaluno) VALUES (@mesAtual, @Dia, 'Pendente', @valor, @Data, @IdAluno)", con);
                        command.Parameters.AddWithValue("@mesAtual", nomeMesAtual);
                        command.Parameters.AddWithValue("@Dia", row["dia"]);
                        command.Parameters.AddWithValue("@Status", row["status"]);
                        command.Parameters.AddWithValue("@valor", row["valor"]);
                        command.Parameters.AddWithValue("@Data", row["data_pag"]);
                        command.Parameters.AddWithValue("@IdAluno", row["FK_idaluno"]);
                        command.ExecuteNonQuery();
                    }
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados, algumas funções ficarão desativadas.");
            }
            
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

        private void btn_Alunos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Alunos(), sender);
            labelHead.Text = "Alunos";
        }

        private void btn_Instrutor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Instrutores(), sender);
            labelHead.Text = "Professores";
        }

        private void btn_Financas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Financas(), sender);
            labelHead.Text = "Finanças";
        }

        private void btn_Agenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Agenda(), sender);
            labelHead.Text = "Agenda";
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            labelHead.Text = "Home";
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
            labelHead.Text = "Configurações";
        }

        private void resize()
        {
            resizeControl(btn_DomingoOriginal, btn_Domingo);
            resizeControl(btn_SegundaOriginal, btn_Segunda);
            resizeControl(btn_TercaOriginal, btn_Terca);
            resizeControl(btn_quartaOriginal, btn_quarta);
            resizeControl(btn_quintaOriginal, btn_quinta);
            resizeControl(btn_sextaOriginal, btn_sexta);
            resizeControl(btn_sabadoOriginal, btn_sabado);
            //resizeControl(DataGridAgendaOriginal, DataGridAgenda);
        }

        private void resizeControl(Rectangle OriginalControl, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginal.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginal.Height);

            int newX = (int)(OriginalControl.X * xRatio);
            int newY = (int)(OriginalControl.Y * yRatio);

            int newWidth = (int)(OriginalControl.Width * xRatio);
            int newHeight = (int)(OriginalControl.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            resize();
        }
    }
}
