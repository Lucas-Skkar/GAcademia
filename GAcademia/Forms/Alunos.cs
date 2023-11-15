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
        private Rectangle btn_searchUserOriginal;
        private Rectangle tBoxSearchUserOriginal;
        private Rectangle textBoxIdOriginal;
        private Rectangle TextBoxInfIDOriginal;
        private Rectangle TextBoxInfNomeOriginal;
        private Rectangle textBoxNomeOriginal;
        private Rectangle MtextBoxNascimentoOriginal;
        private Rectangle TextBoxInfNascOriginal;
        private Rectangle TextBoxInfRgOriginal;
        private Rectangle textBoxRgOriginal;
        private Rectangle MtextBoxCpfOriginal;
        private Rectangle TextBoxInfCpfOriginal;
        private Rectangle TextBoxInfTelefoneOriginal;
        private Rectangle MtextBoxTelefoneOriginal;
        private Rectangle textBoxEmailOriginal;
        private Rectangle TextBoxInfEmailOriginal;
        private Rectangle TextBoxInfEndecoOriginal;
        private Rectangle textBoxEnderecoOriginal;
        private Rectangle TextBoxInfNumeroOriginal;
        private Rectangle textBoxNumeroOriginal;
        private Rectangle textBoxBairroOriginal;
        private Rectangle TextBoxInfBairroOriginal;
        private Rectangle TextBoxInfCidadeOriginal;
        private Rectangle textBoxCidadeOriginal;
        private Rectangle textBoxEstadoOriginal;
        private Rectangle TextBoxInfEstadoOriginal;
        private Rectangle TextBoxInfObjetivoOriginal;
        private Rectangle textBoxObjetivoOriginal;
        private Rectangle textBoxObsOriginal;
        private Rectangle TextBoxInfObsOriginal;
        private Rectangle btn_addUserOriginal;
        private Rectangle btn_UpdUserOriginal;
        private Rectangle btn_DelUserOriginal;
        private Rectangle searchResultOriginal;

        private Size formOriginal;

        public Alunos()
        {
            InitializeComponent();

            // Definição das posições iniciais dos objetos da tela (botões, caixa de textos, etc) para redimensionamento da tela.
            formOriginal = this.Size;
            btn_searchUserOriginal = new Rectangle(btn_searchUser.Location.X, btn_searchUser.Location.Y, btn_searchUser.Width, btn_searchUser.Height);
            tBoxSearchUserOriginal = new Rectangle(tBoxSearchUser.Location.X, tBoxSearchUser.Location.Y, tBoxSearchUser.Width, tBoxSearchUser.Height);
            textBoxIdOriginal = new Rectangle(textBoxId.Location.X, textBoxId.Location.Y, textBoxId.Width, textBoxId.Height);
            TextBoxInfIDOriginal = new Rectangle(TextBoxInfID.Location.X, TextBoxInfID.Location.Y, TextBoxInfID.Width, TextBoxInfID.Height);
            TextBoxInfNomeOriginal = new Rectangle(TextBoxInfNome.Location.X, TextBoxInfNome.Location.Y, TextBoxInfNome.Width, TextBoxInfNome.Height);
            textBoxNomeOriginal = new Rectangle(textBoxNome.Location.X, textBoxNome.Location.Y, textBoxNome.Width, textBoxNome.Height);
            MtextBoxNascimentoOriginal = new Rectangle(MtextBoxNascimento.Location.X, MtextBoxNascimento.Location.Y, MtextBoxNascimento.Width, MtextBoxNascimento.Height);
            TextBoxInfNascOriginal = new Rectangle(TextBoxInfNasc.Location.X, TextBoxInfNasc.Location.Y, TextBoxInfNasc.Width, TextBoxInfNasc.Height);
            TextBoxInfRgOriginal = new Rectangle(TextBoxInfRg.Location.X, TextBoxInfRg.Location.Y, TextBoxInfRg.Width, TextBoxInfRg.Height);
            textBoxRgOriginal = new Rectangle(textBoxRg.Location.X, textBoxRg.Location.Y, textBoxRg.Width, textBoxRg.Height);
            MtextBoxCpfOriginal = new Rectangle(MtextBoxCpf.Location.X, MtextBoxCpf.Location.Y, MtextBoxCpf.Width, MtextBoxCpf.Height);
            TextBoxInfCpfOriginal = new Rectangle(TextBoxInfCpf.Location.X, TextBoxInfCpf.Location.Y, TextBoxInfCpf.Width, TextBoxInfCpf.Height);
            TextBoxInfTelefoneOriginal = new Rectangle(TextBoxInfTelefone.Location.X, TextBoxInfTelefone.Location.Y, TextBoxInfTelefone.Width, TextBoxInfTelefone.Height);
            MtextBoxTelefoneOriginal = new Rectangle(MtextBoxTelefone.Location.X, MtextBoxTelefone.Location.Y, MtextBoxTelefone.Width, MtextBoxTelefone.Height);
            textBoxEmailOriginal = new Rectangle(textBoxEmail.Location.X, textBoxEmail.Location.Y, textBoxEmail.Width, textBoxEmail.Height);
            TextBoxInfEmailOriginal = new Rectangle(TextBoxInfEmail.Location.X, TextBoxInfEmail.Location.Y, TextBoxInfEmail.Width, TextBoxInfEmail.Height);
            TextBoxInfEndecoOriginal = new Rectangle(TextBoxInfEndeco.Location.X, TextBoxInfEndeco.Location.Y, TextBoxInfEndeco.Width, TextBoxInfEndeco.Height);
            textBoxEnderecoOriginal = new Rectangle(textBoxEndereco.Location.X, textBoxEndereco.Location.Y, textBoxEndereco.Width, textBoxEndereco.Height);
            TextBoxInfNumeroOriginal = new Rectangle(TextBoxInfNumero.Location.X, TextBoxInfNumero.Location.Y, TextBoxInfNumero.Width, TextBoxInfNumero.Height);
            textBoxNumeroOriginal = new Rectangle(textBoxNumero.Location.X, textBoxNumero.Location.Y, textBoxNumero.Width, textBoxNumero.Height);
            textBoxBairroOriginal = new Rectangle(textBoxBairro.Location.X, textBoxBairro.Location.Y, textBoxBairro.Width, textBoxBairro.Height);
            TextBoxInfBairroOriginal = new Rectangle(TextBoxInfBairro.Location.X, TextBoxInfBairro.Location.Y, TextBoxInfBairro.Width, TextBoxInfBairro.Height);
            TextBoxInfCidadeOriginal = new Rectangle(TextBoxInfCidade.Location.X, TextBoxInfCidade.Location.Y, TextBoxInfCidade.Width, TextBoxInfCidade.Height);
            textBoxCidadeOriginal = new Rectangle(textBoxCidade.Location.X, textBoxCidade.Location.Y, textBoxCidade.Width, textBoxCidade.Height);
            textBoxEstadoOriginal = new Rectangle(textBoxEstado.Location.X, textBoxEstado.Location.Y, textBoxEstado.Width, textBoxEstado.Height);
            TextBoxInfEstadoOriginal = new Rectangle(TextBoxInfEstado.Location.X, TextBoxInfEstado.Location.Y, TextBoxInfEstado.Width, TextBoxInfEstado.Height);
            TextBoxInfObjetivoOriginal = new Rectangle(TextBoxInfObjetivo.Location.X, TextBoxInfObjetivo.Location.Y, TextBoxInfObjetivo.Width, TextBoxInfObjetivo.Height);
            textBoxObjetivoOriginal = new Rectangle(textBoxObjetivo.Location.X, textBoxObjetivo.Location.Y, textBoxObjetivo.Width, textBoxObjetivo.Height);
            textBoxObsOriginal = new Rectangle(textBoxObs.Location.X, textBoxObs.Location.Y, textBoxObs.Width, textBoxObs.Height);
            TextBoxInfObsOriginal = new Rectangle(TextBoxInfObs.Location.X, TextBoxInfObs.Location.Y, TextBoxInfObs.Width, TextBoxInfObs.Height);
            btn_addUserOriginal = new Rectangle(btn_addUser.Location.X, btn_addUser.Location.Y, btn_addUser.Width, btn_addUser.Height);
            btn_UpdUserOriginal = new Rectangle(btn_UpdUser.Location.X, btn_UpdUser.Location.Y, btn_UpdUser.Width, btn_UpdUser.Height);
            btn_DelUserOriginal = new Rectangle(btn_DelUser.Location.X, btn_DelUser.Location.Y, btn_DelUser.Width, btn_DelUser.Height);
            searchResultOriginal = new Rectangle(searchResult.Location.X, tBoxSearchUser.Location.Y + 25, searchResult.Width, searchResult.Height);
        }

        // Cria novo objeto usando a string de conexão do banco de dados.
        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

        // Seleciona os dados da tabela tbalunos e preenche as caixas de textos.
        private void btn_searchUser_Click(object sender, EventArgs e)
        {
            if(tBoxSearchUser.Text !="")
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT idaluno, nome, nascimento, rg, cpf, endereco, num, bairro, cidade, estado, celular, email, objetivo, obs "
                    + "FROM dbacademia.tbalunos WHERE idaluno LIKE ? OR nome LIKE ?", con);
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
                catch
                {

                }
                
            }
            
        }

        // Adiciona a tabela tbalunos o conteúdo das caixas de textos.
        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "" && MtextBoxNascimento.Text != "" && textBoxRg.Text != "" && MtextBoxCpf.Text != "" && textBoxEndereco.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && textBoxCidade.Text != "" && textBoxEstado.Text != "" && MtextBoxTelefone.Text != "" && textBoxEmail.Text != "")
            {
                if (MessageBox.Show("Deseja adicionar esse usuário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
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
                            string sql = "INSERT INTO tbalunos(`nome`, `nascimento`, `rg`, `cpf`, `endereco`, `num`, `bairro`, `cidade`, `estado`, `celular`, `email`, `objetivo`, `obs`) ";
                            sql += "VALUES(@Nome, @Nascimento, @Rg, @Cpf, @Endereco, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @Email, @Objetivo, @Obs)";
                            MySqlCommand cmd = new MySqlCommand(sql, con);

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

        // Deleta linha(row) da tabela tbalunos onde o idaluno é igual ao valor da caixa de texto textBoxId.
        private void btn_DelUser_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                if (MessageBox.Show("Deseja remover esse usuário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
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
                    catch
                    {

                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário");
            }
        }

        // Atualiza os registros da tabela tbalunos com o conteúdo das caixas de textos onde o valor de idaluno é igual ao do textBoxId.
        private void btn_UpdUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string sql = "UPDATE tbalunos SET `nome`=@nome, `nascimento`=@Nascimento, `rg`=@Rg, `cpf`=@Cpf, `endereco`=@Endereco, `num`=@Numero, `bairro`=@Bairro, ";
                    sql += "`cidade`=@Cidade, `estado`=@Estado, `celular`=@Telefone, `email`=@Email, `objetivo`=@Objetivo, `obs`=@Obs WHERE `idaluno`=@Id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 150);
                    cmd.Parameters.Add("@Nascimento", MySqlDbType.VarChar, 14);
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
                catch
                {

                }
                
            }
        }

        // Ao digitar algo no "tBoxSearchUser" busca na "tbalunos" valores similares (para número = idaluno, para letras = nome do aluno) 
        // e preenche o data grid "searchResult" com os valores encontrados, se houver.
        private void tBoxSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (tBoxSearchUser.TextLength >= 1)
            {
                try
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
                catch
                {

                }

            }
            else if (tBoxSearchUser.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        // Ao clicar na célula do data grid "searchResult", o nome é enviado para o "tBoxSearchUser".
        // Erro conhecido: Se tiver mais de um resultado, sempre selecionará o registro mais recente.
        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            tBoxSearchUser.Text = row.Cells["Aluno"].Value.ToString();
            searchResult.Height = 0;
        }

        //Calcula as novas posições dos objetos da tela quando redimensiona a tela.
        private void resize()
        {
            resizeControl(btn_searchUserOriginal, btn_searchUser);
            resizeControl(tBoxSearchUserOriginal, tBoxSearchUser);
            resizeControl(textBoxIdOriginal, textBoxId);
            resizeControl(TextBoxInfIDOriginal, TextBoxInfID);
            resizeControl(TextBoxInfNomeOriginal, TextBoxInfNome);
            resizeControl(textBoxNomeOriginal, textBoxNome);
            resizeControl(MtextBoxNascimentoOriginal, MtextBoxNascimento);
            resizeControl(TextBoxInfNascOriginal, TextBoxInfNasc);
            resizeControl(TextBoxInfRgOriginal, TextBoxInfRg);
            resizeControl(textBoxRgOriginal, textBoxRg);
            resizeControl(MtextBoxCpfOriginal, MtextBoxCpf);
            resizeControl(TextBoxInfCpfOriginal, TextBoxInfCpf);
            resizeControl(TextBoxInfTelefoneOriginal, TextBoxInfTelefone);
            resizeControl(MtextBoxTelefoneOriginal, MtextBoxTelefone);
            resizeControl(textBoxEmailOriginal, textBoxEmail);
            resizeControl(TextBoxInfEmailOriginal, TextBoxInfEmail);
            resizeControl(TextBoxInfEndecoOriginal, TextBoxInfEndeco);
            resizeControl(textBoxEnderecoOriginal, textBoxEndereco);
            resizeControl(TextBoxInfNumeroOriginal, TextBoxInfNumero);
            resizeControl(textBoxNumeroOriginal, textBoxNumero);
            resizeControl(textBoxBairroOriginal, textBoxBairro);
            resizeControl(TextBoxInfBairroOriginal, TextBoxInfBairro);
            resizeControl(TextBoxInfCidadeOriginal, TextBoxInfCidade);
            resizeControl(textBoxCidadeOriginal, textBoxCidade);
            resizeControl(textBoxEstadoOriginal, textBoxEstado);
            resizeControl(TextBoxInfEstadoOriginal, TextBoxInfEstado);
            resizeControl(TextBoxInfObjetivoOriginal, TextBoxInfObjetivo);
            resizeControl(textBoxObjetivoOriginal, textBoxObjetivo);
            resizeControl(textBoxObsOriginal, textBoxObs);
            resizeControl(TextBoxInfObsOriginal, TextBoxInfObs);
            resizeControl(btn_addUserOriginal, btn_addUser);
            resizeControl(btn_UpdUserOriginal, btn_UpdUser);
            resizeControl(btn_DelUserOriginal, btn_DelUser);
            resizeControl(searchResultOriginal, searchResult);
        }

        // Método usado no cálculo do redimensionamento.
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

        //Chama o "resize" quando redimensiona a tela.
        private void Alunos_Resize(object sender, EventArgs e)
        {
            resize();
        }

        // Quando entrar no TextBoxSearch, apaga o texto padrão e muda a cor da fonte.
        private void tBoxSearchUser_Enter(object sender, EventArgs e)
        {
            if (tBoxSearchUser.Text == "Digite o número ID ou Nome do aluno.")
            {
                tBoxSearchUser.StateActive.Content.Color1 = Color.Silver;
                tBoxSearchUser.Text = "";
            }
        }

        // Quando sair do TextBoxSearch (cliclar em outro textbox), se não tiver texto volta o texto padrão
        // e muda a cor para mais escuro, caso tenha algum texto só muda a cor para mais claro. 
        private void tBoxSearchUser_Leave(object sender, EventArgs e)
        {
            if (tBoxSearchUser.Text == "")
            {
                tBoxSearchUser.StateActive.Content.Color1 = Color.Gray;
                tBoxSearchUser.StateNormal.Content.Color1 = Color.Gray;
                tBoxSearchUser.Text = "Digite o número ID ou Nome do aluno.";
            }
            else
            {
                tBoxSearchUser.StateActive.Content.Color1 = Color.LightGray;
                tBoxSearchUser.StateNormal.Content.Color1 = Color.LightGray;
            }
        }
    }
}