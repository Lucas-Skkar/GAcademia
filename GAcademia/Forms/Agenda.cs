using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using static GAcademia.UserControlMySqlConfig;

namespace GAcademia.Forms
{
    public partial class Agenda : Form
    {
        string emailOrigen;
        string emailSenha;
        private static bool add = true;

        private Rectangle TextBoxSearchOriginal;
        private Rectangle btn_searchOriginal;
        private Rectangle ComboBoxAlunoOriginal;
        private Rectangle TextBoxIdAlunoOriginal;
        private Rectangle TextBoxInfIdAlunoOriginal;
        private Rectangle ComboBoxProfessorOriginal;
        private Rectangle TextBoxIdProfOriginal;
        private Rectangle TextBoxInfIdProfOriginal;
        private Rectangle ComboBoxDiaOriginal;
        private Rectangle MTextBoxHorarioOriginal;
        private Rectangle TextBoxInfHorarioOriginal;
        private Rectangle LabelDescricaoOriginal;
        private Rectangle TextBoxDescOriginal;
        private Rectangle btn_agendarOriginal;
        private Rectangle tbn_updOriginal;
        private Rectangle btn_deleteOriginal;
        private Rectangle searchResultOriginal;

        private Size formOriginal;

        public Agenda()
        {
            InitializeComponent();

            // Definição das posições iniciais dos objetos da tela (botões, caixa de textos, etc) para redimensionamento da tela.
            formOriginal = this.Size;
            TextBoxSearchOriginal = new Rectangle(TextBoxSearch.Location.X, TextBoxSearch.Location.Y, TextBoxSearch.Width, TextBoxSearch.Height);
            btn_searchOriginal = new Rectangle(btn_search.Location.X, btn_search.Location.Y, btn_search.Width, btn_search.Height);
            ComboBoxAlunoOriginal = new Rectangle(ComboBoxAluno.Location.X, ComboBoxAluno.Location.Y, ComboBoxAluno.Width, ComboBoxAluno.Height);
            TextBoxIdAlunoOriginal = new Rectangle(TextBoxIdAluno.Location.X, TextBoxIdAluno.Location.Y, TextBoxIdAluno.Width, TextBoxIdAluno.Height);
            TextBoxInfIdAlunoOriginal = new Rectangle(TextBoxInfIdAluno.Location.X, TextBoxInfIdAluno.Location.Y, TextBoxInfIdAluno.Width, TextBoxInfIdAluno.Height);
            ComboBoxProfessorOriginal = new Rectangle(ComboBoxProfessor.Location.X, ComboBoxProfessor.Location.Y, ComboBoxProfessor.Width, ComboBoxProfessor.Height);
            TextBoxIdProfOriginal = new Rectangle(TextBoxIdProf.Location.X, TextBoxIdProf.Location.Y, TextBoxIdProf.Width, TextBoxIdProf.Height);
            TextBoxInfIdProfOriginal = new Rectangle(TextBoxInfIdProf.Location.X, TextBoxInfIdProf.Location.Y, TextBoxInfIdProf.Width, TextBoxInfIdProf.Height);
            ComboBoxDiaOriginal = new Rectangle(ComboBoxDia.Location.X, ComboBoxDia.Location.Y, ComboBoxDia.Width, ComboBoxDia.Height);
            MTextBoxHorarioOriginal = new Rectangle(MTextBoxHorario.Location.X, MTextBoxHorario.Location.Y, MTextBoxHorario.Width, MTextBoxHorario.Height);
            TextBoxInfHorarioOriginal = new Rectangle(TextBoxInfHorario.Location.X, TextBoxInfHorario.Location.Y, TextBoxInfHorario.Width, TextBoxInfHorario.Height);
            LabelDescricaoOriginal = new Rectangle(LabelDescricao.Location.X, LabelDescricao.Location.Y, LabelDescricao.Width, LabelDescricao.Height);
            TextBoxDescOriginal = new Rectangle(TextBoxDesc.Location.X, TextBoxDesc.Location.Y, TextBoxDesc.Width, TextBoxDesc.Height);
            btn_agendarOriginal = new Rectangle(btn_agendar.Location.X, btn_agendar.Location.Y, btn_agendar.Width, btn_agendar.Height);
            tbn_updOriginal = new Rectangle(tbn_upd.Location.X, tbn_upd.Location.Y, tbn_upd.Width, tbn_upd.Height);
            btn_deleteOriginal = new Rectangle(btn_delete.Location.X, btn_delete.Location.Y, btn_delete.Width, btn_delete.Height);
            searchResultOriginal = new Rectangle(searchResult.Location.X, TextBoxSearch.Location.Y + 32, searchResult.Width, searchResult.Height);
        }

