using MigraDocCore.DocumentObjectModel;
using MigraDocCore.Rendering;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutricionalApp.DatabaseConnection;

namespace NutricionalApp
{
    public partial class CadGastosEnergeticos : Form
    {
        int GastoEnergeticoID = 0;
        int NutricionistaID = 0;
        string NutricionistaNome;
        int PacienteId = 0;
        int NivelId = 0;
        decimal calcNivelID = 0;
        int AtividadeFisicaID = 0;
        decimal MET = 0;
        int ProtocoloID = 0;
        string tipoSexo;
        int idadePaciente = 0;
        string queryAtvFisica = "SELECT \"id_gastoAtv\", \"atividade\", \"met\", \"frequencia\", \"duracao\", \"calorias\" FROM \"public\".\"vw_gastoatividade_detalhado\" Where gastos_id = @filtro";


        public CadGastosEnergeticos()
        {
            InitializeComponent();
            this.TopMost = true;
        }


        private void CadGastosEnergeticos_Load(object sender, EventArgs e)
        {
            dt_tempo.Value = DateTime.Today.Date;

            FormMain GetNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
            NutricionistaID = Convert.ToInt32(GetNutricionista.IDLabel.Text.Substring(1));
            NutricionistaNome = GetNutricionista.NomeLabel.Text;

            using (var db = new DatabaseConnection())
            {
                string result = db.CheckNutricionistaAtivo(NutricionistaID);

                if (result == "True") //Função para verificar se o nutricionista está ativo
                {

                    db.OpenConnection();
                    db.GetPacientes(NutricionistaID, cb_Pacientes);
                    db.GetGNivelAtividadeCombobox(cb_NivelAtv, l_descNivelAtividade);
                    db.GetAtividadeFisicaGastosCombobox(cb_AtvFisica, l_met);
                    db.GetProtocolosCombobox(cb_Protocolo);

                    //Rotinas para Aba "Atividade Fisica"
                    cb_AtvFisica.SelectedIndex = 4;
                    dt_tempo.Format = DateTimePickerFormat.Time;
                    dt_tempo.ShowUpDown = true; // Exibe controles up-down ao invés de calendário
                }
                else
                {
                    MessageBox.Show("Seu cadastro não está ativo. Contate o Administrador do Sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BeginInvoke(new MethodInvoker(Close));
                }
            }


        }

        private void cb_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paciente pacienteSelecionado = (Paciente)cb_Pacientes.SelectedItem;

            if (pacienteSelecionado != null)
            {
                int idPaciente = pacienteSelecionado.Id;
                PacienteId = idPaciente;

                txt_DescricaoNome.Clear();
                txt_DescricaoNome.Text = "Gasto Energetico para " + cb_Pacientes.Text;
                bt_adicionarGasto.Enabled = true;
            }

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetGastoEnergeticoCombobox(PacienteId, cb_Gastoenergico, txt_Altura, txt_Peso, l_idade, l_sexo);
            }
        }

        public void PesquisarPaciente(string userNome)
        {
            foreach (var item in cb_Pacientes.Items)
            {
                if (item is Paciente paciente)
                {
                    if (string.Equals(paciente.Nome, userNome, StringComparison.OrdinalIgnoreCase))
                    {
                        cb_Pacientes.SelectedItem = item; // Seleciona o nome do Paciente correspondente
                        break;
                    }
                }
            }
        }

        private void cb_Gastoenergico_SelectedIndexChanged(object sender, EventArgs e)
        {
            GastoEnergetico possuiGasto = (GastoEnergetico)cb_Gastoenergico.SelectedItem;

            if (possuiGasto != null)
            {
                int idGasto = possuiGasto.Id;
                GastoEnergeticoID = idGasto;
                tipoSexo = possuiGasto.Sexo;
                idadePaciente = possuiGasto.Idade;

                bt_EditarGasto.Enabled = true;

            }
        }

