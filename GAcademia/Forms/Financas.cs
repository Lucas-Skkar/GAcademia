using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace GAcademia.Forms
{
    public partial class Financas : Form
    {
        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

        private Form activeForm;
        public Financas()
        {
            InitializeComponent();
        }

        private void Financas_Load(object sender, EventArgs e)
        {
            var mes = new List<Mes>();
            mes.Add(new Mes() { mesId = 1, nomeMes = "Janeiro" });
            mes.Add(new Mes() { mesId = 2, nomeMes = "Fevereiro" });
            mes.Add(new Mes() { mesId = 3, nomeMes = "Março" });
            mes.Add(new Mes() { mesId = 4, nomeMes = "Abril" });
            mes.Add(new Mes() { mesId = 5, nomeMes = "Maio" });
            mes.Add(new Mes() { mesId = 6, nomeMes = "Junho" });
            mes.Add(new Mes() { mesId = 7, nomeMes = "Julho" });
            mes.Add(new Mes() { mesId = 8, nomeMes = "Agosto" });
            mes.Add(new Mes() { mesId = 9, nomeMes = "Setembro" });
            mes.Add(new Mes() { mesId = 10, nomeMes = "Outubro" });
            mes.Add(new Mes() { mesId = 11, nomeMes = "Novembro" });
            mes.Add(new Mes() { mesId = 12, nomeMes = "Dezembro" });

            ComboBoxMes.DataSource = mes;
            ComboBoxMes.DisplayMember = "nomeMes";
            ComboBoxMes.Text = "Selecione o mês";

            try
            {
                con.Open();
                string sql = "SELECT tbmensalidades.mes, tbmensalidades.dia, tbmensalidades.status, tbmensalidades.valor, tbalunos.nome, tbalunos.celular FROM tbmensalidades ";
                sql += "INNER JOIN tbalunos ON tbmensalidades.fk_idalunos = tbalunos.idalunos";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                DataGridDetalhes.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Banco de dados desconectado.");
            }
        }

        private class Mes
        {
            public int mesId { get; set; }
            public string nomeMes { get; set; }
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

        private void btn_Mensalidades_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Mensalidades(), sender);
        }

        private void btn_Detalhes_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void ComboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string mesD = ComboBoxMes.Text;

                string sqlPago = "SELECT SUM(CONVERT(valor, DECIMAL(10, 2))) FROM tbmensalidades WHERE status = 'Pago' AND mes = @Mes";

                string sqlPendente = "SELECT SUM(CONVERT(valor, DECIMAL(10, 2))) FROM tbmensalidades WHERE status = 'Pendente' AND mes = @Mes";

                using (MySqlCommand commandPago = new MySqlCommand(sqlPago, con))
                using (MySqlCommand commandPendente = new MySqlCommand(sqlPendente, con))
                {
                    commandPago.Parameters.AddWithValue("@Mes", mesD);
                    commandPendente.Parameters.AddWithValue("@Mes", mesD);

                    object resultPago = commandPago.ExecuteScalar();
                    object resultPendente = commandPendente.ExecuteScalar();

                    if (resultPago != DBNull.Value)
                    {
                        decimal somaPago = Convert.ToDecimal(resultPago);
                        textBoxRecebeu.Text = "" + somaPago;
                    }
                    else
                    {
                        textBoxRecebeu.Text = "0";
                    }

                    if (resultPendente != DBNull.Value)
                    {
                        decimal somaPendente = Convert.ToDecimal(resultPendente);
                        textBoxAtrasado.Text = "" + somaPendente;
                    }
                    else
                    {
                        textBoxAtrasado.Text = "0";
                    }
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("falha");
            }
        }

    }
}