        // Cria novo objeto usando a string de conexão do banco de dados.
        MySqlConnection con = new MySqlConnection(Database.Connect.dbConnect);

        private void Agenda_Load(object sender, EventArgs e)
        {
            // Cria a lista diaSemana.
            var dia = new List<diaSemana>();
            dia.Add(new diaSemana() { diaId = 0, nomeDia = "" });
            dia.Add(new diaSemana() { diaId = 1, nomeDia = "Domingo" });
            dia.Add(new diaSemana() { diaId = 2, nomeDia = "Segunda" });
            dia.Add(new diaSemana() { diaId = 3, nomeDia = "Terça" });
            dia.Add(new diaSemana() { diaId = 4, nomeDia = "Quarta" });
            dia.Add(new diaSemana() { diaId = 5, nomeDia = "Quinta" });
            dia.Add(new diaSemana() { diaId = 6, nomeDia = "Sexta" });
            dia.Add(new diaSemana() { diaId = 7, nomeDia = "Sábado" });

            // Adiciona a lista "diaSemana" para o ComboBoxDia.
            ComboBoxDia.DataSource = dia;
            ComboBoxDia.DisplayMember = "nomeDia";
            ComboBoxDia.Text = "Selecione o dia";

            
            try
            {
                // Adiciona ao "ComboBoxProfessor" os dados das colunas "idprofessor" e "nome" da tabela "tbprofessor".
                con.Open();
                MySqlDataAdapter daP = new MySqlDataAdapter("SELECT idprofessor, nome FROM tbprofessor", con);
                DataSet dtP = new DataSet();
                daP.Fill(dtP, "Professor");
                ComboBoxProfessor.DataSource = dtP.Tables["Professor"];
                ComboBoxProfessor.DisplayMember = "nome";
                ComboBoxProfessor.ValueMember = "idprofessor";
                ComboBoxProfessor.Text = "Selecionar Professor";

                // Adiciona ao "ComboBoxAluno" os dados das colunas "idaluno" e "nome" da tabela "tbalunos".
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
               // MessageBox.Show("Banco de dado desconectado, verifique a conexão em Configurações");
            }
            
        }

        // Quando a seleção do "ComboBoxAluno" mudar, o texto do "TextBoxIdAluno" recebe o "ValueMember". 
        private void ComboBoxAluno_SelectionChangeCommitted(object sender, EventArgs e)
        {
                TextBoxIdAluno.Text = ComboBoxAluno.GetItemText(ComboBoxAluno.SelectedValue);   
        }

        // Quando a seleção do "ComboBoxProfessor" mudar, o texto do "TextBoxIdProf" recebe o "ValueMember".
        private void ComboBoxProfessor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TextBoxIdProf.Text = ComboBoxProfessor.GetItemText(ComboBoxProfessor.SelectedValue);
        }

        // classe usada para criar a lista de mesmo nome
        private class diaSemana
        {
            public int diaId { get; set; }
            public string nomeDia { get; set; }
        }

