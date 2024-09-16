﻿using ActiveQueryBuilder.Core;
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
        int MedidasID = 0;
        float MedidasGramas = 0;
        float TACOcarboidrato = 0; //Carboidratos
        float TACOEnergiaKcal = 0, TACOProteinas = 0; //Calorias
        float TACOLipidios = 0; //Gorduras
        float TACOfibras = 0; // Fibras Totais
        float TACOvitamina_a = 0, TACOvitamina_c = 0; //Vitaminas
        float TACOCalcio = 0, TACOferro =0, TACOmagensio = 0; //Minerais



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

                int grupoId = TacoSelecionado.Grupo_id;
                MedidasID = grupoId;

                //Para Calculo do Recordatorio:

                /* Carboidratos Totais */
                float carbo = TacoSelecionado.Carboidrato;
                TACOcarboidrato = carbo;

                /* Calorias Totais */
                float energiaKcal = TacoSelecionado.Energia_kcal;
                TACOEnergiaKcal = energiaKcal;

                float proteinas = TacoSelecionado.Proteinas;
                TACOProteinas = proteinas;

                /* Gorduras Totais */
                float lipidios = TacoSelecionado.Lipidios;
                TACOLipidios = lipidios;

                /* Fibras Totais */
                float fibras = TacoSelecionado.FibraAlimentar;
                TACOfibras = fibras;

                /* Vitaminas Totais */
                float vitamina_a = TacoSelecionado.Re;
                TACOvitamina_a = vitamina_a;

                float vitamina_c = TacoSelecionado.Vitamina_C;
                TACOvitamina_c = vitamina_c;

                /* Minerais Totais */
                float calcio = TacoSelecionado.Calcio;
                TACOCalcio = calcio;

                float ferro = TacoSelecionado.Ferro;
                TACOferro = ferro;

                float mangnesio = TacoSelecionado.Magnesio;
                TACOmagensio = mangnesio;

                using (var db = new DatabaseConnection())
                {
                    try
                    {
                        db.GetMedidas(MedidasID,cb_MedidasCaseiras,l_gramas);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro: {error}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

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

                string query = "SELECT descricaoperiodo,data_rec,hora,quantidade,descricao_alimento FROM vw_itensrecordatorio_detalhado WHERE recordatorio_id = @Filtro";

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
                         "(recordatorio_id, data_rec, hora, taco_id, descricao, quantidade,gramas," 
                         +"calorias_totais,carboidratos_totais,proteinas_totais,gorduras_totais,"
                         +"fibras_totais,vitamina_a,vitamina_c,calcio_total,ferro_total,magnesio_total"+") " +
                         "VALUES (@recordatorio_id, @data_rec, @hora, @taco_id, @descricao, @quantidade,@gramas," 
                         +"@calorias_totais,@carboidratos_totais,@proteinas_totais,@gorduras_totais,"
                         +"@fibras_totais,@vitamina_a,@vitamina_c,@calcio_total,@ferro_total,@magnesio_total)",
                         db.GetConnection()))
                    {

                        float totalgramas = Convert.ToInt64(txt_QuantidadeItens.Text)*MedidasGramas;
                        float totalcalorias = (TACOEnergiaKcal/100)*MedidasGramas;
                        float totalcarboidratos = (TACOcarboidrato/100)*MedidasGramas;
                        float totalproteinas = (TACOProteinas/100)*MedidasGramas;
                        float toalGorduras = (TACOLipidios/100)*MedidasGramas;
                        float totalFibras = (TACOfibras/100)*MedidasGramas;
                        float totalvitamina_a = (TACOvitamina_a/100)*MedidasGramas;
                        float totalvitamina_c = (TACOvitamina_c/100)*MedidasGramas;
                        float totalCalcio = (TACOCalcio/100)*MedidasGramas;
                        float totalferro = (TACOferro/100)*MedidasGramas;
                        float totalmagnesio = (TACOmagensio/100)*MedidasGramas;

                        // Adicionando os parâmetros com seus respectivos valores
                        comm.Parameters.AddWithValue("@recordatorio_id", RecordatorioID);
                        comm.Parameters.AddWithValue("@data_rec", dt_DataHoraRec.Value.Date);
                        comm.Parameters.AddWithValue("@hora", dt_DataHoraRec.Value.TimeOfDay); 
                        comm.Parameters.AddWithValue("@taco_id", TacoID); 
                        comm.Parameters.AddWithValue("@descricao", cb_NomeDescricao.Text); 
                        comm.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txt_QuantidadeItens.Text));
                        comm.Parameters.AddWithValue("@gramas", totalgramas);
                        comm.Parameters.AddWithValue("@calorias_totais", totalcalorias);
                        comm.Parameters.AddWithValue("@carboidratos_totais", totalcarboidratos);
                        comm.Parameters.AddWithValue("@proteinas_totais", totalproteinas);
                        comm.Parameters.AddWithValue("@gorduras_totais", toalGorduras);
                        comm.Parameters.AddWithValue("@fibras_totais", totalFibras);
                        comm.Parameters.AddWithValue("@vitamina_a", totalvitamina_a);
                        comm.Parameters.AddWithValue("@vitamina_c", totalvitamina_c);
                        comm.Parameters.AddWithValue("@calcio_total", totalCalcio);
                        comm.Parameters.AddWithValue("@ferro_total", totalferro);
                        comm.Parameters.AddWithValue("@magnesio_total", totalmagnesio);

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
                    string query = "SELECT ir.id_itensrec, tt.descricao, ir.quantidade,ir.gramas,ir.calorias_totais,ir.carboidratos_totais,ir.proteinas_totais,ir.fibras_totais,ir.gorduras_totais,ir.vitamina_a,ir.vitamina_c,ir.calcio_total,ir.ferro_total,ir.magnesio_total FROM itens_recordatorio ir JOIN tabela_taco4 tt ON ir.taco_id = tt.id  WHERE recordatorio_id = @Filtro";
                    db.CarregarDados(query, RecordatorioID, dataGridView2);
                    dataGridView2.Columns["id_itensrec"].Width  = 50;
                    dataGridView2.Columns["id_itensrec"].HeaderText = "ID";
                    dataGridView2.Columns["descricao"].Width  = 150;
                    dataGridView2.Columns["descricao"].HeaderText = "Descrição";
                    dataGridView2.Columns["quantidade"].Width  = 50;
                    dataGridView2.Columns["quantidade"].HeaderText = "Qnt.";
                    dataGridView2.Columns["carboidratos_totais"].HeaderText = "Carboidrato";
                    dataGridView2.Columns["carboidratos_totais"].Width  = 75;
                    dataGridView2.Columns["gorduras_totais"].HeaderText = "Lipideos";
                    dataGridView2.Columns["gorduras_totais"].Width  = 75;
                    dataGridView2.Columns["proteinas_totais"].HeaderText = "Proteina";
                    dataGridView2.Columns["proteinas_totais"].Width  = 75;
                    dataGridView2.Columns["calorias_totais"].HeaderText = "Total Kcal.";
                    dataGridView2.Columns["calorias_totais"].Width  = 75;
                    dataGridView2.Columns["vitamina_a"].HeaderText = "Vitamina A";
                    dataGridView2.Columns["vitamina_a"].Width  = 75;
                    dataGridView2.Columns["vitamina_c"].HeaderText = "Vitamina C";
                    dataGridView2.Columns["vitamina_c"].Width  = 75;
                    dataGridView2.Columns["calcio_total"].HeaderText = "Calcio";
                    dataGridView2.Columns["calcio_total"].Width  = 75;
                    dataGridView2.Columns["ferro_total"].HeaderText = "Ferro";
                    dataGridView2.Columns["ferro_total"].Width  = 75;
                    dataGridView2.Columns["magnesio_total"].HeaderText = "Magnesio";
                    dataGridView2.Columns["magnesio_total"].Width  = 75;

                    decimal SomaCalorias = 0,SomaCarboidratos = 0,SomaGorduras = 0,SomaProteinas = 0;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells["calorias_totais"].Value != null)
                        {
                            SomaCalorias += Convert.ToDecimal(row.Cells["calorias_totais"].Value);
                            l_Calorias.Text = Convert.ToString(SomaCalorias);
                        }
                        if (row.Cells["carboidratos_totais"].Value != null)
                        {
                            SomaCarboidratos += Convert.ToDecimal(row.Cells["carboidratos_totais"].Value);
                            l_Carboidratos.Text = Convert.ToString(SomaCarboidratos);
                        }
                        if (row.Cells["gorduras_totais"].Value != null)
                        {
                            SomaGorduras += Convert.ToDecimal(row.Cells["gorduras_totais"].Value);
                            l_Lipidios.Text = Convert.ToString(SomaGorduras);
                        }
                        if (row.Cells["proteinas_totais"].Value != null)
                        {
                            SomaProteinas += Convert.ToDecimal(row.Cells["proteinas_totais"].Value);
                            l_Proteinas.Text = Convert.ToString(SomaProteinas);
                        }
                    }

                    chart1.Visible = true;
                    chart1.Series.Clear();

                    // Adiciona uma nova série
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Nutrientes",
                        IsVisibleInLegend = true,
                        IsXValueIndexed = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                        Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
                    };

                    // Adiciona os dados
                    //series.Points.AddXY("Calorias", SomaCalorias);
                    series.Points.AddXY("Carboidratos", SomaCarboidratos);
                    series.Points.AddXY("Gorduras", SomaGorduras);
                    series.Points.AddXY("Proteínas", SomaProteinas);

                    //Borda
                    series.BorderColor = Color.Black;

                    // Adiciona a série ao gráfico
                    chart1.Series.Add(series);




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

        private void cb_MedidasCaseiras_SelectedIndexChanged(object sender, EventArgs e)
        {
            TacoMedidas TacoMedidas = (TacoMedidas)cb_MedidasCaseiras.SelectedItem;

            if (TacoMedidas != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idMedidas = TacoMedidas.Id;
                MedidasID  = idMedidas;
                MedidasGramas = TacoMedidas.Grama;
                //MessageBox.Show($"ID da TACO selecionada: {idTaco}");
            }
        }
    }
}