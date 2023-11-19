using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
            // Cria lista Mes.
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

            // Adiciona a lista "Mes" para o "ComboBoxMes".
            ComboBoxMes.DataSource = mes;
            ComboBoxMes.DisplayMember = "nomeMes";
            ComboBoxMes.Text = "Selecione o mês";

            // Preenche o "DataGridDetalhes" com os dados da tabela "tbmensalidades".
            try
            {
                con.Open();
                string sql = "SELECT tbmensalidades.mes, tbmensalidades.dia, tbmensalidades.status, tbmensalidades.valor, tbalunos.nome, tbalunos.celular FROM tbmensalidades ";
                sql += "INNER JOIN tbalunos ON tbmensalidades.FK_idaluno = tbalunos.idaluno";
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
               // MessageBox.Show("Banco de dados desconectado.");
            }
        }

        private class Mes
        {
            public int mesId { get; set; }
            public string nomeMes { get; set; }
        }

        // Permite abrir outras telas dentro dessa tela.
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

        // Abre a forma Mensalidades dentro dessa forma.
        private void btn_Mensalidades_Click(object sender, EventArgs e)
        {
            Mensalidades.call = false;
            OpenChildForm(new Forms.Mensalidades(), sender);
        }

        // Caso a forma aberta não seja a forma Financas, fecha ela.
        // de modo simples, mostra a tela inicial Financas.
        private void btn_Detalhes_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        // Ao selecionar um mês no "ComboBoxMes", mostra respectivamente no "textBoxRecebeu" e "textBoxAtrasado" 
        // a soma dos valores da coluna "valor" onde o nome é "pago" e "pendente" na coluna "status" da tabela "tbmensalidades".
        private void ComboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string mesSel = ComboBoxMes.Text;

                string sqlPago = "SELECT SUM(CONVERT(valor, DECIMAL(10, 2))) FROM tbmensalidades WHERE status = 'Pago' AND mes = @Mes";

                string sqlPendente = "SELECT SUM(CONVERT(valor, DECIMAL(10, 2))) FROM tbmensalidades WHERE status = 'Pendente' AND mes = @Mes";

                using (MySqlCommand cmdPago = new MySqlCommand(sqlPago, con))
                using (MySqlCommand cmdPendente = new MySqlCommand(sqlPendente, con))
                {
                    cmdPago.Parameters.AddWithValue("@Mes", mesSel);
                    cmdPendente.Parameters.AddWithValue("@Mes", mesSel);

                    object resultPago = cmdPago.ExecuteScalar();
                    object resultPendente = cmdPendente.ExecuteScalar();

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
              //  MessageBox.Show("falha");
            }
        }

    }
}
