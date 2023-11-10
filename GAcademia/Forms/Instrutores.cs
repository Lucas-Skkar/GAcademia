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
        private Rectangle TextBoxSearchOriginal;
        private Rectangle btn_searchOriginal;
        private Rectangle TextBoxInfNomeOriginal;
        private Rectangle TextBoxNomeOriginal;
        private Rectangle TextBoxIDOriginal;
        private Rectangle TextBoxInfIDOriginal;
        private Rectangle TextBoxInfCpfOriginal;
        private Rectangle MTextBoxCPFOriginal;
        private Rectangle MTextBoxCelularOriginal;
        private Rectangle TextBoxInfCelOriginal;
        private Rectangle TextBoxInfNascOriginal;
        private Rectangle MTextBoxNascimentoOriginal;
        private Rectangle ComboBoxSexoOriginal;
        private Rectangle btn_addOriginal;
        private Rectangle btn_updateOriginal;
        private Rectangle btn_deleteOriginal;
        private Rectangle searchResultOriginal;

        private Size formOriginal;

        public Instrutores()
        {
            InitializeComponent();

            formOriginal = this.Size;
            TextBoxSearchOriginal = new Rectangle(TextBoxSearch.Location.X, TextBoxSearch.Location.Y, TextBoxSearch.Width, TextBoxSearch.Height);
            btn_searchOriginal = new Rectangle(btn_search.Location.X, btn_search.Location.Y, btn_search.Width, btn_search.Height);
            TextBoxInfNomeOriginal = new Rectangle(TextBoxInfNome.Location.X, TextBoxInfNome.Location.Y, TextBoxInfNome.Width, TextBoxInfNome.Height);
            TextBoxNomeOriginal = new Rectangle(TextBoxNome.Location.X, TextBoxNome.Location.Y, TextBoxNome.Width, TextBoxNome.Height);
            TextBoxIDOriginal = new Rectangle(TextBoxID.Location.X, TextBoxID.Location.Y, TextBoxID.Width, TextBoxID.Height);
            TextBoxInfIDOriginal = new Rectangle(TextBoxInfID.Location.X, TextBoxInfID.Location.Y, TextBoxInfID.Width, TextBoxInfID.Height);
            TextBoxInfCpfOriginal = new Rectangle(TextBoxInfCpf.Location.X, TextBoxInfCpf.Location.Y, TextBoxInfCpf.Width, TextBoxInfCpf.Height);
            MTextBoxCPFOriginal = new Rectangle(MTextBoxCPF.Location.X, MTextBoxCPF.Location.Y, MTextBoxCPF.Width, MTextBoxCPF.Height);
            MTextBoxCelularOriginal = new Rectangle(MTextBoxCelular.Location.X, MTextBoxCelular.Location.Y, MTextBoxCelular.Width, MTextBoxCelular.Height);
            TextBoxInfCelOriginal = new Rectangle(TextBoxInfCel.Location.X, TextBoxInfCel.Location.Y, TextBoxInfCel.Width, TextBoxInfCel.Height);
            TextBoxInfNascOriginal = new Rectangle(TextBoxInfNasc.Location.X, TextBoxInfNasc.Location.Y, TextBoxInfNasc.Width, TextBoxInfNasc.Height);
            MTextBoxNascimentoOriginal = new Rectangle(MTextBoxNascimento.Location.X, MTextBoxNascimento.Location.Y, MTextBoxNascimento.Width, MTextBoxNascimento.Height);
            ComboBoxSexoOriginal = new Rectangle(ComboBoxSexo.Location.X, ComboBoxSexo.Location.Y, ComboBoxSexo.Width, ComboBoxSexo.Height);
            btn_addOriginal = new Rectangle(btn_add.Location.X, btn_add.Location.Y, btn_add.Width, btn_add.Height);
            btn_updateOriginal = new Rectangle(btn_update.Location.X, btn_update.Location.Y, btn_update.Width, btn_update.Height);
            btn_deleteOriginal = new Rectangle(btn_delete.Location.X, btn_delete.Location.Y, btn_delete.Width, btn_delete.Height);
            searchResultOriginal = new Rectangle(searchResult.Location.X, TextBoxSearch.Location.Y + 25, searchResult.Width, searchResult.Height);
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
            if (TextBoxSearch.Text != "")
            {
                try
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
                        MTextBoxCPF.Text = srd.GetValue(2).ToString();
                        MTextBoxNascimento.Text = srd.GetValue(3).ToString();
                        ComboBoxSexo.Text = srd.GetValue(4).ToString();
                        MTextBoxCelular.Text = srd.GetValue(5).ToString();
                    }
                    srd.DisposeAsync();
                    con.Close();
                }
                catch
                {

                }
                
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.TextLength >= 1)
            {
                try
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (TextBoxNome.Text != "" && MTextBoxCPF.Text != "" && MTextBoxNascimento.Text != "" && ComboBoxSexo.Text != "" && MTextBoxCelular.Text != "")
            {
                if (MessageBox.Show("Deseja adicionar esse professor?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        MySqlCommand check_pName = new MySqlCommand("SELECT * FROM tbprofessor WHERE (`cpf` = @c)", con);
                        check_pName.Parameters.AddWithValue("@c", MTextBoxCPF.Text);
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
                            cmd.Parameters["@Cpf"].Value = MTextBoxCPF.Text;
                            cmd.Parameters["@Nascimento"].Value = MTextBoxNascimento.Text;
                            cmd.Parameters["@Sexo"].Value = ComboBoxSexo.Text;
                            cmd.Parameters["@celular"].Value = MTextBoxCelular.Text;

                            dr.DisposeAsync();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Adicionado com sucesso!");
                        }
                        dr.DisposeAsync();
                        con.Close();
                    }
                    catch
                    {

                    }
                    
                }
             }
            else
            {
                MessageBox.Show("Um ou mais campos estão vazios, porfavor preecha todos!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (TextBoxID.Text != "")
            {
                if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
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
                        cmd.Parameters["@Cpf"].Value = MTextBoxCPF.Text;
                        cmd.Parameters["@Nascimento"].Value = MTextBoxNascimento.Text;
                        cmd.Parameters["@Sexo"].Value = ComboBoxSexo.Text;
                        cmd.Parameters["@Celular"].Value = MTextBoxCelular.Text;

                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.DisposeAsync();
                        MessageBox.Show("Dados atualizados com sucesso!");
                    }
                    catch
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um professor");
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
                        try
                        {
                            con.Open();
                            string sql = "DELETE FROM tbprofessor WHERE `idprofessor` = @id";
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.Add(new MySqlParameter("@id", id));
                            cmd.ExecuteNonQuery();
                            con.Close();
                            cmd.Dispose();
                            MessageBox.Show("Professor deletado");
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um professor");
                }
            }
        }

        private void resize()
        {
            resizeControl(TextBoxSearchOriginal, TextBoxSearch);
            resizeControl(btn_searchOriginal, btn_search);
            resizeControl(TextBoxInfNomeOriginal, TextBoxInfNome);
            resizeControl(TextBoxNomeOriginal, TextBoxNome);
            resizeControl(TextBoxIDOriginal, TextBoxID);
            resizeControl(TextBoxInfIDOriginal, TextBoxInfID);
            resizeControl(TextBoxInfCpfOriginal, TextBoxInfCpf);
            resizeControl(MTextBoxCPFOriginal, MTextBoxCPF);
            resizeControl(MTextBoxCelularOriginal, MTextBoxCelular);
            resizeControl(TextBoxInfCelOriginal, TextBoxInfCel);
            resizeControl(TextBoxInfNascOriginal, TextBoxInfNasc);
            resizeControl(MTextBoxNascimentoOriginal, MTextBoxNascimento);
            resizeControl(ComboBoxSexoOriginal, ComboBoxSexo);
            resizeControl(btn_addOriginal, btn_add);
            resizeControl(btn_updateOriginal, btn_update);
            resizeControl(btn_deleteOriginal, btn_delete);
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

        private void Instrutores_Resize(object sender, EventArgs e)
        {
            resize();
        }
    }
}
