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
    public partial class Instrutores : Form
    {
        public Instrutores()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

        private void Instrutores_Load(object sender, EventArgs e)
        {
            var sex = new List<sexo>();
            sex.Add(new sexo() { sexoId = 1, sexoS = "" });
            sex.Add(new sexo() { sexoId = 2, sexoS = "Masculino" });
            sex.Add(new sexo() { sexoId = 3, sexoS = "Feminino" });
            sex.Add(new sexo() { sexoId = 4, sexoS = "Outro" });

            ComboBoxSexo.DataSource = sex;
            ComboBoxSexo.DisplayMember = "sexoS";
            ComboBoxSexo.Text = "Selecione o sexo";
        }
        private class sexo
        {
            public int sexoId { get; set; }
            public string sexoS { get; set; }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idprofessor, nome, cpf, nasc, sexo, Celular FROM tbprofessor WHERE nome LIKE ? OR idprofessor LIKE ?", con);
            cmd.Parameters.AddWithValue("nome", TextBoxSearch.Text + "%");
            cmd.Parameters.AddWithValue("id", TextBoxSearch.Text + "%");
            MySqlDataReader srd = cmd.ExecuteReader();
            while (srd.Read())
            {
                TextBoxID.Text = srd.GetValue(0).ToString();
                TextBoxNome.Text = srd.GetValue(1).ToString();
                TextBoxCPF.Text = srd.GetValue(2).ToString();
                TextBoxNascimento.Text = srd.GetValue(3).ToString();
                ComboBoxSexo.Text = srd.GetValue(4).ToString();
                TextBoxCelular.Text = srd.GetValue(5).ToString();
            }
            srd.DisposeAsync();
            con.Close();
        }


        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.TextLength >= 1)
            {
                con.Open();
                string sql = "SELECT idprofessor, nome FROM tbprofessor ";
                sql += "WHERE idprofessor LIKE ? OR nome LIKE ?";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("idprofessor", TextBoxSearch.Text + "%");
                cmd.Parameters.AddWithValue("nome", TextBoxSearch.Text + "%");
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            
            con.Close();
             if (MessageBox.Show("Deseja adicionar esse professor?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 con.Open();
                 MySqlCommand check_pName = new MySqlCommand("SELECT * FROM tbprofessor WHERE (`cpf` = @c)", con);
                 check_pName.Parameters.AddWithValue("@c", TextBoxCPF.Text);
                 MySqlDataReader dr = check_pName.ExecuteReader();

                 if (dr.HasRows)
                 {
                     MessageBox.Show("Professor(a) já existe");
                 }
                 else
                 {
                     MySqlCommand cmd = new MySqlCommand("INSERT INTO tbprofessor (`nome`, `cpf`, `nasc`, `sexo`, `Celular`)" + " VALUES (@Nome, @Cpf, @Nascimento, @Sexo, @celular)", con);

                    cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150);
                    cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 15);
                    cmd.Parameters.Add("@Nascimento", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@Sexo", MySqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 20);

                    cmd.Parameters["@Nome"].Value = TextBoxNome.Text;
                    cmd.Parameters["@Cpf"].Value = TextBoxCPF.Text;
                    cmd.Parameters["@Nascimento"].Value = TextBoxNascimento.Text;
                    cmd.Parameters["@Sexo"].Value = ComboBoxSexo.Text;
                    cmd.Parameters["@celular"].Value = TextBoxCelular.Text;

                    dr.DisposeAsync();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com sucesso!");
                 }
                dr.DisposeAsync();
                con.Close();
             }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE tbprofessor SET `nome`=@Nome, `cpf`=@Cpf, `nasc`=@Nascimento, `sexo`=@Sexo, `celular`=@Celular WHERE `idprofessor`=@Id", con);

                cmd.Parameters.Add("@Id", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150);
                cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 15);
                cmd.Parameters.Add("@Nascimento", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Sexo", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Celular", MySqlDbType.VarChar, 20);
                
                cmd.Parameters["@Id"].Value = TextBoxID.Text;
                cmd.Parameters["@Nome"].Value = TextBoxNome.Text;
                cmd.Parameters["@Cpf"].Value = TextBoxCPF.Text;
                cmd.Parameters["@Nascimento"].Value = TextBoxNascimento.Text;
                cmd.Parameters["@Sexo"].Value = ComboBoxSexo.Text;
                cmd.Parameters["@Celular"].Value = TextBoxCelular.Text;

                cmd.ExecuteNonQuery();
                con.Close();
                cmd.DisposeAsync();
                MessageBox.Show("Dados atualizados com sucesso!");
            }
        }

       

        private void btn_delete_Click(object sender, EventArgs e)
        {
            {
                if (TextBoxID.Text != "")
                {
                    if (MessageBox.Show("Deseja remover esse professor?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string id = TextBoxID.Text;
                        con.Open();
                        string sql = "DELETE FROM tbprofessor WHERE `idprofessor` = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Dispose();
                        MessageBox.Show("Professor deletado");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um professor");
                }
            }
        }
    }
}
