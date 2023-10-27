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
using MySql.Data.MySqlClient;

namespace GAcademia.Forms
{
    public partial class Mensalidades : KryptonForm
    {
        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
        public Mensalidades()
        {
            InitializeComponent();
        }

        private void Mensalidades_Load(object sender, EventArgs e)
        {
            var mes = new List<Mes>();
            mes.Add(new Mes() { mesId = 0, nomeMes = "" });
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

            BindingSource bSource = new BindingSource();
            bSource.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            ComboBoxDia.DataSource = bSource;
            ComboBoxDia.Text = "Dia da mensalidade";

            var status = new List<Status>();
            status.Add(new Status() { statusId = 0, statusValor = "" });
            status.Add(new Status() { statusId = 1, statusValor = "Pendente" });
            status.Add(new Status() { statusId = 2, statusValor = "Pago" });

            ComboBoxStatus.DataSource = status;
            ComboBoxStatus.DisplayMember = "statusValor";
            ComboBoxStatus.Text = "Selecione o status da mensalidade";

            try
            {
                con.Open();

                MySqlDataAdapter daA = new MySqlDataAdapter("SELECT idalunos, nome FROM tbalunos", con);
                DataSet dtA = new DataSet();
                daA.Fill(dtA, "Aluno");
                ComboBoxAluno.DataSource = dtA.Tables["Aluno"];
                ComboBoxAluno.DisplayMember = "nome";
                ComboBoxAluno.ValueMember = "idalunos";
                ComboBoxAluno.Text = "Selecionar Aluno";

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Banco de dado desconectado, verifique a conexão em Configurações > Banco de dados");
            }
        }

        private class Mes
        {
            public int mesId { get; set; }
            public string nomeMes { get; set; }
        }

        private class Status
        {
            public int statusId { get; set; }
            public string statusValor { get; set; }
        }

        private void ComboBoxAluno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TextBoxIdAluno.Text = ComboBoxAluno.GetItemText(ComboBoxAluno.SelectedValue);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.TextLength >= 1)
            {
                con.Open();
                string sql = "SELECT tbmensalidades.idmensalidade, tbmensalidades.mes, tbmensalidades.status, tbalunos.nome FROM tbmensalidades ";
                sql += "INNER JOIN tbalunos ON tbmensalidades.fk_idalunos = tbalunos.idalunos ";
                sql += "WHERE tbalunos.nome LIKE ?";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("tbalunos.nome", TextBoxSearch.Text + "%");
                cmd.Parameters.AddWithValue("tbmensalidades.idmensalidade", TextBoxSearch.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt != null && dt.Rows.Count > 0)
                {
                    searchResult.DataSource = dt;
                    searchResult.Height = searchResult.Rows.Count * 25;
                }
                else
                {
                    searchResult.Height = 0;
                }

                cmd.Dispose();
                da.Dispose();
                con.Close();

            }
            else if (TextBoxSearch.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            TextBoxSearch.Text = row.Cells["nome"].Value.ToString();
            searchResult.Height = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text != "")
            {
                ComboBoxMes.Text = "";
                ComboBoxStatus.Text = "";
                ComboBoxDia.Text = "";
                textBoxValor.Text = "";
                MtextBoxDPagamento.Text = "";

                con.Open();

                string sql = "SELECT tbmensalidades.idmensalidade, tbmensalidades.mes, tbmensalidades.dia, tbmensalidades.status, tbmensalidades.valor, tbmensalidades.data_pag, tbalunos.nome FROM tbmensalidades ";
                sql += "INNER JOIN tbalunos ON tbmensalidades.fk_idalunos = tbalunos.idalunos ";
                sql += "WHERE tbalunos.nome LIKE ? OR tbmensalidades.idmensalidade LIKE ?";
                MySqlCommand command = con.CreateCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("tbmensalidades.idmensalidade", TextBoxSearch.Text + "%");
                command.Parameters.AddWithValue("tbalunos.nome", TextBoxSearch.Text + "%");
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    ComboBoxAluno.Text = dr.GetValue(6).ToString();
                    TextBoxIdMensalidade.Text = dr.GetValue(0).ToString();
                    ComboBoxMes.Text = dr.GetValue(1).ToString();
                    ComboBoxDia.Text = dr.GetValue(2).ToString();
                    ComboBoxStatus.Text = dr.GetValue(3).ToString();
                    textBoxValor.Text = dr.GetValue(4).ToString();
                    MtextBoxDPagamento.Text = dr.GetValue(5).ToString();
                }

                dr.Close();
                con.Close();
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja adicionar essa mensalidade?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbmensalidades (`mes`, `dia`, `status`, `valor`, `data_pag`, `fk_idalunos`)" + " VALUES (@Mes, @Dia, @Status, @Valor, @DataPagamento, @IdAlunos)", con);

                cmd.Parameters.Add("@Mes", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@Dia", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@Status", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Valor", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@DataPagamento", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@IdAlunos", MySqlDbType.Int32, 11);

                cmd.Parameters["@Mes"].Value = ComboBoxMes.Text;
                cmd.Parameters["@Dia"].Value = ComboBoxDia.Text;
                cmd.Parameters["@Status"].Value = ComboBoxStatus.Text;
                cmd.Parameters["@Valor"].Value = textBoxValor.Text;
                cmd.Parameters["@DataPagamento"].Value = MtextBoxDPagamento.Text;
                cmd.Parameters["@IdAlunos"].Value = TextBoxIdAluno.Text;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Adicionado com sucesso!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(TextBoxIdMensalidade.Text != "")
            {
                if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE tbmensalidades SET `mes`=@Mes, `dia`=@Dia, `status`=@Status, `valor`=@Valor, `data_pag`=@DataPagamento, `fk_idalunos`=@IdAlunos WHERE `idmensalidade`=@Id", con);

                    cmd.Parameters.Add("@Id", MySqlDbType.Int32, 11);
                    cmd.Parameters.Add("@Mes", MySqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@Dia", MySqlDbType.Int32, 11);
                    cmd.Parameters.Add("@Status", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@Valor", MySqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@DataPagamento", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@IdAlunos", MySqlDbType.Int32, 11);

                    cmd.Parameters["@Id"].Value = TextBoxIdMensalidade.Text;
                    cmd.Parameters["@Mes"].Value = ComboBoxMes.Text;
                    cmd.Parameters["@Dia"].Value = ComboBoxDia.Text;
                    cmd.Parameters["@Status"].Value = ComboBoxStatus.Text;
                    cmd.Parameters["@Valor"].Value = textBoxValor.Text;
                    cmd.Parameters["@DataPagamento"].Value = MtextBoxDPagamento.Text;
                    cmd.Parameters["@IdAlunos"].Value = TextBoxIdAluno.Text;

                    cmd.ExecuteNonQuery();
                    cmd.DisposeAsync();
                    con.Close();
                    MessageBox.Show("Dados atualizados com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Falha na atualização! Tenha certeza de ter selecionado uma mensalidade antes de atualizar.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (TextBoxIdMensalidade.Text != "")
            {
                if (MessageBox.Show("Deseja remover essa mensalidade?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = TextBoxIdMensalidade.Text;
                    con.Open();
                    string sql = "DELETE FROM tbmensalidades WHERE `idmensalidade` = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.Dispose();
                    MessageBox.Show("Mensalidade removida");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma mensalidade");
            }
        }
    }
}
