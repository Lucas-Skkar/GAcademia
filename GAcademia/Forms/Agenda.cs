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

namespace GAcademia.Forms
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

        private void Agenda_Load(object sender, EventArgs e)
        {
            var dia = new List<diaSemana>();
            dia.Add(new diaSemana() { diaId = 0, nomeDia = "" });
            dia.Add(new diaSemana() { diaId = 1, nomeDia = "Domingo" });
            dia.Add(new diaSemana() { diaId = 2, nomeDia = "Segunda" });
            dia.Add(new diaSemana() { diaId = 3, nomeDia = "Terça" });
            dia.Add(new diaSemana() { diaId = 4, nomeDia = "Quarta" });
            dia.Add(new diaSemana() { diaId = 5, nomeDia = "Quinta" });
            dia.Add(new diaSemana() { diaId = 6, nomeDia = "Sexta" });
            dia.Add(new diaSemana() { diaId = 7, nomeDia = "Sábado" });

            ComboBoxDia.DataSource = dia;
            ComboBoxDia.DisplayMember = "nomeDia";
            ComboBoxDia.Text = "Selecione o dia";

            try
            {
                con.Open();
                MySqlDataAdapter daP = new MySqlDataAdapter("SELECT idprofessor, nome FROM tbprofessor", con);
                DataSet dtP = new DataSet();
                daP.Fill(dtP, "Professor");
                ComboBoxProfessor.DataSource = dtP.Tables["Professor"];
                ComboBoxProfessor.DisplayMember = "nome";
                ComboBoxProfessor.ValueMember = "idprofessor";
                ComboBoxProfessor.Text = "Selecionar Professor";

                MySqlDataAdapter daA = new MySqlDataAdapter("SELECT idaluno, nome, cpf FROM tbalunos", con);
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
                MessageBox.Show("Banco de dado desconectado, verifique a conexão em Configurações");
            }
            
        }

        private void ComboBoxAluno_SelectionChangeCommitted(object sender, EventArgs e)
        {
                TextBoxIdAluno.Text = ComboBoxAluno.GetItemText(ComboBoxAluno.SelectedValue);   
        }

        private void ComboBoxProfessor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TextBoxIdProf.Text = ComboBoxProfessor.GetItemText(ComboBoxProfessor.SelectedValue);
        }

        private class diaSemana
        {
            public int diaId { get; set; }
            public string nomeDia { get; set; }
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            if (ComboBoxAluno.Text != "" && ComboBoxProfessor.Text != "" && ComboBoxDia.Text != "" && MTextBoxHorario.Text != "")
            {
                if (MessageBox.Show("Deseja agendar esse horário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO tbagenda (`aluno`, `professor`, `dia`, `hora`, `descricao`)" + " VALUES (@Aluno, @Professor, @Dia, @Hora, @Desc)", con);

                    cmd.Parameters.Add("@Aluno", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Professor", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Dia", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@Hora", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@Desc", MySqlDbType.VarChar, 250);

                    cmd.Parameters["@Aluno"].Value = ComboBoxAluno.Text;
                    cmd.Parameters["@Professor"].Value = ComboBoxProfessor.Text;
                    cmd.Parameters["@Dia"].Value = ComboBoxDia.Text;
                    cmd.Parameters["@Hora"].Value = MTextBoxHorario.Text;
                    cmd.Parameters["@Desc"].Value = TextBoxDesc.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com sucesso!");

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Um ou mais campos estão vazios, porfavor preecha todos os campos!");
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.TextLength >= 1)
            {
                con.Open();
                string sql = "SELECT idagenda, aluno, dia FROM tbagenda ";
                sql += "WHERE aluno LIKE ? OR dia LIKE ? OR idagenda LIKE ?";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("idagenda", TextBoxSearch.Text + "%");
                cmd.Parameters.AddWithValue("aluno", TextBoxSearch.Text + "%");
                cmd.Parameters.AddWithValue("dia", TextBoxSearch.Text + "%");
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
            TextBoxSearch.Text = row.Cells["Aluno"].Value.ToString();
            searchResult.Height = 0;
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text != "")
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT idagenda, aluno, professor, dia, hora, descricao FROM tbagenda WHERE idagenda LIKE ? OR aluno LIKE ?", con);
                cmd.Parameters.AddWithValue("idagenda", TextBoxSearch.Text + "%");
                cmd.Parameters.AddWithValue("aluno", TextBoxSearch.Text + "%");
                MySqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    TextBoxIdAgenda.Text = srd.GetValue(0).ToString();
                    ComboBoxAluno.Text = srd.GetValue(1).ToString();
                    ComboBoxProfessor.Text = srd.GetValue(2).ToString();
                    ComboBoxDia.Text = srd.GetValue(3).ToString();
                    MTextBoxHorario.Text = srd.GetValue(4).ToString();
                    TextBoxDesc.Text = srd.GetValue(5).ToString();
                }
                srd.Close();
                con.Close();
            }
        }

        private void tbn_upd_Click(object sender, EventArgs e)
        {
            if (TextBoxIdAgenda.Text != "")
            {
                if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE tbagenda SET `aluno`=@Aluno, `professor`=@Prof, `dia`=@Dia, `hora`=@Hora, `descricao`=@Desc WHERE `idagenda`=@Id", con);

                    cmd.Parameters.Add("@Id", MySqlDbType.Int32, 11);
                    cmd.Parameters.Add("@Aluno", MySqlDbType.VarChar, 150);
                    cmd.Parameters.Add("@Prof", MySqlDbType.VarChar, 15);
                    cmd.Parameters.Add("@Dia", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@Hora", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@Desc", MySqlDbType.VarChar, 20);

                    cmd.Parameters["@Id"].Value = TextBoxIdAgenda.Text;
                    cmd.Parameters["@Aluno"].Value = ComboBoxAluno.Text;
                    cmd.Parameters["@Prof"].Value = ComboBoxProfessor.Text;
                    cmd.Parameters["@Dia"].Value = ComboBoxDia.Text;
                    cmd.Parameters["@Hora"].Value = MTextBoxHorario.Text;
                    cmd.Parameters["@Desc"].Value = TextBoxDesc.Text;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.DisposeAsync();
                    MessageBox.Show("Dados atualizados com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Falha na atualização! Tenha certeza de ter selecionado uma agenda antes de atualizar.");
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
                if (TextBoxIdAgenda.Text != "")
                {
                    if (MessageBox.Show("Deseja remover esse agendamento?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string id = TextBoxIdAgenda.Text;
                        con.Open();
                        string sql = "DELETE FROM tbagenda WHERE `idagenda` = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Dispose();
                        MessageBox.Show("Agendamento deletado");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um agendamento");
                }
        }

    }
}
