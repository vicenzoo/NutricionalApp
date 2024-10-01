using Npgsql;
using System;
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
    public partial class CadAntropometria : Form
    {
        int PacienteId;
        int NutricionistaID = 0;
        int AntropometriaID = 0;
        int protocolopcID = 0;
        int ProtocoloID = 0;
        public CadAntropometria()
        {
            InitializeComponent();
        }

        private void CadAntropometria_Load(object sender, EventArgs e)
        {
            FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
            NutricionistaID = Convert.ToInt32(GetIDNutricionista.IDLabel.Text.Substring(1));

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetPacientes(NutricionistaID, cb_Pacientes);
                db.GetProtocolosPCCombobox(cb_Protocolo);
            }
        }

        private void cb_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paciente pacienteSelecionado = (Paciente)cb_Pacientes.SelectedItem;

            if (pacienteSelecionado != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idPaciente = pacienteSelecionado.Id;
                PacienteId = idPaciente;
                //MessageBox.Show($"ID do paciente selecionado: {idPaciente}");

                txt_DescricaoNome.Clear();
                txt_DescricaoNome.Text = "Avaliação Física para " + cb_Pacientes.Text;
                bt_adicionarAntrometria.Enabled = true;
            }

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetAntropometriaCombobox(PacienteId, cb_Antropometrias);
            }
        }

        private void cb_Antropometrias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Antropometria antropometria = (Antropometria)cb_Antropometrias.SelectedItem;

            if (antropometria != null)
            {
                int AntroID = antropometria.Id;
                AntropometriaID = AntroID;

                bt_EditarAntrometria.Enabled = true;

            }
        }


        private void bt_adicionarAntrometria_Click(object sender, EventArgs e)
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

            if (MessageBox.Show("Deseja Iniciar o Formulario de Atividade Fisica deste Paciente ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {

                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                     "INSERT INTO public.antropometria " +
                        "(paciente_id, \"Descricao\", \"Data\", ativo) " +
                        "VALUES (@paciente_id, @Descricao,@Data, @ativo)",
                        db.GetConnection()))
                    {

                        comm.Parameters.AddWithValue("@paciente_id", PacienteId);
                        comm.Parameters.AddWithValue("@Descricao", txt_DescricaoNome.Text);
                        comm.Parameters.AddWithValue("@Data", DateTime.Now);
                        comm.Parameters.AddWithValue("@ativo", 'S');
                        try
                        {
                            var AntroID = comm.ExecuteScalar();

                            if (AntroID != null)
                            {
                                AntropometriaID = Convert.ToInt32(AntroID); // Converte o valor para int se não for null
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
                                        //l_idade.Text = reader["idade"].ToString() + " anos";


                                    }
                                }
                            }

                            gr_SobrePaciente.Visible = true;
                            tabFormulario.Visible = true;
                            bt_adicionarAntrometria.Enabled = false;
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
                bt_adicionarAntrometria.Focus();
            }
        }

        private void bt_EditarAntrometria_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT at.id_antro, at.paciente_id,pa.peso,pa.altura, at.\"Descricao\", at.\"Data\", at.braco_direito_relaxado, at.braco_esquerdo_relaxado, at.braco_direito_contraido, at.braco_esquerdo_contraido, at.antebraco_direito, at.antebraco_esquerdo, at.punho_direito, at.punho_esquerdo, at.pescoco, at.ombro, at.peitoral, at.cintura, at.quadril, at.panturilha_direita, at.panturilha_esquerda, at.coxa_direita, at.coxa_esquerda, at.coxa_proximal_direita, at.coxa_proximal_esquerda, at.protocolo_id_pc, at.bicecps, at.abdominal, at.tricips, at.supescapular, at.torax, at.coxa, at.panturilha_medial, at.ativo FROM public.antropometria at JOIN paciente pa on pa.id_paciente = at.paciente_id where at.id_antro = @filtro";
                var filtro = AntropometriaID;
                using (var db = new DatabaseConnection())
                {
                    using (NpgsqlConnection connection = db.GetConnection())
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            // Passa o filtro como inteiro
                            command.Parameters.AddWithValue("@Filtro", filtro);

                            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            // Preencher os TextBoxes e ComboBox
                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow row = dataTable.Rows[0];

                                txt_Peso.Text = row["peso"] != DBNull.Value ? row["peso"].ToString() : string.Empty;
                                txt_Altura.Text = row["altura"] != DBNull.Value ? row["altura"].ToString() : string.Empty;

                                int protocoloIdpc = row["protocolo_id_pc"] != DBNull.Value ? Convert.ToInt32(row["protocolo_id_pc"]) : 0;
                                if (protocolopcID != 0)
                                {
                                    PreencherComboBoxProtocoloPC(protocoloIdpc);
                                }



                                tabFormulario.Visible = true;
                                gr_SobrePaciente.Visible = true;
                                cb_Pacientes.Enabled = false;
                                txt_DescricaoNome.Enabled = false;
                                bt_adicionarAntrometria.Enabled = false;
                                cb_Antropometrias.Enabled = false;
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


        private void PreencherComboBoxProtocoloPC(int idProtocolopc)
        {
            foreach (ProtocolosPC protopc in cb_Protocolo.Items)
            {
                // Verifica se o ID do nível de atividade corresponde ao ID salvo
                if (protopc.Id == idProtocolopc)
                {
                    cb_Protocolo.SelectedItem = protopc; // Seleciona o item correto
                    break;
                }
            }
        }

        private void cb_Protocolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProtocolosPC ProtocoloSelecionado = (ProtocolosPC)cb_Protocolo.SelectedItem;

            if (ProtocoloSelecionado != null)
            {
                int idProtocolo = ProtocoloSelecionado.Id;
                ProtocoloID = idProtocolo;
            }
            if (ProtocoloSelecionado.Descricao == "3 pregas: Jackson & Pollock")
            {
                txt_PC_Abdominal.Enabled = true;
                txt_PC_torax.Enabled = true;
                txt_PC_Coxa.Enabled = true;
            }
            else
            {
                txt_PC_Abdominal.Enabled = false;
                txt_PC_torax.Enabled = false;
                txt_PC_Coxa.Enabled = false;
            }

            if (ProtocoloSelecionado.Descricao == "4 pregas: Durmin & Wormersley")
            {
                txt_PC_Biceps.Enabled = true;
                txt_PC_triceps.Enabled = true;
                txt_PC_subscapular.Enabled = true;

            }
            else
            {
                txt_PC_Biceps.Enabled = false;
                txt_PC_triceps.Enabled = false;
                txt_PC_subscapular.Enabled = false;
            }
        }

        private void tabFormulario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabFormulario.SelectedIndex == 2)
            {
                var resultado = Funcoes.CalcularIMC(Convert.ToDouble(txt_Peso.Text), Convert.ToDouble(txt_Altura.Text));

                // Exibe o valor do IMC
                IMC.Text = $"{resultado.imc.ToString("F2")}";

                // Exibe a classificação do IMC
                CLASSIFICACAOIMC.Text = resultado.classificacao;
            }
        }
    }


}