        // Insere no banco de dados os valores dos textbox e combobox.
        private void btn_agendar_Click(object sender, EventArgs e)
        {
            // Checa se os textbox e combobox não estão vazios.
            if (ComboBoxAluno.Text != "" && ComboBoxProfessor.Text != "" && ComboBoxDia.Text != "" && MTextBoxHorario.Text != "  :")
            {
                // Apenas para informar que está adicionando um novo registro e não alterando um já existente, afeta a mensagem do email. 
                add = true;

                // Diálogo de confirmação para evitar agendar sem querer.
                if (MessageBox.Show("Deseja agendar esse horário?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tbagenda (`aluno`, `professor`, `dia`, `hora`, `descricao`) VALUES (@Aluno, @Professor, @Dia, @Hora, @Desc)", con);

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

                        // Pergunta se quer ou não enviar email para o aluno informando o agendamento.
                        if (MessageBox.Show("Deseja enviar email para o aluno avisando sobre o agendamento?", "Deseja enviar email?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            sendEmail();
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Um ou mais campos estão vazios, porfavor preecha todos os campos!");
            }
        }

        // Procura na tabela "tbagenda" id ou nome como o digitado no "TextBoxSearch". 
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // define quantos caracteres sõa necessários para começar a procura.
            if (TextBoxSearch.TextLength >= 1)
            {
                try
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

                    // se encontrar algo, mostra no "searchResult". 
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
            // se o número de caracteres do "TextBoxSearch" for 0, esconde o "searchResult".
            else if (TextBoxSearch.TextLength == 0)
            {
                searchResult.Height = 0;
            }
        }

        // Ao clicar na célula do "searchResult", o nome do aluno vai para o "TextBoxSearch".
        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            TextBoxSearch.Text = row.Cells["Aluno"].Value.ToString();
            searchResult.Height = 0;
        }

        // Adiciona os valors da tabela "tbagenda" nos textbox e combobox.
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text != "")
            {
                try
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
                catch
                {

                }
                
            }
        }

