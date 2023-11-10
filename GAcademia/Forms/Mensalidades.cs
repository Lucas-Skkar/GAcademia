﻿using System;
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
        private Rectangle TextBoxSearchOriginal;
        private Rectangle btn_searchOriginal;
        private Rectangle ComboBoxAlunoOriginal;
        private Rectangle TextBoxIdAlunoOriginal;
        private Rectangle TextBoxInfIdAlunoOriginal;
        private Rectangle ComboBoxMesOriginal;
        private Rectangle ComboBoxDiaOriginal;
        private Rectangle ComboBoxStatusOriginal;
        private Rectangle TextBoxInfValorOriginal;
        private Rectangle textBoxValorOriginal;
        private Rectangle MtextBoxDPagamentoOriginal;
        private Rectangle TextBoxInfDPagamOriginal;
        private Rectangle btn_AdicionarOriginal;
        private Rectangle btn_updateOriginal;
        private Rectangle btn_deleteOriginal;
        private Rectangle btn_ImprimirOriginal;
        private Rectangle searchResultOriginal;

        private Size formOriginal;

        public static bool call = false;

        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);
        public Mensalidades()
        {
            InitializeComponent();
            formOriginal = this.Size;
            TextBoxSearchOriginal = new Rectangle(TextBoxSearch.Location.X, TextBoxSearch.Location.Y, TextBoxSearch.Width, TextBoxSearch.Height);
            btn_searchOriginal = new Rectangle(btn_search.Location.X, btn_search.Location.Y, btn_search.Width, btn_search.Height);
            ComboBoxAlunoOriginal = new Rectangle(ComboBoxAluno.Location.X, ComboBoxAluno.Location.Y, ComboBoxAluno.Width, ComboBoxAluno.Height);
            TextBoxIdAlunoOriginal = new Rectangle(TextBoxIdAluno.Location.X, TextBoxIdAluno.Location.Y, TextBoxIdAluno.Width, TextBoxIdAluno.Height);
            TextBoxInfIdAlunoOriginal = new Rectangle(TextBoxInfIdAluno.Location.X, TextBoxInfIdAluno.Location.Y, TextBoxInfIdAluno.Width, TextBoxInfIdAluno.Height);
            ComboBoxMesOriginal = new Rectangle(ComboBoxMes.Location.X, ComboBoxMes.Location.Y, ComboBoxMes.Width, ComboBoxMes.Height);
            ComboBoxDiaOriginal = new Rectangle(ComboBoxDia.Location.X, ComboBoxDia.Location.Y, ComboBoxDia.Width, ComboBoxDia.Height);
            ComboBoxStatusOriginal = new Rectangle(ComboBoxStatus.Location.X, ComboBoxStatus.Location.Y, ComboBoxStatus.Width, ComboBoxStatus.Height);
            TextBoxInfValorOriginal = new Rectangle(TextBoxInfValor.Location.X, TextBoxInfValor.Location.Y, TextBoxInfValor.Width, TextBoxInfValor.Height);
            textBoxValorOriginal = new Rectangle(textBoxValor.Location.X, textBoxValor.Location.Y, textBoxValor.Width, textBoxValor.Height);
            MtextBoxDPagamentoOriginal = new Rectangle(MtextBoxDPagamento.Location.X, MtextBoxDPagamento.Location.Y, MtextBoxDPagamento.Width, MtextBoxDPagamento.Height);
            TextBoxInfDPagamOriginal = new Rectangle(TextBoxInfDPagam.Location.X, TextBoxInfDPagam.Location.Y, TextBoxInfDPagam.Width, TextBoxInfDPagam.Height);
            btn_AdicionarOriginal = new Rectangle(btn_Adicionar.Location.X, btn_Adicionar.Location.Y, btn_Adicionar.Width, btn_Adicionar.Height);
            btn_updateOriginal = new Rectangle(btn_update.Location.X, btn_update.Location.Y, btn_update.Width, btn_update.Height);
            btn_deleteOriginal = new Rectangle(btn_delete.Location.X, btn_delete.Location.Y, btn_delete.Width, btn_delete.Height);
            btn_ImprimirOriginal = new Rectangle(btn_Imprimir.Location.X, btn_Imprimir.Location.Y, btn_Imprimir.Width, btn_Imprimir.Height);
            searchResultOriginal = new Rectangle(searchResult.Location.X, TextBoxSearch.Location.Y +25, searchResult.Width, searchResult.Height);
        }

        private void Mensalidades_Load(object sender, EventArgs e)
        {
            /*if (call == true)
            {
                btn_update.Visible = false;
                btn_delete.Visible = false;
                btn_Imprimir.Visible = false;
            }*/

            var mes = new List<Mes>();
            //mes.Add(new Mes() { mesId = 0, nomeMes = "" });
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
            //status.Add(new Status() { statusId = 0, statusValor = "" });
            status.Add(new Status() { statusId = 1, statusValor = "Pendente" });
            status.Add(new Status() { statusId = 2, statusValor = "Pago" });

            ComboBoxStatus.DataSource = status;
            ComboBoxStatus.DisplayMember = "statusValor";
            ComboBoxStatus.Text = "Selecione o status da mensalidade";

            try
            {
                con.Open();

                MySqlDataAdapter daA = new MySqlDataAdapter("SELECT idaluno, nome FROM tbalunos", con);
                DataSet dtA = new DataSet();
                daA.Fill(dtA, "Aluno");
                ComboBoxAluno.DataSource = dtA.Tables["Aluno"];
                ComboBoxAluno.DisplayMember = "nome";
                ComboBoxAluno.ValueMember = "idaluno";
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
                try
                {
                    con.Open();
                    string sql = "SELECT tbmensalidades.idmensalidade, tbmensalidades.mes, tbmensalidades.status, tbalunos.nome FROM tbmensalidades ";
                    sql += "INNER JOIN tbalunos ON tbmensalidades.FK_idaluno = tbalunos.idaluno ";
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
                catch
                {

                }

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

                try
                {
                    con.Open();

                    string sql = "SELECT tbmensalidades.idmensalidade, tbmensalidades.mes, tbmensalidades.dia, tbmensalidades.status, tbmensalidades.valor, tbmensalidades.data_pag, tbalunos.nome FROM tbmensalidades ";
                    sql += "INNER JOIN tbalunos ON tbmensalidades.FK_idaluno = tbalunos.idaluno ";
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
                catch
                {

                }
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja adicionar essa mensalidade?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO tbmensalidades (`mes`, `dia`, `status`, `valor`, `data_pag`, `FK_idaluno`) ";
                    sql += "VALUES (@Mes, @Dia, @Status, @Valor, @DataPagamento, @IdAluno)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.Add("@Mes", MySqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@Dia", MySqlDbType.Int32, 11);
                    cmd.Parameters.Add("@Status", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@Valor", MySqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@DataPagamento", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@IdAluno", MySqlDbType.Int32, 11);

                    cmd.Parameters["@Mes"].Value = ComboBoxMes.Text;
                    cmd.Parameters["@Dia"].Value = ComboBoxDia.Text;
                    cmd.Parameters["@Status"].Value = ComboBoxStatus.Text;
                    cmd.Parameters["@Valor"].Value = textBoxValor.Text;
                    cmd.Parameters["@DataPagamento"].Value = MtextBoxDPagamento.Text;
                    cmd.Parameters["@IdAluno"].Value = TextBoxIdAluno.Text;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Adicionado com sucesso!");
                }
                catch
                {

                }
                
                if (call == true)
                {
                    call = false;
                    this.Close();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(TextBoxIdMensalidade.Text != "")
            {
                if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string sql = "UPDATE tbmensalidades SET `mes`=@Mes, `dia`=@Dia, `status`=@Status, `valor`=@Valor, `data_pag`=@DataPagamento, `FK_idaluno`=@IdAluno ";
                        sql += "WHERE `idmensalidade`=@Id";
                        MySqlCommand cmd = new MySqlCommand(sql, con);

                        cmd.Parameters.Add("@Id", MySqlDbType.Int32, 11);
                        cmd.Parameters.Add("@Mes", MySqlDbType.VarChar, 20);
                        cmd.Parameters.Add("@Dia", MySqlDbType.Int32, 11);
                        cmd.Parameters.Add("@Status", MySqlDbType.VarChar, 10);
                        cmd.Parameters.Add("@Valor", MySqlDbType.VarChar, 20);
                        cmd.Parameters.Add("@DataPagamento", MySqlDbType.VarChar, 10);
                        cmd.Parameters.Add("@IdAluno", MySqlDbType.Int32, 11);

                        cmd.Parameters["@Id"].Value = TextBoxIdMensalidade.Text;
                        cmd.Parameters["@Mes"].Value = ComboBoxMes.Text;
                        cmd.Parameters["@Dia"].Value = ComboBoxDia.Text;
                        cmd.Parameters["@Status"].Value = ComboBoxStatus.Text;
                        cmd.Parameters["@Valor"].Value = textBoxValor.Text;
                        cmd.Parameters["@DataPagamento"].Value = MtextBoxDPagamento.Text;
                        cmd.Parameters["@IdAluno"].Value = TextBoxIdAluno.Text;

                        cmd.ExecuteNonQuery();
                        cmd.DisposeAsync();
                        con.Close();
                        MessageBox.Show("Dados atualizados com sucesso!");
                    }
                    catch
                    {

                    }
                    
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
                    try
                    {
                        con.Open();
                        string sql = "DELETE FROM tbmensalidades WHERE `idmensalidade` = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Dispose();
                        MessageBox.Show("Mensalidade removida");
                    }
                    catch
                    {

                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Selecione uma mensalidade");
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (MtextBoxDPagamento.Text != "")
            {
                Comprovante.Comprovante frm = new Comprovante.Comprovante(ComboBoxAluno.Text, textBoxValor.Text, ComboBoxMes.Text, MtextBoxDPagamento.Text);
                frm.Show();
            }
            else
            {
                MessageBox.Show("O Campo Data de Pagamento deve ser preenchido.");
            }
        }

        private void resize()
        {
            resizeControl(TextBoxSearchOriginal, TextBoxSearch);
            resizeControl(btn_searchOriginal, btn_search);
            resizeControl(ComboBoxAlunoOriginal, ComboBoxAluno);
            resizeControl(TextBoxIdAlunoOriginal, TextBoxIdAluno);
            resizeControl(TextBoxInfIdAlunoOriginal, TextBoxInfIdAluno);
            resizeControl(ComboBoxMesOriginal, ComboBoxMes);
            resizeControl(ComboBoxDiaOriginal, ComboBoxDia);
            resizeControl(ComboBoxStatusOriginal, ComboBoxStatus);
            resizeControl(TextBoxInfValorOriginal, TextBoxInfValor);
            resizeControl(textBoxValorOriginal, textBoxValor);
            resizeControl(MtextBoxDPagamentoOriginal, MtextBoxDPagamento);
            resizeControl(TextBoxInfDPagamOriginal, TextBoxInfDPagam);
            resizeControl(btn_AdicionarOriginal, btn_Adicionar);
            resizeControl(btn_updateOriginal, btn_update);
            resizeControl(btn_deleteOriginal, btn_delete);
            resizeControl(btn_ImprimirOriginal, btn_Imprimir);
            resizeControl(searchResultOriginal, searchResult);
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

        private void Mensalidades_Resize(object sender, EventArgs e)
        {
            resize();
        }
    }
}
