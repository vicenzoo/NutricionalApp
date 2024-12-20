﻿using MigraDocCore.DocumentObjectModel.Internals;
using MigraDocCore.DocumentObjectModel;
using MigraDocCore.Rendering;
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
using MigraDocCore.DocumentObjectModel.Tables;

namespace NutricionalApp
{
    public partial class CadRecordatorio : Form
    {
        int PacienteId;
        int NutricionistaID = 0;
        int TacoID = 0;
        int RecordatorioID = 0;
        string NutricionistaNome;
        float TACOGramas = 0;
        float TACOcarboidrato = 0; //Carboidratos
        float TACOEnergiaKcal = 0, TACOProteinas = 0; //Calorias
        float TACOLipidios = 0; //Gorduras
        float TACOfibras = 0; // Fibras Totais
        float TACOvitamina_a = 0, TACOvitamina_c = 0; //Vitaminas
        float TACOCalcio = 0, TACOferro =0, TACOmagensio = 0; //Minerais
        bool HabilitaTroca = false;



        public CadRecordatorio()
        {
            InitializeComponent();
            this.TopMost = true;
            dt_DataHoraRec.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dt_DataHoraRec.Value = DateTime.Now;
            dt_DataHoraRec.MaxDate = DateTime.Now;
        }

        private void CadRecordatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain HabilitaLogout = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            HabilitaLogout.Logout.Enabled = true;
        }