        // Atualiza os valores da tabela "tbagenda" com os valores dos textbox e combobox.
        private void tbn_upd_Click(object sender, EventArgs e)
        {
            // Apenas informa que está atualizando um registro já existente, afeta a mensagem do email. 
            add = false;

            if (TextBoxIdAgenda.Text != "")
            {
                if (MessageBox.Show("Deseja atualizar os dados?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
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

                        // diálogo de confirmação de envio de email.
                        if (MessageBox.Show("Deseja enviar email para o aluno avisando sobre a alteração no agendamento?", "Deseja enviar email?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            sendEmail();
                        }
                    }
                    catch
                    {

                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Falha na atualização! Tenha certeza de ter selecionado uma agenda antes de atualizar.");
            }
            
        }

        // Deleta linha(row) da tabela "tbagenda" onde o "idagenda" é igual ao valor da caixa de texto "TextBoxIdAgenda".
        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Checa se o texto no TextBoxIdAgenda não está vazio.
            if (TextBoxIdAgenda.Text != "")
            {
                if (MessageBox.Show("Deseja remover esse agendamento?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = TextBoxIdAgenda.Text;
                    try
                    {
                        
                        con.Open();
                        string sql = "DELETE FROM tbagenda WHERE `idagenda` = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Dispose();
                        MessageBox.Show("Agendamento deletado");
                    }
                    catch
                    {

                    }
                    
                }
            }
            // Caso o "TextBoxIdAgenda" estiver vazio mostra a mensagem.
            else
            {
                MessageBox.Show("Selecione um agendamento");
            }
        }

        //Reposiciona os objetos da tela quando redimensiona a tela.
        private void resize()
        {
            resizeControl(TextBoxSearchOriginal, TextBoxSearch);
            resizeControl(btn_searchOriginal, btn_search);
            resizeControl(ComboBoxAlunoOriginal, ComboBoxAluno);
            resizeControl(TextBoxIdAlunoOriginal, TextBoxIdAluno);
            resizeControl(TextBoxInfIdAlunoOriginal, TextBoxInfIdAluno);
            resizeControl(ComboBoxProfessorOriginal, ComboBoxProfessor);
            resizeControl(TextBoxIdProfOriginal, TextBoxIdProf);
            resizeControl(TextBoxInfIdProfOriginal, TextBoxInfIdProf);
            resizeControl(ComboBoxDiaOriginal, ComboBoxDia);
            resizeControl(MTextBoxHorarioOriginal, MTextBoxHorario);
            resizeControl(TextBoxInfHorarioOriginal, TextBoxInfHorario);
            resizeControl(LabelDescricaoOriginal, LabelDescricao);
            resizeControl(TextBoxDescOriginal, TextBoxDesc);
            resizeControl(btn_agendarOriginal, btn_agendar);
            resizeControl(tbn_updOriginal, tbn_upd);
            resizeControl(btn_deleteOriginal, btn_delete);
            resizeControl(searchResultOriginal, searchResult);

            if (searchResult.Location.Y > TextBoxSearch.Location.Y + 32)
            {
                searchResult.Top = +96;
            }
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
        private void Agenda_Resize(object sender, EventArgs e)
        {
            resize();
        }

        // Seleciona o email do aluno e usa as credenciais carregadas no loadEmail para enviar email para o aluno. 
        private void sendEmail()
        {
            loadEmail();
            try
            {
                con.Open();
                string sql = "SELECT email FROM tbalunos WHERE idaluno =@Id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", TextBoxIdAluno.Text);
                string emailDestino = (string)cmd.ExecuteScalar();
                con.Close();

                ICredentialsByHost credentials = new NetworkCredential(emailOrigen, emailSenha);

                SmtpClient cliente = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = credentials
                };

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(emailOrigen);
                mail.To.Add(emailDestino);
                mail.Subject = "Agendamento de treino na academia"; // Assunto do email
                if(add == true)
                {
                    mail.Body = "Você tem treino marcado para " + ComboBoxDia.Text + " as " + MTextBoxHorario.Text;
                }
                else
                {
                    mail.Body = "Seu treino foi alterado para " + ComboBoxDia.Text + " as " + MTextBoxHorario.Text;
                }
                
                cliente.Send(mail);
                MessageBox.Show("Email enviado");
            }
            catch
            {
                if (File.Exists("eConfig.txt"))
                {
                    MessageBox.Show("Não foi possível enviar o email.");
                }
                else
                {
                    MessageBox.Show("Email não cadastrado. Adicione um email em Configurações > Configurar Email.");
                }
            }
        }

        // Descriptografa o arquivo com os registros de email e senha.
        private void readEmail()
        {
            string encryptedData;
            using (StreamReader reader = new StreamReader("eConfig.txt"))
            {
                encryptedData = reader.ReadToEnd();
            }

            string decryptedData = DataEncryptor.Decrypt(encryptedData);

            string[] dataParts = decryptedData.Split('\n');
            if (dataParts.Length == 2)
            {
                string emailOrigen = dataParts[0];
                string emailSenha = dataParts[1];

                using (StreamWriter writer = new StreamWriter("eConfig.txt"))
                {
                    writer.WriteLine($"emailOrigen={emailOrigen}");
                    writer.WriteLine($"emailSenha={emailSenha}");
                }
            }
        }

        // Pega os valores descriptografados do readEmail e adiciona a "emailOrigen" e "emailSenha".
        private void loadEmail()
        {
            try
            {
                if (File.Exists("eConfig.txt"))
                {
                    readEmail();
                    string[] linhas = File.ReadAllLines("eConfig.txt");
                    foreach (string linha in linhas)
                    {
                        string[] partes = linha.Split('=');
                        if (partes.Length == 2)
                        {
                            string chave = partes[0];
                            string valor = partes[1];

                            switch (chave)
                            {
                                case "emailOrigen":
                                    emailOrigen = valor;
                                    break;
                                case "emailSenha":
                                    emailSenha = valor;
                                    break;
                            }
                        }
                    }
                    string criptografar = $"{emailOrigen}\n{emailSenha}";
                    string encryptedData = DataEncryptor.Encrypt(criptografar);
                    using (StreamWriter writer = new StreamWriter("eConfig.txt"))
                    {
                        writer.Write(encryptedData);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar valores do arquivo: " + ex.Message);
            }
        }

        // Quando entrar no TextBoxSearch, apaga o texto padrão e muda a cor da fonte.
        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "Digite o número ID do agendamento ou Nome do aluno.")
            {
                TextBoxSearch.StateActive.Content.Color1 = Color.Silver;
                TextBoxSearch.Text = "";
            }
        }

        // Quando sair do TextBoxSearch (cliclar em outro textbox), se não tiver texto volta o texto padrão
        // e muda a cor para mais escuro, caso tenha algum texto só muda a cor para mais claro. 
        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
            {
                TextBoxSearch.StateActive.Content.Color1 = Color.Gray;
                TextBoxSearch.StateNormal.Content.Color1 = Color.Gray;
                TextBoxSearch.Text = "Digite o número ID do agendamento ou Nome do aluno.";
            }
            else
            {
                TextBoxSearch.StateActive.Content.Color1 = Color.LightGray;
                TextBoxSearch.StateNormal.Content.Color1 = Color.LightGray;
            }
        }
    }
}
