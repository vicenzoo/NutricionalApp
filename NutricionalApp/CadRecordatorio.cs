using ActiveQueryBuilder.Core;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutricionalApp.DatabaseConnection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NutricionalApp
{
    public partial class CadRecordatorio : Form
    {
        int PacienteId;
        int NutricionistaID = 0;
        int TacoID = 0;
        int RecordatorioID = 0;

        public CadRecordatorio()
        {
            InitializeComponent();
            dt_DataHoraRec.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dt_DataHoraRec.Value = DateTime.Now;
            dt_DataHoraRec.MaxDate = DateTime.Now;
        }

        private void CadRecordatorio_Load(object sender, EventArgs e)
        {
            FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
            NutricionistaID = Convert.ToInt32(GetIDNutricionista.IDLabel.Text.Substring(1));

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetPacientes(NutricionistaID, cb_Pacientes);
            }



        }

        private void cb_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenha o paciente selecionado
            Paciente pacienteSelecionado = (Paciente)cb_Pacientes.SelectedItem;

            if (pacienteSelecionado != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idPaciente = pacienteSelecionado.Id;
                PacienteId = idPaciente;
                //MessageBox.Show($"ID do paciente selecionado: {idPaciente}");

                txt_DescricaoNome.Clear();
                txt_DescricaoNome.Text = "Recordatório para " + cb_Pacientes.Text;
                bt_adicionarRec.Enabled = true;
            }

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetRecordatorioCombobox(PacienteId, cb_Recordatorios);
            }

        }

        private void bt_adicionarRec_Click(object sender, EventArgs e)
        {
            if (cb_Pacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Paciente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja Iniciar o Recordatorio deste Paciente ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {

                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                     "INSERT INTO public.recordatorio_24h " +
                        "(data_inclusao,descricao_nome, paciente_id, nutricionista_id, ativo) " +
                        "VALUES (@data_inclusao,@descricao_nome, @paciente_id, @nutricionista_id, @ativo)",
                        db.GetConnection()))
                    {

                        comm.Parameters.AddWithValue("@data_inclusao", DateTime.Now); // Data de inclusão
                        comm.Parameters.AddWithValue("@descricao_nome", txt_DescricaoNome.Text);
                        comm.Parameters.AddWithValue("@paciente_id", PacienteId);
                        comm.Parameters.AddWithValue("@nutricionista_id", NutricionistaID);
                        comm.Parameters.AddWithValue("@ativo", 'S');
                        gr_selecao.Visible = true;
                        gr_itens.Visible = true;
                        bt_adicionarRec.Enabled = false;
                        try
                        {
                            var recId = comm.ExecuteScalar();

                            if (recId != null)
                            {
                                RecordatorioID = Convert.ToInt32(recId); // Converte o valor para int se não for null
                                //MessageBox.Show($"Recordatório adicionado com ID: {RecordatorioID}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show($"Erro: {error}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    try //Preenche combobox com os alimentos para inclusão
                    {
                        db.GetTacoCombo(cb_Taco);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro: {error}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                cb_Pacientes_SelectedIndexChanged(sender,e);

            }
            else
            {
                bt_adicionarRec.Focus();
            }
        }

        private void txt_QuantidadeItens_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Aceita apenas Numeros
            {
                e.Handled = true;
            }

        }

        private void cb_Taco_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenha o paciente selecionado
            TacoCombo TacoSelecionado = (TacoCombo)cb_Taco.SelectedItem;

            if (TacoSelecionado != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idTaco = TacoSelecionado.Id;
                TacoID = idTaco;
                //MessageBox.Show($"ID da TACO selecionada: {idTaco}");
            }
        }

        private void cb_Recordatorios_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Obtenha o paciente selecionado
            Recordatorio possuiRecordatorio = (Recordatorio)cb_Recordatorios.SelectedItem;

            if (possuiRecordatorio != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idRecordatorio = possuiRecordatorio.Id;
                RecordatorioID = idRecordatorio;

                bt_EditarRec.Enabled = true;

            }
        }

        private void bt_EditarRec_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Preenche o ComboBox Taco com os dados vindos do banco
                    db.GetTacoCombo(cb_Taco);
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Erro: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT descricaoperiodo,data_rec,hora,quantidade,medida,descricao_alimento FROM vw_itensrecordatorio_detalhado WHERE recordatorio_id = @Filtro";

                db.CarregarDados(query, RecordatorioID, dataGridView1);
            }

            bt_adicionarRec.Enabled = false;
            cb_Pacientes.Enabled = false;
            txt_DescricaoNome.Text = "";
            gr_selecao.Visible = true;
            gr_itens.Visible = true;

        }

        private void bt_adicionarItemRec_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja adicionar esse item ao Recordatório?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                         "INSERT INTO public.itens_recordatorio " +
                         "(recordatorio_id, data_rec, hora, taco_id, descricao, quantidade) " +
                         "VALUES (@recordatorio_id, @data_rec, @hora, @taco_id, @descricao, @quantidade)",
                         db.GetConnection()))
                    {
                        // Adicionando os parâmetros com seus respectivos valores
                        comm.Parameters.AddWithValue("@recordatorio_id", RecordatorioID);
                        comm.Parameters.AddWithValue("@data_rec", dt_DataHoraRec.Value.Date); // Data atual
                        comm.Parameters.AddWithValue("@hora", dt_DataHoraRec.Value.TimeOfDay); // Hora atual
                        comm.Parameters.AddWithValue("@taco_id", TacoID); // Substitua por sua variável ou campo correspondente
                        comm.Parameters.AddWithValue("@descricao", cb_NomeDescricao.Text); // Substitua por sua variável ou campo correspondente
                        comm.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txt_QuantidadeItens.Text)); // Substitua por sua variável ou campo correspondente

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

                AtualizarDataGridView();
            }
            else
            {
                cb_Taco.Focus();
            }

        }

        private void AtualizarDataGridView()
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Recarregar os dados no DataGridView
                    string query = "SELECT descricaoperiodo, data_rec, hora, quantidade, descricao_alimento FROM vw_itensrecordatorio_detalhado WHERE recordatorio_id = @Filtro";
                    db.CarregarDados(query, RecordatorioID, dataGridView1);
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Erro ao atualizar a lista: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabIndex == 2)
            {
                AtualizarDataGridView2();
            }
        }

        public void AtualizarDataGridView2()
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Recarregar os dados no DataGridView2
                    string query = "SELECT ir.id_itensrec, ir.descricao, ir.quantidade,tt.carboidrato,tt.lipideos,tt.proteina,tt.energia_kcal,tt.energia_kj FROM public.itens_recordatorio ir JOIN tabela_taco4 tt on tt.id = ir.taco_id WHERE recordatorio_id = @Filtro";
                    db.CarregarDados(query, RecordatorioID, dataGridView2);
                    dataGridView2.Columns["id_itensrec"].Width  = 50;
                    dataGridView2.Columns["id_itensrec"].HeaderText = "ID";
                    dataGridView2.Columns["descricao"].Width  = 150;
                    dataGridView2.Columns["descricao"].HeaderText = "Descrição";
                    dataGridView2.Columns["quantidade"].Width  = 50;
                    dataGridView2.Columns["quantidade"].HeaderText = "Qnt.";
                    dataGridView2.Columns["carboidrato"].HeaderText = "Carboidrato";
                    dataGridView2.Columns["carboidrato"].Width  = 75;
                    dataGridView2.Columns["lipideos"].HeaderText = "Lipideos";
                    dataGridView2.Columns["lipideos"].Width  = 75;
                    dataGridView2.Columns["proteina"].HeaderText = "Proteina";
                    dataGridView2.Columns["proteina"].Width  = 75;
                    dataGridView2.Columns["energia_kcal"].HeaderText = "Total Kcal.";
                    dataGridView2.Columns["energia_kcal"].Width  = 75;

                    if (dataGridView2.Columns.Contains("energia_kj"))
                    {
                        dataGridView2.Columns.Remove("energia_kj");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Erro ao atualizar a lista: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_ExcluirIntem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse item ao Recordatório?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Obter o índice da linha selecionada
                    int rowIndex = dataGridView2.SelectedRows[0].Index;
                    int id = (int)dataGridView2.Rows[rowIndex].Cells["id_itensrec"].Value;

                    using (var db = new DatabaseConnection())
                    {
                        db.ExcluirItemRecordatorio(id);
                        MessageBox.Show("Item Excluido com Sucesso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    dataGridView2.Rows.RemoveAt(rowIndex);
                    AtualizarDataGridView();
                }
            }
            else
            {
                dataGridView2.Focus();
            }
        }
    }
}