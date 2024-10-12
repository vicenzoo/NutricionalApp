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
    public partial class CadPlanoAlimentar : Form
    {
        int PacienteId;
        int NutricionistaID = 0;
        int TacoID = 0;
        int PlanoAlimentarID = 0;
        float TACOGramas = 0;
        float TACOcarboidrato = 0; //Carboidratos
        float TACOEnergiaKcal = 0, TACOProteinas = 0; //Calorias
        float TACOLipidios = 0; //Gorduras
        float TACOfibras = 0; // Fibras Totais
        float TACOvitamina_a = 0, TACOvitamina_c = 0; //Vitaminas
        float TACOCalcio = 0, TACOferro = 0, TACOmagensio = 0; //Minerais


        public CadPlanoAlimentar()
        {
            InitializeComponent();
            this.TopMost = true;
            dt_DataHoraPlano.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dt_DataHoraPlano.Value = DateTime.Now;
            dt_DataHoraPlano.MinDate = DateTime.Now;
        }



        private void CadPlanoAlimentar_Load(object sender, EventArgs e)
        {
            FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
            NutricionistaID = Convert.ToInt32(GetIDNutricionista.IDLabel.Text.Substring(1));

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
                txt_DescricaoNome.Text = "Plano Alimentar para " + cb_Pacientes.Text;
                //bt_adicionarPlano.Enabled = true;
            }

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetPlanoAlimentarCombobox(PacienteId, cb_PlanosAlimentares);
            }
        }


        private void bt_adicionarPlano_Click(object sender, EventArgs e)
        {
            if (cb_Pacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Paciente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja Iniciar o Plano Alimentar deste Paciente ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {

                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                     "INSERT INTO public.plano_alimentar " +
                        "(\"Data_Inclusao\",descricao, paciente_id, nutricionista_id, ativo) " +
                        "VALUES (@data_inclusao,@descricao, @paciente_id, @nutricionista_id, @ativo)",
                        db.GetConnection()))
                    {

                        comm.Parameters.AddWithValue("@data_inclusao", DateTime.Now); // Data de inclusão
                        comm.Parameters.AddWithValue("@descricao", txt_DescricaoNome.Text);
                        comm.Parameters.AddWithValue("@paciente_id", PacienteId);
                        comm.Parameters.AddWithValue("@nutricionista_id", NutricionistaID);
                        comm.Parameters.AddWithValue("@ativo", 'S');

                        try
                        {
                            var planoID = comm.ExecuteScalar();

                            gr_selecao.Visible = true;
                            gr_itens.Visible = true;
                            bt_adicionarPlano.Enabled = false;
                            bt_EditarPlano.Enabled = false;
                            cb_Pacientes.Enabled = false;
                            cb_PlanosAlimentares.Enabled = false;
                            txt_DescricaoNome.Enabled = false;

                            if (planoID != null)
                            {
                                PlanoAlimentarID = Convert.ToInt32(planoID); // Converte o valor para int se não for null
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

                cb_Pacientes_SelectedIndexChanged(sender, e);

            }
            else
            {
                bt_adicionarPlano.Focus();
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

                //Para Calculo do Plano Alimentar:

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

        private void cb_PlanosAlimentares_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenha o paciente selecionado
            PlanoAlimentar planoAlimentar = (PlanoAlimentar)cb_PlanosAlimentares.SelectedItem;

            if (planoAlimentar != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idRecordatorio = planoAlimentar.Id;
                PlanoAlimentarID = idRecordatorio;


                bt_EditarPlano.Enabled = true;

            }
        }


        private void bt_EditarPlano_Click(object sender, EventArgs e)
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

                string query = "SELECT descricaoperiodo,data,hora,quantidade,descricao_alimento FROM vw_itensplanoAlimentar_detalhado WHERE plano_alimentar_id = @Filtro";

                db.CarregarDados(query, PlanoAlimentarID, dataGridView1);
                dataGridView1.Columns["descricaoperiodo"].Width  = 100;
                dataGridView1.Columns["descricaoperiodo"].HeaderText = "Descrição Período";
                dataGridView1.Columns["data"].Width  = 75;
                dataGridView1.Columns["data"].HeaderText = "Data";
                dataGridView1.Columns["hora"].Width  = 75;
                dataGridView1.Columns["hora"].HeaderText = "Hora";
                dataGridView1.Columns["quantidade"].Width  = 100;
                dataGridView1.Columns["quantidade"].HeaderText = "Quantidade";
                dataGridView1.Columns["descricao_alimento"].Width  = 350;
                dataGridView1.Columns["descricao_alimento"].HeaderText = "Descrição Alimento";
            }

            gr_selecao.Visible = true;
            gr_itens.Visible = true;
            bt_adicionarPlano.Enabled = false;
            bt_EditarPlano.Enabled = false;
            cb_Pacientes.Enabled = false;
            txt_DescricaoNome.Enabled = false;
            cb_PlanosAlimentares.Enabled = false;
        }


        private void bt_adicionarItemPlano_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja adicionar esse item ao Plano Alimentar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                         "INSERT INTO public.itens_plano_alimentar " +
                         "(plano_alimentar_id, data, hora, taco_id, descricao, quantidade,gramas,"
                         +"calorias_totais,carboidratos_totais,proteinas_totais,gorduras_totais,"
                         +"fibras_totais,vitamina_a,vitamina_c,calcio_total,ferro_total,magnesio_total"+") " +
                         "VALUES (@plano_alimentar_id, @data, @hora, @taco_id, @descricao, @quantidade,@gramas,"
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
                        comm.Parameters.AddWithValue("@plano_alimentar_id", PlanoAlimentarID);
                        comm.Parameters.AddWithValue("@data", dt_DataHoraPlano.Value.Date);
                        comm.Parameters.AddWithValue("@hora", dt_DataHoraPlano.Value.TimeOfDay);
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

        private void AtualizarDataGridView()
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Recarregar os dados no DataGridView
                    string query = "SELECT descricaoperiodo, data, hora, quantidade, descricao_alimento FROM vw_itensplanoAlimentar_detalhado WHERE plano_alimentar_id = @Filtro";
                    db.CarregarDados(query, PlanoAlimentarID, dataGridView1);
                    dataGridView1.Columns["descricaoperiodo"].Width  = 100;
                    dataGridView1.Columns["descricaoperiodo"].HeaderText = "Descrição Período";
                    dataGridView1.Columns["data"].Width  = 75;
                    dataGridView1.Columns["data"].HeaderText = "Data";
                    dataGridView1.Columns["hora"].Width  = 75;
                    dataGridView1.Columns["hora"].HeaderText = "Hora";
                    dataGridView1.Columns["quantidade"].Width  = 100;
                    dataGridView1.Columns["quantidade"].HeaderText = "Quantidade";
                    dataGridView1.Columns["descricao_alimento"].Width  = 350;
                    dataGridView1.Columns["descricao_alimento"].HeaderText = "Descrição Alimento";
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Erro ao atualizar a lista: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                            string query = "SELECT descricaoperiodo,data, hora, quantidade, descricao_alimento " +
                                             "FROM vw_itensplanoAlimentar_detalhado " +
                                              "WHERE plano_alimentar_id = @Filtro " +
                                              "AND descricaoperiodo LIKE @DescricaoPeriodo";

                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                            {
                                // Passa o filtro como inteiro
                                command.Parameters.AddWithValue("@Filtro", PlanoAlimentarID);
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

        public void AtualizarDataGridView2()
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Recarregar os dados no DataGridView2
                    string query = "SELECT ip.id_itensplano, tt.descricao, ip.quantidade,ip.gramas,ip.calorias_totais,ip.carboidratos_totais,ip.proteinas_totais,ip.fibras_totais,ip.gorduras_totais,ip.vitamina_a,ip.vitamina_c,ip.calcio_total,ip.ferro_total,ip.magnesio_total FROM itens_plano_alimentar ip JOIN tabela_taco4 tt ON ip.taco_id = tt.id  WHERE plano_alimentar_id = @Filtro";
                    db.CarregarDados(query, PlanoAlimentarID, dataGridView2);
                    dataGridView2.Columns["id_itensplano"].Width  = 50;
                    dataGridView2.Columns["id_itensplano"].HeaderText = "ID";
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                AtualizarDataGridView2();
            }
        }

        private void bt_ExcluirIntem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse item do Plano Alimentar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Obter o índice da linha selecionada
                    int rowIndex = dataGridView2.SelectedRows[0].Index;
                    int id = (int)dataGridView2.Rows[rowIndex].Cells["id_itensplano"].Value;

                    using (var db = new DatabaseConnection())
                    {
                        db.ExcluirItemPlanoAlimentar(id);
                        MessageBox.Show("Item Excluido com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        private void bt_ExcluirAtv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse Plano Alimentar Permanentemente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {
                    try
                    {
                        db.ExcluirPlanoAlimentar(PlanoAlimentarID);
                        MessageBox.Show("Plano Alimentar Excluído com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro ao Excluir: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                tabControl1.SelectedIndex = 0;
                gr_selecao.Visible = false;
                gr_itens.Visible = false;
                bt_adicionarPlano.Enabled = true;
                bt_EditarPlano.Enabled = true;
                cb_Pacientes.Enabled = true;
                cb_PlanosAlimentares.Enabled = true;
                cb_Pacientes_SelectedIndexChanged(sender, e);
            }

        }

    }
}
