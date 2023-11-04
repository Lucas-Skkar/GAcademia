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
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

        private void btn_searchUser_Click(object sender, EventArgs e)
        {
            if(tBoxSearchUser.Text !="")
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT idaluno, nome, nascimento, rg, cpf, endereco, num, bairro, cidade, estado, celular, email, objetivo, obs "
                + "FROM dbacademia.tbalunos WHERE idaluno LIKE ? OR nome LIKE ?", con) ;
                cmd.Parameters.AddWithValue("idaluno", tBoxSearchUser.Text + "%");
                cmd.Parameters.AddWithValue("nome", tBoxSearchUser.Text + "%");
                MySqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    textBoxId.Text = srd.GetValue(0).ToString();
                    textBoxNome.Text = srd.GetValue(1).ToString();
                    MtextBoxNascimento.Text = srd.GetValue(2).ToString();
                    textBoxRg.Text = srd.GetValue(3).ToString();
                    MtextBoxCpf.Text = srd.GetValue(4).ToString();
                    textBoxEndereco.Text = srd.GetValue(5).ToString();
                    textBoxNumero.Text = srd.GetValue(6).ToString();
                    textBoxBairro.Text = srd.GetValue(7).ToString();
                    textBoxCidade.Text = srd.GetValue(8).ToString();
                    textBoxEstado.Text = srd.GetValue(9).ToString();
                    MtextBoxTelefone.Text = srd.GetValue(10).ToString();
                    textBoxEmail.Text = srd.GetValue(11).ToString();
                    textBoxObjetivo.Text = srd.GetValue(12).ToString();
                    textBoxObs.Text = srd.GetValue(13).ToString();
                }
                con.Close();
                srd.DisposeAsync();
            }
            
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "" && MtextBoxNascimento.Text != "" && textBoxRg.Text != "" && MtextBoxCpf.Text != "" && textBoxEndereco.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && textBoxCidade.Text != "" && textBoxEstado.Text != "" && MtextBoxTelefone.Text != "" && textBoxEmail.Text != "")
            {
                if (MessageBox.Show("Deseja adicionar esse usuário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand check_usName = new MySqlCommand("SELECT * FROM tbalunos WHERE (`cpf` = @c)", con);
                    check_usName.Parameters.AddWithValue("@c", MtextBoxCpf.Text);
                    MySqlDataReader reader = check_usName.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Usuario já existe");
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tbalunos (`nome`, `nascimento`, `rg`, `cpf`, `endereco`, `num`, `bairro`, `cidade`, `estado`, `celular`, `email`, `objetivo`, `obs`)" + " VALUES (@Nome, @Nascimento, @Rg, @Cpf, @Endereco, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @Email, @Objetivo, @Obs)", con);

                        cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150);
                        cmd.Parameters.Add("@Nascimento", MySqlDbType.VarChar, 10);
                        cmd.Parameters.Add("@Rg", MySqlDbType.VarChar, 15);
                        cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 15);
                        cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar, 100);
                        cmd.Parameters.Add("@Numero", MySqlDbType.VarChar, 10);
                        cmd.Parameters.Add("@Bairro", MySqlDbType.VarChar, 30);
                        cmd.Parameters.Add("@Cidade", MySqlDbType.VarChar, 100);
                        cmd.Parameters.Add("@Estado", MySqlDbType.VarChar, 10);
                        cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar, 20);
                        cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 50);
                        cmd.Parameters.Add("@Objetivo", MySqlDbType.VarChar, 150);
                        cmd.Parameters.Add("@Obs", MySqlDbType.VarChar, 200);

                        cmd.Parameters["@nome"].Value = textBoxNome.Text;
                        cmd.Parameters["@Nascimento"].Value = MtextBoxNascimento.Text;
                        cmd.Parameters["@Rg"].Value = textBoxRg.Text;
                        cmd.Parameters["@Cpf"].Value = MtextBoxCpf.Text;
                        cmd.Parameters["@Endereco"].Value = textBoxEndereco.Text;
                        cmd.Parameters["@Numero"].Value = textBoxNumero.Text;
                        cmd.Parameters["@Bairro"].Value = textBoxBairro.Text;
                        cmd.Parameters["@Cidade"].Value = textBoxCidade.Text;
                        cmd.Parameters["@Estado"].Value = textBoxEstado.Text;
                        cmd.Parameters["@Telefone"].Value = MtextBoxTelefone.Text;
                        cmd.Parameters["@Email"].Value = textBoxEmail.Text;
                        cmd.Parameters["@Objetivo"].Value = textBoxObjetivo.Text;
                        cmd.Parameters["@Obs"].Value = textBoxObs.Text;

                        reader.DisposeAsync();
                        cmd.ExecuteNonQuery();
                       // MessageBox.Show("Adicionado com sucesso!");
                        if (MessageBox.Show("Adicionado com sucesso! Gostaria de adicionar a mensalidade?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Mensalidades.call = true;
                            Mensalidades fm = new Mensalidades();
                            fm.ShowDialog();
                        }
                    }
                    con.Close();
                    reader.DisposeAsync();
                }
            }
            else
            {
                MessageBox.Show("Um ou mais campos estão vazios, porfavor preecha todos!");
            }
        }

        private void btn_DelUser_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                if (MessageBox.Show("Deseja remover esse usuário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = textBoxId.Text;
                    con.Open();
                    string sql = "DELETE FROM tbalunos WHERE `idaluno` = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuário deletado");
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário");
            }
        }

        private void btn_UpdUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE tbalunos SET `nome`=@nome, `nascimento`=@Nascimento, `rg`=@Rg, `cpf`=@Cpf, `endereco`=@Endereco, `num`=@Numero, `bairro`=@Bairro, `cidade`=@Cidade, `estado`=@Estado, `celular`=@Telefone, `email`=@Email, `objetivo`=@Objetivo, `obs`=@Obs WHERE `idaluno`=@Id", con);

                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 150);
                cmd.Parameters.Add("@Nascimento", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Rg", MySqlDbType.VarChar, 15);
                cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 15);
                cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@Numero", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Bairro", MySqlDbType.VarChar, 30);
                cmd.Parameters.Add("@Cidade", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@Estado", MySqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Objetivo", MySqlDbType.VarChar, 150);
                cmd.Parameters.Add("@Obs", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@Id", MySqlDbType.Int32, 11);

                cmd.Parameters["@nome"].Value = textBoxNome.Text;
                cmd.Parameters["@Nascimento"].Value = MtextBoxNascimento.Text;
                cmd.Parameters["@Rg"].Value = textBoxRg.Text;
                cmd.Parameters["@Cpf"].Value = MtextBoxCpf.Text;
                cmd.Parameters["@Endereco"].Value = textBoxEndereco.Text;
                cmd.Parameters["@Numero"].Value = textBoxNumero.Text;
                cmd.Parameters["@Bairro"].Value = textBoxBairro.Text;
                cmd.Parameters["@Cidade"].Value = textBoxCidade.Text;
                cmd.Parameters["@Estado"].Value = textBoxEstado.Text;
                cmd.Parameters["@Telefone"].Value = MtextBoxTelefone.Text;
                cmd.Parameters["@Email"].Value = textBoxEmail.Text;
                cmd.Parameters["@Objetivo"].Value = textBoxObjetivo.Text;
                cmd.Parameters["@Obs"].Value = textBoxObs.Text;
                cmd.Parameters["@Id"].Value = textBoxId.Text;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Dados atualizados com sucesso!");
            }
        }

        private void tBoxSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (tBoxSearchUser.TextLength >= 1)
            {
                con.Open();
                string sql = "SELECT idaluno, nome FROM dbacademia.tbalunos ";
                sql += "WHERE idaluno LIKE ? OR nome LIKE ?";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("idaluno", tBoxSearchUser.Text + "%");
                cmd.Parameters.AddWithValue("nome", tBoxSearchUser.Text + "%");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt != null && dt.Rows.Count > 0)
                {
                    searchResult.DataSource = dt;
                    searchResult.Height = searchResult.Rows.Count * 30;
                }
                else
                {
                    searchResult.Height = 0;
                }

                cmd.Dispose();
                da.Dispose();
                con.Close();

            }
            else if (tBoxSearchUser.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            tBoxSearchUser.Text = row.Cells["Aluno"].Value.ToString();
            searchResult.Height = 0;
        }

    }
}