        private void CadRecordatorio_Load(object sender, EventArgs e)
        {
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
                }
                else
                {
                    MessageBox.Show("Seu cadastro não está ativo. Contate o Administrador do Sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BeginInvoke(new MethodInvoker(Close));
                }
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

                if (cb_Recordatorios.Items.Count == 0)
                {
                    bt_EditarRec.Enabled = false;
                }
            }

        }

        private void bt_adicionarRec_Click(object sender, EventArgs e)
        {
            if (cb_Pacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Paciente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja Iniciar o Recordatório deste Paciente ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {

                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                     "INSERT INTO public.recordatorio_24h " +
                        "(data_inclusao,descricao_nome, paciente_id, nutricionista_id, ativo) " +
                        "VALUES (@data_inclusao,@descricao_nome, @paciente_id, @nutricionista_id, @ativo) " +
                        "RETURNING id_rec",
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
                        bt_EditarRec.Enabled = false;
                        txt_DescricaoNome.Enabled = false;
                        gr_selecao.Visible = true;
                        gr_itens.Visible = true;
                        cb_Recordatorios.Enabled = false;
                        cb_Pacientes.Enabled = false;
                        try
                        {
                            var recId = comm.ExecuteScalar();

                            if (recId != null)
                            {
                                RecordatorioID = Convert.ToInt32(recId); // Converte o valor para int se não for null
                                                                         //MessageBox.Show($"Recordatório adicionado com ID: {RecordatorioID}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cb_Pacientes_SelectedIndexChanged(sender, e);
                                db.GetRecordatorioComboboxFiltroID(Convert.ToInt32(recId), cb_Recordatorios);
                                HabilitaTroca = true;
                                bt_EditarRec.Enabled = false;
                                bt_adicionarRec.Enabled = false;
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

                float gramas = TacoSelecionado.Gramas;
                TACOGramas = gramas;
                l_gramas.Text = Convert.ToString(TACOGramas) + "g";

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
            else
            {
                bt_EditarRec.Enabled = false;
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
                HabilitaTroca = true;
            }

            bt_adicionarRec.Enabled = false;
            bt_EditarRec.Enabled = false;
            txt_DescricaoNome.Enabled = false;
            txt_DescricaoNome.Text = "";
            gr_selecao.Visible = true;
            gr_itens.Visible = true;
            cb_Recordatorios.Enabled = false;
            cb_Pacientes.Enabled = false;

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

                        float totalgramas = Convert.ToInt64(txt_QuantidadeItens.Text)*TACOGramas;
                        float totalcalorias = (TACOEnergiaKcal/100)*TACOGramas;
                        float totalcarboidratos = (TACOcarboidrato/100)*TACOGramas;
                        float totalproteinas = (TACOProteinas/100)*TACOGramas;
                        float toalGorduras = (TACOLipidios/100)*TACOGramas;
                        float totalFibras = (TACOfibras/100)*TACOGramas;
                        float totalvitamina_a = (TACOvitamina_a/100)*TACOGramas;
                        float totalvitamina_c = (TACOvitamina_c/100)*TACOGramas;
                        float totalCalcio = (TACOCalcio/100)*TACOGramas;
                        float totalferro = (TACOferro/100)*TACOGramas;
                        float totalmagnesio = (TACOmagensio/100)*TACOGramas;

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
                rb_gramaInt.Checked = true;
                AtualizarDataGridView();
            }
            else
            {
                cb_Taco.Focus();
            }

        }


        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filtro.Text != "")
            {
                try
                {
                    using (var db = new DatabaseConnection())
                    {
                        using (NpgsqlConnection connection = db.GetConnection())
                        {
                            connection.Open();

                            string query = "SELECT data_rec, hora, quantidade, descricao_alimento " +
                                             "FROM vw_itensrecordatorio_detalhado " +
                                              "WHERE recordatorio_id = @Filtro " +
                                              "AND descricaoperiodo LIKE @DescricaoPeriodo";

                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                            {
                                // Passa o filtro como inteiro
                                command.Parameters.AddWithValue("@Filtro", RecordatorioID);
                                command.Parameters.AddWithValue("@DescricaoPeriodo", cb_filtro.Text);

                                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

                                DataTable dataTable = new DataTable();
                                dataAdapter.Fill(dataTable);

                                if (dataTable.Rows.Count > 0)
                                {
                                    dataGridView1.DataSource = dataTable;
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum item encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                AtualizarDataGridView();
            }
        }

        private void rb_gramaInt_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_gramaInt.Checked) 
            {
                cb_Taco_SelectedIndexChanged(sender, e);
                l_gramas.Text = Convert.ToString(TACOGramas) + "g";


                txt_gramaPersonalizado.Clear();
                txt_gramaPersonalizado.Visible = false;
                bt_grPersonaliza.Visible = false;
            }
        }

        private void rb_grMeia_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_grMeia.Checked) 
            {
                cb_Taco_SelectedIndexChanged(sender, e);
                TACOGramas = TACOGramas/2;
                l_gramas.Text = Convert.ToString(TACOGramas) + "g";

                txt_gramaPersonalizado.Clear();
                txt_gramaPersonalizado.Visible = false;
                bt_grPersonaliza.Visible = false;
            }
        }

        private void rb_grPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_grPersonalizado.Checked)
            {
                txt_gramaPersonalizado.Visible = true;
                bt_grPersonaliza.Visible = true;
            }
        }

        private void bt_grPersonaliza_Click(object sender, EventArgs e)
        {
            if (rb_grPersonalizado.Checked)
            {
                if ((txt_gramaPersonalizado.Text != null) || (txt_gramaPersonalizado.Text != ""))
                {
                    TACOGramas = Convert.ToInt32(txt_gramaPersonalizado.Text);
                    l_gramas.Text = Convert.ToString(TACOGramas) + "g";
                }

            }
        }

        private void txt_gramaPersonalizado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Aceita apenas Numeros
            {
                e.Handled = true;
            }
        }


        private void AtualizarDataGridView()
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Recarregar os dados no DataGridView
                    string query = "SELECT data_rec, hora, quantidade, descricao_alimento FROM vw_itensrecordatorio_detalhado WHERE recordatorio_id = @Filtro";
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
            if (HabilitaTroca)
            {
                if (tabControl1.SelectedIndex == 1 && cb_Recordatorios.SelectedItem != null)
                {
                    AtualizarDataGridView2();
                }
            }
            else
            {
                chart1.Series.Clear();
                dataGridView2.Columns.Clear();
                l_Calorias.Text = "";
                l_Carboidratos.Text = "";
                l_Lipidios.Text = "";
                l_Proteinas.Text = "";
                l_Qnt.Text = "";
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

                    if (dataGridView2.RowCount > 0 && dataGridView2.Rows[0].Cells[0].Value != null)
                    {
                        dataGridView2.Columns["id_itensrec"].Width  = 50;
                        dataGridView2.Columns["id_itensrec"].HeaderText = "ID";
                        dataGridView2.Columns["id_itensrec"].Visible = false;
                        dataGridView2.Columns["descricao"].Width  = 150;
                        dataGridView2.Columns["descricao"].HeaderText = "Descrição";
                        dataGridView2.Columns["quantidade"].Width  = 50;
                        dataGridView2.Columns["quantidade"].HeaderText = "Qnt.";
                        dataGridView2.Columns["carboidratos_totais"].HeaderText = "Carboidrato  (g)";
                        dataGridView2.Columns["carboidratos_totais"].Width  = 75;
                        dataGridView2.Columns["gorduras_totais"].HeaderText = "Lipideos (g)";
                        dataGridView2.Columns["gorduras_totais"].Width  = 75;
                        dataGridView2.Columns["proteinas_totais"].HeaderText = "Proteina  (g)";
                        dataGridView2.Columns["proteinas_totais"].Width  = 75;
                        dataGridView2.Columns["calorias_totais"].HeaderText = "Total Kcal. (kcal)";
                        dataGridView2.Columns["calorias_totais"].Width  = 75;
                        dataGridView2.Columns["vitamina_a"].HeaderText = "Vitamina A  (g)";
                        dataGridView2.Columns["vitamina_a"].Width  = 75;
                        dataGridView2.Columns["vitamina_c"].HeaderText = "Vitamina C  (g)";
                        dataGridView2.Columns["vitamina_c"].Width  = 75;
                        dataGridView2.Columns["calcio_total"].HeaderText = "Calcio  (g)";
                        dataGridView2.Columns["calcio_total"].Width  = 75;
                        dataGridView2.Columns["ferro_total"].HeaderText = "Ferro  (g)";
                        dataGridView2.Columns["ferro_total"].Width  = 75;
                        dataGridView2.Columns["magnesio_total"].HeaderText = "Magnesio  (g)";
                        dataGridView2.Columns["magnesio_total"].Width  = 75;

                        decimal SomaCalorias = 0, SomaCarboidratos = 0, SomaGorduras = 0, SomaProteinas = 0, SomaQnt = 0;

                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (row.Cells["calorias_totais"].Value != null)
                            {
                                SomaCalorias += Convert.ToDecimal(row.Cells["calorias_totais"].Value);
                                l_Calorias.Text = Convert.ToString(SomaCalorias) + " kcal";
                            }
                            if (row.Cells["carboidratos_totais"].Value != null)
                            {
                                SomaCarboidratos += Convert.ToDecimal(row.Cells["carboidratos_totais"].Value);
                                l_Carboidratos.Text = Convert.ToString(SomaCarboidratos) + "g";
                            }
                            if (row.Cells["gorduras_totais"].Value != null)
                            {
                                SomaGorduras += Convert.ToDecimal(row.Cells["gorduras_totais"].Value);
                                l_Lipidios.Text = Convert.ToString(SomaGorduras) + " g";
                            }
                            if (row.Cells["proteinas_totais"].Value != null)
                            {
                                SomaProteinas += Convert.ToDecimal(row.Cells["proteinas_totais"].Value);
                                l_Proteinas.Text = Convert.ToString(SomaProteinas) + " g";
                            }
                            if (row.Cells["gramas"].Value != null)
                            {
                                SomaQnt += Convert.ToDecimal(row.Cells["gramas"].Value);
                                l_Qnt.Text = Convert.ToString(SomaQnt) + " g";
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
                        series.BorderColor = System.Drawing.Color.Black;

                        // Adiciona a série ao gráfico
                        chart1.Series.Add(series);
                        bt_ExcluirIntem.Enabled = true;
                        bt_salvarPDF.Enabled = true;
                        bt_Excluir.Enabled = true;
                    }
                    else
                    {
                        chart1.Series.Clear();
                        bt_ExcluirIntem.Enabled = false;
                        bt_salvarPDF.Enabled = false;
                        bt_Excluir.Enabled = false;
                        l_Calorias.Text = "";
                        l_Carboidratos.Text = "";
                        l_Lipidios.Text = "";
                        l_Proteinas.Text = "";
                        l_Qnt.Text = "";
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
            if (MessageBox.Show("Deseja excluir esse item do Recordatório?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Obter o índice da linha selecionada
                    int rowIndex = dataGridView2.SelectedRows[0].Index;
                    int id = (int)dataGridView2.Rows[rowIndex].Cells["id_itensrec"].Value;

                    using (var db = new DatabaseConnection())
                    {
                        db.ExcluirItemRecordatorio(id);
                        MessageBox.Show("Item Excluido com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    dataGridView2.Rows.RemoveAt(rowIndex);
                    AtualizarDataGridView();
                    dataGridView1.Refresh();
                }
            }
            else
            {
                dataGridView2.Focus();
            }
        }

        private void bt_salvarPDF_Click(object sender, EventArgs e)
        {
            string NomePaciente = cb_Pacientes.SelectedItem.ToString();

            // Criação de um novo documento
            Document document = new Document();
            document.Info.Title = "Recordatório 24 horas de: " +  NomePaciente;
            document.Info.Subject = "Recordatório 24 horas";
            document.Info.Author = NutricionistaNome;

            // Adiciona uma seção ao documento
            Section section = document.AddSection();

            // Adiciona informações ao documento
            Paragraph Titulo = section.AddParagraph("Recordatório 24 horas ");
            Titulo.Format.Font.Size = 16;
            Titulo.Format.Font.Bold = true; // Define o texto em negrito
            Titulo.Format.Alignment = ParagraphAlignment.Center; // Centraliza o texto
            Paragraph Subtitulo = section.AddParagraph("Realizada por: " + NutricionistaNome);
            Subtitulo.Format.Font.Size = 8;
            Subtitulo.Format.Font.Color =  new MigraDocCore.DocumentObjectModel.Color(128, 128, 128);
            Subtitulo.Format.Font.Italic = true; // Define o texto em negrito
            Subtitulo.Format.Alignment = ParagraphAlignment.Center; // Centraliza o texto
            section.PageSetup.Orientation = MigraDocCore.DocumentObjectModel.Orientation.Landscape;
            section.AddParagraph("");
            section.AddParagraph("");

            Paragraph Paciente = section.AddParagraph("Paciente: " + NomePaciente);
            Paciente.Format.Font.Bold = true;
            Paciente.Format.Font.Size = 12;
            section.AddParagraph("");


            // Adiciona a tabela
            Table tabelaResultados = section.AddTable();
            tabelaResultados.Borders.Width = 0.75;

            // Definir as colunas da tabela com larguras ajustadas
                tabelaResultados.AddColumn(Unit.FromCentimeter(0.5));  // # 
                tabelaResultados.AddColumn(Unit.FromCentimeter(1.6));  // Hora 
                tabelaResultados.AddColumn(Unit.FromCentimeter(4.5));  // Descrição 
                tabelaResultados.AddColumn(Unit.FromCentimeter(1.2));  // Quantidade
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.2));  // Carboidrato
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.2));  // Lipídeos 
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.2));  // Proteína 
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.2));  // Total Kcal
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.2));  // Vitamina A 
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.2));  // Vitamina C
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.0));  // Cálcio
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.0));  // Ferro 
                tabelaResultados.AddColumn(Unit.FromCentimeter(2.0));  // Magnésio

            // Adiciona uma linha de cabeçalho
            Row titulo = tabelaResultados.AddRow();
            titulo.Shading.Color = Colors.LightGray;
            titulo.Format.Font.Bold = true;

            // Preencher os títulos das colunas
            titulo.Cells[0].AddParagraph("#");
            titulo.Cells[1].AddParagraph("Hora");
            titulo.Cells[2].AddParagraph("Descrição");
            titulo.Cells[3].AddParagraph("Qnt.");
            titulo.Cells[4].AddParagraph("Carboidrato (g)");
            titulo.Cells[5].AddParagraph("Lipídeos (g)");
            titulo.Cells[6].AddParagraph("Proteína (g)");
            titulo.Cells[7].AddParagraph("Total Kcal (kcal)");
            titulo.Cells[8].AddParagraph("Vitamina A (g)");
            titulo.Cells[9].AddParagraph("Vitamina C (g)");
            titulo.Cells[10].AddParagraph("Cálcio (g)");
            titulo.Cells[11].AddParagraph("Ferro (g)");
            titulo.Cells[12].AddParagraph("Magnésio (g)");

            // Adiciona as linhas de dados
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Row linha = tabelaResultados.AddRow();


                linha.Cells[0].AddParagraph(i.ToString());

                if (dataGridView2.Rows[i].Cells["descricao"].Value != null)
                    linha.Cells[2].AddParagraph(dataGridView2.Rows[i].Cells["descricao"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["quantidade"].Value != null)
                    linha.Cells[3].AddParagraph(dataGridView2.Rows[i].Cells["quantidade"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["carboidratos_totais"].Value != null)
                    linha.Cells[4].AddParagraph(dataGridView2.Rows[i].Cells["carboidratos_totais"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["gorduras_totais"].Value != null)
                    linha.Cells[5].AddParagraph(dataGridView2.Rows[i].Cells["gorduras_totais"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["proteinas_totais"].Value != null)
                    linha.Cells[6].AddParagraph(dataGridView2.Rows[i].Cells["proteinas_totais"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["calorias_totais"].Value != null)
                    linha.Cells[7].AddParagraph(dataGridView2.Rows[i].Cells["calorias_totais"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["vitamina_a"].Value != null)
                    linha.Cells[8].AddParagraph(dataGridView2.Rows[i].Cells["vitamina_a"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["vitamina_c"].Value != null)
                    linha.Cells[9].AddParagraph(dataGridView2.Rows[i].Cells["vitamina_c"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["calcio_total"].Value != null)
                    linha.Cells[10].AddParagraph(dataGridView2.Rows[i].Cells["calcio_total"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["ferro_total"].Value != null)
                    linha.Cells[11].AddParagraph(dataGridView2.Rows[i].Cells["ferro_total"].Value.ToString());

                if (dataGridView2.Rows[i].Cells["magnesio_total"].Value != null)
                    linha.Cells[12].AddParagraph(dataGridView2.Rows[i].Cells["magnesio_total"].Value.ToString());

                if (dataGridView1.Rows[i].Cells["hora"].Value != null)
                    linha.Cells[1].AddParagraph(dataGridView1.Rows[i].Cells["hora"].Value.ToString());
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
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Recordatorio24h " + NomePaciente + ".pdf";
            renderer.PdfDocument.Save(filename);

            // Exibe uma mensagem de sucesso
            MessageBox.Show($"PDF gerado em: {filename}");
        }


        private void bt_ExcluirAtv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse Recordatório 24 horas Permanentemente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {
                    try
                    {
                        db.ExcluirRecordatorio(RecordatorioID);
                        MessageBox.Show("Recordatório 24 horas Excluído com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro ao Excluir: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                tabControl1.SelectedIndex = 0;
                gr_selecao.Visible = false;
                gr_itens.Visible = false;
                bt_adicionarRec.Enabled = true;
                bt_EditarRec.Enabled = true;
                cb_Pacientes.Enabled = true;
                cb_Recordatorios.Enabled = true;
                HabilitaTroca = false;
                cb_Pacientes_SelectedIndexChanged(sender, e);
            }
        }
    }
}