        private void cb_NivelAtv_SelectedIndexChanged(object sender, EventArgs e)
        {
            NivelAtividade nivelSelecionado = (NivelAtividade)cb_NivelAtv.SelectedItem;

            if (nivelSelecionado != null)
            {
                int idNivel = nivelSelecionado.Id;
                NivelId = idNivel;
                calcNivelID = nivelSelecionado.Calc;

                l_descNivelAtividade.Text = $"{nivelSelecionado.NivelAtv} ({nivelSelecionado.Calc.ToString("F3")}): \n {nivelSelecionado.Complemento}";

            }
        }

        private void cb_AtvFisica_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtividadeFisica AtividadeFisicaSelecionada = (AtividadeFisica)cb_AtvFisica.SelectedItem;

            if (AtividadeFisicaSelecionada != null)
            {
                int idAtividade = AtividadeFisicaSelecionada.Id;
                AtividadeFisicaID = idAtividade;
                MET = AtividadeFisicaSelecionada.Met;

                l_met.Text = $"{AtividadeFisicaSelecionada.Met.ToString("F2")}. {AtividadeFisicaSelecionada.Descricao}";

            }
        }

        private void cb_Protocolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Protocolos ProtocoloSelecionado = (Protocolos)cb_Protocolo.SelectedItem;

            if (ProtocoloSelecionado != null)
            {
                int idProtocolo = ProtocoloSelecionado.Id;
                ProtocoloID = idProtocolo;
            }
            if (ProtocoloSelecionado.Descricao == "KATCH-MCARDLE 1996")
            {
                txt_massa_magra.Clear();
                l_MassaMagra.Visible = true;
                l_obsMassaMagra.Visible = true;
                txt_massa_magra.Visible = true;
            }
            else
            {
                l_MassaMagra.Visible = false;
                l_obsMassaMagra.Visible = false;
                txt_massa_magra.Visible = false;
            }

        }

        private void cb_QntAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_frequencia.Text != "")
            {
                int CalcFreq = Convert.ToInt32(txt_frequencia.Text);

                if (cb_QntAtividade.SelectedIndex == 0)
                {
                    l_frequencia.Text = Convert.ToString(CalcFreq*7); //Dia
                }
                else if (cb_QntAtividade.SelectedIndex == 1)
                {
                    l_frequencia.Text = Convert.ToString(CalcFreq); //Semana
                }

            }
        }

        private void bt_adicionarRec_Click(object sender, EventArgs e)
        {
            if (cb_Pacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Paciente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Pacientes.Focus();
                return;
            }

            if (txt_DescricaoNome.Text == null)
            {
                MessageBox.Show("Insira uma Descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DescricaoNome.Focus();
                return;
            }

            if (MessageBox.Show("Deseja Iniciar Gasto Energetico deste Paciente ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {

                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                     "INSERT INTO public.gastos_caloricos " +
                        "(descricao, paciente_id,data, ativo) " +
                        "VALUES (@descricao, @paciente_id,@data, @ativo)",
                        db.GetConnection()))
                    {

                        comm.Parameters.AddWithValue("@paciente_id", PacienteId);
                        comm.Parameters.AddWithValue("@descricao", txt_DescricaoNome.Text);
                        comm.Parameters.AddWithValue("@data", DateTime.Now);
                        comm.Parameters.AddWithValue("@ativo", 'S');
                        try
                        {
                            var GasID = comm.ExecuteScalar();

                            if (GasID != null)
                            {
                                GastoEnergeticoID = Convert.ToInt32(GasID); // Converte o valor para int se não for null
                            }

                            using (var selectComm = new NpgsqlCommand(
                               "SELECT pa.peso, pa.altura, pa.idade, pa.sexo " +
                               "FROM paciente pa WHERE pa.id_paciente = @paciente_id",
                                db.GetConnection()))
                            {
                                selectComm.Parameters.AddWithValue("@paciente_id", PacienteId);
                                using (var reader = selectComm.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        // Atualize suas labels e textboxes aqui
                                        txt_Peso.Text = reader["peso"].ToString();
                                        txt_Altura.Text = reader["altura"].ToString();
                                        l_idade.Text = reader["idade"].ToString() + " anos";
                                        tipoSexo = reader["sexo"].ToString();
                                        l_sexo.Text = tipoSexo;
                                        idadePaciente = Convert.ToInt32(reader["idade"]);

                                    }
                                }
                            }

                            gr_ExibeDados.Visible = true;
                            cb_Pacientes.Enabled = false;
                            cb_Gastoenergico.Enabled = false;
                            txt_DescricaoNome.Enabled = false;
                            bt_adicionarGasto.Enabled = false;
                            bt_EditarGasto.Enabled = false;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show($"Erro: {error}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }


            }
            else
            {
                bt_adicionarGasto.Focus();
            }
        }

        private void bt_EditarRec_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT ga.id, ga.paciente_id, ga.descricao, ga.data, ga.protocolo_id, ga.vet, ga.geb, ga.ativo, ga.nivel_atividade_id, ga.venta_peso_desejado, ga.venta_tempo, pa.peso,pa.altura,pa.idade,pa.sexo FROM public.gastos_caloricos ga JOIN paciente pa on pa.id_paciente = ga.paciente_id where ga.id = @filtro and ga.paciente_id = @paciente_id";
                var filtro = GastoEnergeticoID;
                using (var db = new DatabaseConnection())
                {
                    using (NpgsqlConnection connection = db.GetConnection())
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            // Passa o filtro como inteiro
                            command.Parameters.AddWithValue("@Filtro", filtro);
                            command.Parameters.AddWithValue("@paciente_id", PacienteId);

                            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            // Preencher os TextBoxes e ComboBox
                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow row = dataTable.Rows[0];

                                txt_Peso.Text = row["peso"] != DBNull.Value ? row["peso"].ToString() : string.Empty;
                                txt_Altura.Text = row["altura"] != DBNull.Value ? row["altura"].ToString() : string.Empty;
                                txt_PesoDesejado.Text = row["venta_peso_desejado"] != DBNull.Value ? row["venta_peso_desejado"].ToString() : string.Empty;
                                txt_DiasVenta.Text = row["venta_tempo"] != DBNull.Value ? row["venta_tempo"].ToString() : string.Empty;
                                l_sexo.Text = Convert.ToString(row["sexo"]);
                                l_idade.Text = Convert.ToString(row["idade"]) + " anos";

                                int nivelAtvID = row["nivel_atividade_id"] != DBNull.Value ? Convert.ToInt32(row["nivel_atividade_id"]) : 0;
                                if (nivelAtvID != 0)
                                {
                                    PreencherComboBoxNivelAtv(nivelAtvID);
                                }

                                int protocoloId = row["protocolo_id"] != DBNull.Value ? Convert.ToInt32(row["protocolo_id"]) : 0;
                                if (nivelAtvID != 0)
                                {
                                    PreencherComboBoxProtocolo(protocoloId);
                                }

                                VET.Text = row["vet"] != DBNull.Value ? row["vet"].ToString() : string.Empty;
                                gr_VET.Visible = row["vet"] != DBNull.Value;
                                GEB.Text = row["geb"] != DBNull.Value ? row["geb"].ToString() + " Kcal" : string.Empty;
                                gr_GEB.Visible = row["geb"] != DBNull.Value;


                                gr_ExibeDados.Visible = true;
                                cb_Pacientes.Enabled = false;
                                cb_Gastoenergico.Enabled = false;
                                txt_DescricaoNome.Enabled = false;
                                bt_adicionarGasto.Enabled = false;
                                bt_SalvarPDF.Enabled = true;


                                db.CarregarDados(queryAtvFisica, filtro, dataGridView1);

                                if (dataGridView1.Rows.Count > 0)
                                {
                                    bt_ExcluirAtv.Enabled = true;
                                    bt_adicionarItemAtividade.Enabled =true;
                                }
                                else
                                {
                                    bt_ExcluirAtv.Enabled = false;
                                    bt_adicionarItemAtividade.Enabled =false;
                                }
                                RecalculaVET();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum dado encontrado para o filtro especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherComboBoxNivelAtv(int idNivelAtividade)
        {
            foreach (NivelAtividade nivel in cb_NivelAtv.Items)
            {
                // Verifica se o ID do nível de atividade corresponde ao ID salvo
                if (nivel.Id == idNivelAtividade)
                {
                    cb_NivelAtv.SelectedItem = nivel; // Seleciona o item correto
                    break;
                }
            }
        }

        private void PreencherComboBoxProtocolo(int idProtocolo)
        {
            foreach (Protocolos proto in cb_Protocolo.Items)
            {
                // Verifica se o ID do nível de atividade corresponde ao ID salvo
                if (proto.Id == idProtocolo)
                {
                    cb_Protocolo.SelectedItem = proto; // Seleciona o item correto
                    break;
                }
            }
        }

        private void bt_validar_Click(object sender, EventArgs e)
        {

            if (txt_Peso.Text == "")
            {
                MessageBox.Show("Insira seu Peso atual para o Calcular!");
                txt_Peso.Focus();
                return;
            }

            if (txt_Altura.Text == "")
            {
                MessageBox.Show("Insira sua Altura atual para o Calcular!");
                txt_Altura.Focus();
                return;
            }

            double massamagra = 0;
            gr_GEB.Visible = true;
            gr_VET.Visible = true;

            /*  MessageBox.Show(
                  " Peso: " +txt_Peso.Text +
                  " Altura: " + txt_Altura.Text +
                  " Idade: " + Convert.ToString(idadePaciente) +
                  " Sexo: " + tipoSexo +
                  " nivel Atividade:" + Convert.ToString(Math.Round(calcNivelID, 3))); */

            string alturaLimpa = txt_Altura.Text.Replace(".", "").Replace(",", ""); //Remove . ou virgulas pois Altura deve ser em (CM)

            if (txt_massa_magra.Text == "")
            {
                massamagra = 0;
            }
            else
            {
                massamagra = Convert.ToDouble(txt_massa_magra.Text);
            }

            Funcoes.CalcularGastosEnergicos(
                Convert.ToDouble(txt_Peso.Text),
                Convert.ToDouble(alturaLimpa),
                idadePaciente,
                tipoSexo,
                cb_Protocolo.SelectedItem.ToString(),
                (double)Math.Round(calcNivelID, 3),
                massamagra,
                GEB,
                VET);

            bt_adicionarItemAtividade.Enabled = true;

            bt_Salvar.Enabled = true;
            bt_SalvarPDF.Enabled = true;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar os dados do Paciente ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                         "UPDATE public.paciente " +
                         "SET peso = @peso, altura = @altura " +
                         "WHERE id_paciente = @id_paciente",
                         db.GetConnection()))
                    {
                        // Adicionando os parâmetros com seus respectivos valores
                        comm.Parameters.AddWithValue("@id_paciente", PacienteId);
                        comm.Parameters.AddWithValue("@peso", Convert.ToDouble(txt_Peso.Text));
                        comm.Parameters.AddWithValue("@altura", Convert.ToDouble(txt_Altura.Text));

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show($"Erro: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }
            }


            if (gr_VENTA.Visible == true)
            {

                if (MessageBox.Show("Deseja salvar os dados de Venta ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (var db = new DatabaseConnection())
                    {
                        db.OpenConnection();
                        using (var comm = new NpgsqlCommand(
                             "UPDATE public.gastos_caloricos " +
                             "SET venta_peso_desejado = @venta_peso_desejado, venta_tempo = @venta_tempo " +
                             "WHERE id = @id",
                             db.GetConnection()))
                        {
                            // Adicionando os parâmetros com seus respectivos valores
                            comm.Parameters.AddWithValue("@id", GastoEnergeticoID);
                            comm.Parameters.AddWithValue("@venta_peso_desejado", Convert.ToDouble(txt_PesoDesejado.Text));
                            comm.Parameters.AddWithValue("@venta_tempo", Convert.ToDouble(txt_DiasVenta.Text));

                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show($"Erro: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }
                }

            }

            if (gr_GEB.Visible == true)
            {
                if (MessageBox.Show("Deseja salvar os Resultados do Gasto Energetico ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (var db = new DatabaseConnection())
                    {
                        db.OpenConnection();
                        using (var comm = new NpgsqlCommand(
                             "UPDATE public.gastos_caloricos " +
                             "SET protocolo_id = @protocolo_id, vet = @vet, geb = @geb, nivel_atividade_id = @nivel_atividade_id " +
                             "WHERE id = @id",
                             db.GetConnection()))
                        {
                            // Adicionando os parâmetros com seus respectivos valores
                            comm.Parameters.AddWithValue("@id", GastoEnergeticoID);
                            comm.Parameters.AddWithValue("@protocolo_id", ProtocoloID);

                            string ApenasNumeros = Regex.Replace(VET.Text, "[^0-9,.]", ""); // Remove letras e outros caracteres
                            double VETAtual = double.Parse(ApenasNumeros, CultureInfo.InvariantCulture);

                            comm.Parameters.AddWithValue("@vet", VETAtual);

                            string ApenasNumeros2 = Regex.Replace(GEB.Text, "[^0-9,.]", ""); // Remove letras e outros caracteres
                            double GEBAtual = double.Parse(ApenasNumeros2, CultureInfo.InvariantCulture);

                            comm.Parameters.AddWithValue("@get", GEBAtual);
                            comm.Parameters.AddWithValue("@nivel_atividade_id", NivelId);

                            try
                            {
                                comm.ExecuteNonQuery();
                                MessageBox.Show("Sucesso!");
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show($"Erro: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }
                }
            }

        }


        private void txt_DiasVenta_TextChanged(object sender, EventArgs e)
        {


            if (txt_Peso.Text != null && txt_PesoDesejado.Text != null && txt_DiasVenta.Text != null)
            {
                if (txt_Peso.Text != "" && txt_PesoDesejado.Text != "" && txt_DiasVenta.Text != "")
                {
                    gr_VENTA.Visible = true;
                    Funcoes.CalcularVentaDiario(
                        Convert.ToDouble(txt_Peso.Text),
                        Convert.ToDouble(txt_PesoDesejado.Text),
                        Convert.ToInt32(txt_DiasVenta.Text),
                        VENTA
                        );
                }
                else
                {
                    gr_VENTA.Visible = false;
                }
            }
            else
            {
                gr_VENTA.Visible = false;
            }

        }

        private void bt_adicionarItemAtividade_Click(object sender, EventArgs e)
        {
            bt_validar_Click(sender, e);
            Funcoes.SomarGastoEnergetico(Convert.ToDouble(MET),
                dt_tempo,
                Convert.ToInt32(l_frequencia.Text),
                Convert.ToDouble(txt_Peso.Text),
                VET,
                l_Calorias
                );

            l_Calorias.Visible = true;

            if (MessageBox.Show("Deseja adicionar este item às atividades físicas praticadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                         "INSERT INTO public.gasto_atividade " +
                         "(gastos_id,atividade_id,frequencia,duracao,calorias) " +
                         "VALUES (@gastos_id,@atividade_id,@frequencia,@duracao,@calorias)",
                         db.GetConnection()))
                    {

                        // Adicionando os parâmetros com seus respectivos valores
                        comm.Parameters.AddWithValue("@gastos_id", GastoEnergeticoID);
                        comm.Parameters.AddWithValue("@atividade_id", AtividadeFisicaID);
                        comm.Parameters.AddWithValue("@frequencia", Convert.ToInt32(l_frequencia.Text));
                        comm.Parameters.AddWithValue("@duracao", dt_tempo.Value.TimeOfDay);

                        string cleanedInput = Regex.Replace(l_Calorias.Text, "[^0-9,.]", ""); // Remove letras e outros caracteres
                        double Calorias = double.Parse(cleanedInput, CultureInfo.InvariantCulture);

                        comm.Parameters.AddWithValue("@calorias", Calorias);

                        try
                        {
                            comm.ExecuteNonQuery();
                            AtualizarDataGridView();
                            RecalculaVET();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show($"Erro: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

        private void AtualizarDataGridView()
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Recarregar os dados no DataGridView
                    db.CarregarDados(queryAtvFisica, GastoEnergeticoID, dataGridView1);
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Erro ao atualizar a lista: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void RecalculaVET()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                l_Calorias.Text = Convert.ToString(dataGridView1.Rows[i].Cells["calorias"].Value);
                TimeSpan duracao = (TimeSpan)dataGridView1.Rows[i].Cells["duracao"].Value;
                DateTime dataBase = DateTime.Today;
                dt_tempo.Value = dataBase.Add(duracao);


                Funcoes.SomarGastoEnergetico(
                Convert.ToDouble(dataGridView1.Rows[i].Cells["MET"].Value),
                    dt_tempo,
                    Convert.ToInt32(dataGridView1.Rows[i].Cells["frequencia"].Value),
                    Convert.ToDouble(txt_Peso.Text),
                    VET,
                    l_Calorias
                    );

                l_Calorias.Text = "";
            }
        }

        private void txt_PesoDesejado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Aceita apenas Numeros
            {
                e.Handled = true;
            }
        }

        private void txt_DiasVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Aceita apenas Numeros
            {
                e.Handled = true;
            }
        }

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Aceita apenas Numeros
            {
                e.Handled = true;
            }
        }

        private void txt_Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)  && e.KeyChar != ',') //Aceita apenas Numeros e virgula
            {
                e.Handled = true;
            }
        }

        private void txt_frequencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Aceita apenas Numeros
            {
                e.Handled = true;
            }
        }

        private void txt_massa_magra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)  && e.KeyChar != ',') //Aceita apenas Numeros e virgula
            {
                e.Handled = true;
            }
        }

        private void bt_ExcluirAtv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir essa Atividade Fisíca ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obter o índice da linha selecionada
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int id = (int)dataGridView1.Rows[rowIndex].Cells["id_gastoAtv"].Value;

                    using (var db = new DatabaseConnection())
                    {
                        db.ExcluirItemGastoEnergetico(id);
                        MessageBox.Show("Item Excluido com Sucesso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    AtualizarDataGridView();
                    bt_EditarRec_Click(sender, e);
                }
            }
            else
            {
                dataGridView1.Focus();
            }
        }

        private void bt_SalvarPDF_Click(object sender, EventArgs e)
        {
            string NomePaciente = cb_Pacientes.SelectedItem.ToString();

            // Criação de um novo documento
            Document document = new Document();
            document.Info.Title = "Avaliação Antropometrica de: " +  NomePaciente;
            document.Info.Subject = "Avaliação Antropometrica";
            document.Info.Author = NutricionistaNome;

            // Adiciona uma seção ao documento
            Section section = document.AddSection();

            // Adiciona informações ao documento
            Paragraph Titulo = section.AddParagraph("Avaliação Antropométrica. ");
            Titulo.Format.Font.Size = 16;
            Titulo.Format.Font.Bold = true; // Define o texto em negrito
            Titulo.Format.Alignment = ParagraphAlignment.Center; // Centraliza o texto
            Paragraph Subtitulo = section.AddParagraph("Realizada por: " + NutricionistaNome);
            Subtitulo.Format.Font.Size = 8;
            Subtitulo.Format.Font.Color =  new MigraDocCore.DocumentObjectModel.Color(128, 128, 128);
            Subtitulo.Format.Font.Italic = true; // Define o texto em negrito
            Subtitulo.Format.Alignment = ParagraphAlignment.Center; // Centraliza o texto

            section.AddParagraph("");
            section.AddParagraph("");

            Paragraph Paciente = section.AddParagraph(NomePaciente);
            Paciente.Format.Font.Bold = true;
            Paciente.Format.Font.Size = 12;
            section.AddParagraph("");

            section.AddParagraph("TMB: " + GEB.Text).Format.Font.Bold = true;
            section.AddParagraph("VET: " + VET.Text).Format.Font.Bold = true;
            if (gr_VENTA.Visible)
            {
                section.AddParagraph("VENTA: " + VENTA.Text).Format.Font.Bold = true;
            }

            section.AddParagraph("");
            section.AddParagraph("");

            // Adiciona um espaço para a sugestão do nutricionista
            section.AddParagraph("\nObservações:").Format.Font.Bold = true;
            section.AddParagraph("\n_____________________________________________");
            section.AddParagraph("_____________________________________________");
            section.AddParagraph("_____________________________________________");


            // Criação do renderizador PDF
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true)
            {
                Document = document
            };

            // Gera o PDF
            renderer.RenderDocument();
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Avaliação Energetica " + NomePaciente + ".pdf";
            renderer.PdfDocument.Save(filename);

            // Exibe uma mensagem de sucesso
            MessageBox.Show($"PDF gerado em: {filename}");
        }
    }
}

