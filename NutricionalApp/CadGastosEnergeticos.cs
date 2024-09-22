using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutricionalApp.DatabaseConnection;

namespace NutricionalApp
{
    public partial class CadGastosEnergeticos : Form
    {
        int GastoEnergeticoID = 0;
        int NutricionistaID = 0;
        int PacienteId = 0;
        int NivelId = 0;
        decimal calcNivelID = 0;
        int AtividadeFisicaID = 0;
        decimal METID = 0;
        int ProtocoloID = 0;
        string tipoSexo;
        int idadePaciente = 0;

        public CadGastosEnergeticos()
        {
            InitializeComponent();
        }

        private void dt_tempo_MouseDown(object sender, MouseEventArgs e)
        {
            e = null;
        }

        private void dt_tempo_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void CadGastosEnergeticos_Load(object sender, EventArgs e)
        {
            dt_tempo.Value = DateTime.Today.Date;

            FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
            NutricionistaID = Convert.ToInt32(GetIDNutricionista.IDLabel.Text.Substring(1));

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetPacientes(NutricionistaID, cb_Pacientes);
                db.GetGNivelAtividadeCombobox(cb_NivelAtv,l_descNivelAtividade);
                db.GetAtividadeFisicaGastosCombobox(cb_AtvFisica, l_met);
                db.GetProtocolosCombobox(cb_Protocolo);
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
                db.GetGastoEnergeticoCombobox(PacienteId, cb_Gastoenergico,txt_Altura,txt_Peso,l_idade,l_sexo);
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

                if (possuiGasto.Sexo == "M")
                {
                    l_sexo.Text = "Masculino";
                } else if (possuiGasto.Sexo == "F")
                {
                    l_sexo.Text = "Feminino";
                }
                else
                {
                    l_sexo.Text = "Não especificado";
                }

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
                METID = AtividadeFisicaSelecionada.Met;

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
        }

        private void cb_QntAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_frequencia.Text != null)
            {
                int CalcFreq = Convert.ToInt32(txt_frequencia.Text);

                if(cb_QntAtividade.SelectedIndex == 0)
                {
                    l_frequencia.Text = Convert.ToString(CalcFreq); //Dia
                }
                else if (cb_QntAtividade.SelectedIndex == 1)
                {
                    l_frequencia.Text = Convert.ToString(CalcFreq*7); //Semana
                }
                else if (cb_QntAtividade.SelectedIndex == 2)
                {
                    l_frequencia.Text = Convert.ToString(CalcFreq*30); //mes
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
                                        idadePaciente = Convert.ToInt32(reader["idade"]);

                                        if (reader["sexo"].ToString() == "M")
                                        {
                                            l_sexo.Text = "Masculino";
                                        }
                                        else if (reader["sexo"].ToString() == "F")
                                        {
                                            l_sexo.Text = "Feminino";
                                        }
                                        else
                                        {
                                            l_sexo.Text = "Não especificado";
                                        }
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
                                txt_Altura.Text = row["venta_tempo"] != DBNull.Value ? row["venta_tempo"].ToString() : string.Empty;
                                l_sexo.Text = Convert.ToString(row["sexo"]);
                                l_idade.Text = Convert.ToString(row["idade"]) + " anos";

                                int nivelAtvID = row["nivel_atividade_id"] != DBNull.Value ? Convert.ToInt32(row["nivel_atividade_id"]) : 0;
                                if (nivelAtvID != 0)
                                {
                                    PreencherComboBoxNivelAtv(nivelAtvID);
                                }
                                gr_ExibeDados.Visible = true;
                                cb_Pacientes.Enabled = false;
                                cb_Gastoenergico.Enabled = false;
                                txt_DescricaoNome.Enabled = false;
                                bt_adicionarGasto.Enabled = false;
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

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            gr_GEB.Visible = true;
            gr_VET.Visible = true;
            MessageBox.Show(
                " Peso: " +txt_Peso.Text +
                " Altura: " + txt_Altura.Text +
                " Idade: " + Convert.ToString(idadePaciente) +
                " Sexo: " + tipoSexo +
                " nivel Atividade:" + Convert.ToString(Math.Round(calcNivelID, 3)));

            string alturaLimpa = txt_Altura.Text.Replace(".", "").Replace(",", ""); //Remove . ou virgulas pois Altura deve ser em (CM)

            Funcoes.CalcularGastosEnergicos(
                Convert.ToDouble(txt_Peso.Text),
                Convert.ToDouble(alturaLimpa),
                idadePaciente,
                tipoSexo,
                cb_Protocolo.SelectedItem.ToString(),
                (double)Math.Round(calcNivelID, 3),
                GEB,
                VET);
        }
    }
}
