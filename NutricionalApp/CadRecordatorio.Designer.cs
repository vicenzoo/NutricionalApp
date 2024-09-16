namespace NutricionalApp
{
    partial class CadRecordatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_EditarRec = new System.Windows.Forms.Button();
            this.cb_Recordatorios = new System.Windows.Forms.ComboBox();
            this.txt_DescricaoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gr_itens = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descricaoperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoalimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwitensrecordatoriodetalhadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutricionalDB = new NutricionalApp.NutricionalDB();
            this.gr_selecao = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_gramas = new System.Windows.Forms.Label();
            this.cb_MedidasCaseiras = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_NomeDescricao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_adicionarItemRec = new System.Windows.Forms.Button();
            this.txt_QuantidadeItens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Taco = new System.Windows.Forms.ComboBox();
            this.dt_DataHoraRec = new System.Windows.Forms.DateTimePicker();
            this.bt_adicionarRec = new System.Windows.Forms.Button();
            this.cb_Pacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bt_ExcluirIntem = new System.Windows.Forms.Button();
            this.gr_Resultados = new System.Windows.Forms.GroupBox();
            this.gr_totais = new System.Windows.Forms.GroupBox();
            this.l_Calorias = new System.Windows.Forms.Label();
            this.l_Lipidios = new System.Windows.Forms.Label();
            this.l_Carboidratos = new System.Windows.Forms.Label();
            this.l_Proteinas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gr_itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitensrecordatoriodetalhadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).BeginInit();
            this.gr_selecao.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gr_Resultados.SuspendLayout();
            this.gr_totais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 496);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.bt_EditarRec);
            this.tabPage1.Controls.Add(this.cb_Recordatorios);
            this.tabPage1.Controls.Add(this.txt_DescricaoNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gr_itens);
            this.tabPage1.Controls.Add(this.gr_selecao);
            this.tabPage1.Controls.Add(this.bt_adicionarRec);
            this.tabPage1.Controls.Add(this.cb_Pacientes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Recordatorios do Paciente:";
            // 
            // bt_EditarRec
            // 
            this.bt_EditarRec.Enabled = false;
            this.bt_EditarRec.Image = global::NutricionalApp.Properties.Resources.Edit_Text_File_16;
            this.bt_EditarRec.Location = new System.Drawing.Point(379, 57);
            this.bt_EditarRec.Name = "bt_EditarRec";
            this.bt_EditarRec.Size = new System.Drawing.Size(75, 30);
            this.bt_EditarRec.TabIndex = 11;
            this.bt_EditarRec.Text = "Editar";
            this.bt_EditarRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EditarRec.UseVisualStyleBackColor = true;
            this.bt_EditarRec.Click += new System.EventHandler(this.bt_EditarRec_Click);
            // 
            // cb_Recordatorios
            // 
            this.cb_Recordatorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Recordatorios.FormattingEnabled = true;
            this.cb_Recordatorios.Location = new System.Drawing.Point(19, 63);
            this.cb_Recordatorios.Name = "cb_Recordatorios";
            this.cb_Recordatorios.Size = new System.Drawing.Size(354, 21);
            this.cb_Recordatorios.TabIndex = 10;
            this.cb_Recordatorios.SelectedIndexChanged += new System.EventHandler(this.cb_Recordatorios_SelectedIndexChanged);
            // 
            // txt_DescricaoNome
            // 
            this.txt_DescricaoNome.Location = new System.Drawing.Point(379, 23);
            this.txt_DescricaoNome.Name = "txt_DescricaoNome";
            this.txt_DescricaoNome.Size = new System.Drawing.Size(299, 20);
            this.txt_DescricaoNome.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Novo Recordatorio:";
            // 
            // gr_itens
            // 
            this.gr_itens.Controls.Add(this.dataGridView1);
            this.gr_itens.Location = new System.Drawing.Point(19, 234);
            this.gr_itens.Name = "gr_itens";
            this.gr_itens.Size = new System.Drawing.Size(806, 198);
            this.gr_itens.TabIndex = 5;
            this.gr_itens.TabStop = false;
            this.gr_itens.Text = "Itens:";
            this.gr_itens.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoperiodo,
            this.datarecDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.descricaoalimentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwitensrecordatoriodetalhadoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // descricaoperiodo
            // 
            this.descricaoperiodo.DataPropertyName = "descricaoperiodo";
            this.descricaoperiodo.HeaderText = "Período";
            this.descricaoperiodo.Name = "descricaoperiodo";
            this.descricaoperiodo.ReadOnly = true;
            // 
            // datarecDataGridViewTextBoxColumn
            // 
            this.datarecDataGridViewTextBoxColumn.DataPropertyName = "data_rec";
            this.datarecDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datarecDataGridViewTextBoxColumn.Name = "datarecDataGridViewTextBoxColumn";
            this.datarecDataGridViewTextBoxColumn.ReadOnly = true;
            this.datarecDataGridViewTextBoxColumn.Width = 75;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Qnt.";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 50;
            // 
            // descricaoalimentoDataGridViewTextBoxColumn
            // 
            this.descricaoalimentoDataGridViewTextBoxColumn.DataPropertyName = "descricao_alimento";
            this.descricaoalimentoDataGridViewTextBoxColumn.HeaderText = "Taco4";
            this.descricaoalimentoDataGridViewTextBoxColumn.Name = "descricaoalimentoDataGridViewTextBoxColumn";
            this.descricaoalimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoalimentoDataGridViewTextBoxColumn.Width = 350;
            // 
            // vwitensrecordatoriodetalhadoBindingSource
            // 
            this.vwitensrecordatoriodetalhadoBindingSource.DataMember = "vw_itensrecordatorio_detalhado";
            this.vwitensrecordatoriodetalhadoBindingSource.DataSource = this.nutricionalDB;
            // 
            // nutricionalDB
            // 
            this.nutricionalDB.DataSetName = "NutricionalDB";
            this.nutricionalDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gr_selecao
            // 
            this.gr_selecao.Controls.Add(this.label15);
            this.gr_selecao.Controls.Add(this.label7);
            this.gr_selecao.Controls.Add(this.l_gramas);
            this.gr_selecao.Controls.Add(this.cb_MedidasCaseiras);
            this.gr_selecao.Controls.Add(this.label6);
            this.gr_selecao.Controls.Add(this.cb_NomeDescricao);
            this.gr_selecao.Controls.Add(this.label8);
            this.gr_selecao.Controls.Add(this.bt_adicionarItemRec);
            this.gr_selecao.Controls.Add(this.txt_QuantidadeItens);
            this.gr_selecao.Controls.Add(this.label5);
            this.gr_selecao.Controls.Add(this.label4);
            this.gr_selecao.Controls.Add(this.label3);
            this.gr_selecao.Controls.Add(this.cb_Taco);
            this.gr_selecao.Controls.Add(this.dt_DataHoraRec);
            this.gr_selecao.Location = new System.Drawing.Point(19, 90);
            this.gr_selecao.Name = "gr_selecao";
            this.gr_selecao.Size = new System.Drawing.Size(806, 138);
            this.gr_selecao.TabIndex = 4;
            this.gr_selecao.TabStop = false;
            this.gr_selecao.Text = "Seleção:";
            this.gr_selecao.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(263, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(355, 26);
            this.label15.TabIndex = 16;
            this.label15.Text = "Obs: Você pode Adicionar e editar suas Medidas Caseiras no Botão \r\n\"Tabela TACO 4" +
    " edição e Gerenciar Medidas Caseiras\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Obs: Você pode Adicionar e editar suas Medidas Caseiras no Botão \r\n\"Tabela TACO 4" +
    " edição e Gerenciar Medidas Caseiras\"";
            // 
            // l_gramas
            // 
            this.l_gramas.AutoSize = true;
            this.l_gramas.Location = new System.Drawing.Point(508, 64);
            this.l_gramas.Name = "l_gramas";
            this.l_gramas.Size = new System.Drawing.Size(38, 13);
            this.l_gramas.TabIndex = 15;
            this.l_gramas.Text = "Grama";
            // 
            // cb_MedidasCaseiras
            // 
            this.cb_MedidasCaseiras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_MedidasCaseiras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_MedidasCaseiras.FormattingEnabled = true;
            this.cb_MedidasCaseiras.Location = new System.Drawing.Point(266, 79);
            this.cb_MedidasCaseiras.Name = "cb_MedidasCaseiras";
            this.cb_MedidasCaseiras.Size = new System.Drawing.Size(359, 21);
            this.cb_MedidasCaseiras.TabIndex = 13;
            this.cb_MedidasCaseiras.SelectedIndexChanged += new System.EventHandler(this.cb_MedidasCaseiras_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Medida Caseira:";
            // 
            // cb_NomeDescricao
            // 
            this.cb_NomeDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NomeDescricao.FormattingEnabled = true;
            this.cb_NomeDescricao.Items.AddRange(new object[] {
            "Café da Manhã",
            "Almoço",
            "Lanche da Manhã",
            "Lanche da Tarde",
            "Jantar",
            "Ceia"});
            this.cb_NomeDescricao.Location = new System.Drawing.Point(20, 37);
            this.cb_NomeDescricao.Name = "cb_NomeDescricao";
            this.cb_NomeDescricao.Size = new System.Drawing.Size(166, 21);
            this.cb_NomeDescricao.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo Refeição:";
            // 
            // bt_adicionarItemRec
            // 
            this.bt_adicionarItemRec.Image = global::NutricionalApp.Properties.Resources.Add_16;
            this.bt_adicionarItemRec.Location = new System.Drawing.Point(700, 41);
            this.bt_adicionarItemRec.Name = "bt_adicionarItemRec";
            this.bt_adicionarItemRec.Size = new System.Drawing.Size(103, 59);
            this.bt_adicionarItemRec.TabIndex = 9;
            this.bt_adicionarItemRec.Text = "Adicionar ao Recordatório";
            this.bt_adicionarItemRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_adicionarItemRec.UseVisualStyleBackColor = true;
            this.bt_adicionarItemRec.Click += new System.EventHandler(this.bt_adicionarItemRec_Click);
            // 
            // txt_QuantidadeItens
            // 
            this.txt_QuantidadeItens.Location = new System.Drawing.Point(192, 80);
            this.txt_QuantidadeItens.Name = "txt_QuantidadeItens";
            this.txt_QuantidadeItens.Size = new System.Drawing.Size(65, 20);
            this.txt_QuantidadeItens.TabIndex = 6;
            this.txt_QuantidadeItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuantidadeItens_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data e Hora:";
            // 
            // cb_Taco
            // 
            this.cb_Taco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Taco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Taco.FormattingEnabled = true;
            this.cb_Taco.Location = new System.Drawing.Point(192, 37);
            this.cb_Taco.Name = "cb_Taco";
            this.cb_Taco.Size = new System.Drawing.Size(433, 21);
            this.cb_Taco.TabIndex = 1;
            this.cb_Taco.SelectedIndexChanged += new System.EventHandler(this.cb_Taco_SelectedIndexChanged);
            // 
            // dt_DataHoraRec
            // 
            this.dt_DataHoraRec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_DataHoraRec.Location = new System.Drawing.Point(20, 80);
            this.dt_DataHoraRec.Name = "dt_DataHoraRec";
            this.dt_DataHoraRec.Size = new System.Drawing.Size(166, 20);
            this.dt_DataHoraRec.TabIndex = 0;
            // 
            // bt_adicionarRec
            // 
            this.bt_adicionarRec.Image = global::NutricionalApp.Properties.Resources.Add_File_16px;
            this.bt_adicionarRec.Location = new System.Drawing.Point(684, 16);
            this.bt_adicionarRec.Name = "bt_adicionarRec";
            this.bt_adicionarRec.Size = new System.Drawing.Size(75, 30);
            this.bt_adicionarRec.TabIndex = 3;
            this.bt_adicionarRec.Text = "Novo";
            this.bt_adicionarRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_adicionarRec.UseVisualStyleBackColor = true;
            this.bt_adicionarRec.Click += new System.EventHandler(this.bt_adicionarRec_Click);
            // 
            // cb_Pacientes
            // 
            this.cb_Pacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pacientes.FormattingEnabled = true;
            this.cb_Pacientes.Location = new System.Drawing.Point(19, 22);
            this.cb_Pacientes.Name = "cb_Pacientes";
            this.cb_Pacientes.Size = new System.Drawing.Size(354, 21);
            this.cb_Pacientes.TabIndex = 2;
            this.cb_Pacientes.SelectedIndexChanged += new System.EventHandler(this.cb_Pacientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente:";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.gr_Resultados);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(833, 470);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resultados Gerais";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico:";
            // 
            // chart1
            // 
            chartArea15.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea15);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Name = "Legend1";
            this.chart1.Legends.Add(legend15);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series15.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series15.BorderColor = System.Drawing.Color.Black;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series15.Font = new System.Drawing.Font("Arial", 10F);
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(810, 207);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 40;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(810, 158);
            this.dataGridView2.TabIndex = 5;
            // 
            // bt_ExcluirIntem
            // 
            this.bt_ExcluirIntem.Image = global::NutricionalApp.Properties.Resources.Close_16;
            this.bt_ExcluirIntem.Location = new System.Drawing.Point(656, 180);
            this.bt_ExcluirIntem.Name = "bt_ExcluirIntem";
            this.bt_ExcluirIntem.Size = new System.Drawing.Size(154, 27);
            this.bt_ExcluirIntem.TabIndex = 13;
            this.bt_ExcluirIntem.Text = "Excluir Item Selecionado";
            this.bt_ExcluirIntem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ExcluirIntem.UseVisualStyleBackColor = true;
            this.bt_ExcluirIntem.Click += new System.EventHandler(this.bt_ExcluirIntem_Click);
            // 
            // gr_Resultados
            // 
            this.gr_Resultados.Controls.Add(this.gr_totais);
            this.gr_Resultados.Controls.Add(this.bt_ExcluirIntem);
            this.gr_Resultados.Controls.Add(this.dataGridView2);
            this.gr_Resultados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gr_Resultados.Location = new System.Drawing.Point(0, 226);
            this.gr_Resultados.Name = "gr_Resultados";
            this.gr_Resultados.Size = new System.Drawing.Size(816, 260);
            this.gr_Resultados.TabIndex = 2;
            this.gr_Resultados.TabStop = false;
            this.gr_Resultados.Text = "Resultados:";
            // 
            // gr_totais
            // 
            this.gr_totais.Controls.Add(this.l_Calorias);
            this.gr_totais.Controls.Add(this.l_Lipidios);
            this.gr_totais.Controls.Add(this.l_Carboidratos);
            this.gr_totais.Controls.Add(this.l_Proteinas);
            this.gr_totais.Controls.Add(this.label13);
            this.gr_totais.Controls.Add(this.label12);
            this.gr_totais.Controls.Add(this.label11);
            this.gr_totais.Controls.Add(this.label10);
            this.gr_totais.Location = new System.Drawing.Point(3, 180);
            this.gr_totais.Name = "gr_totais";
            this.gr_totais.Size = new System.Drawing.Size(647, 64);
            this.gr_totais.TabIndex = 14;
            this.gr_totais.TabStop = false;
            this.gr_totais.Text = "Totais:";
            // 
            // l_Calorias
            // 
            this.l_Calorias.AutoSize = true;
            this.l_Calorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Calorias.ForeColor = System.Drawing.Color.Purple;
            this.l_Calorias.Location = new System.Drawing.Point(111, 41);
            this.l_Calorias.Name = "l_Calorias";
            this.l_Calorias.Size = new System.Drawing.Size(66, 20);
            this.l_Calorias.TabIndex = 17;
            this.l_Calorias.Text = "Calorias";
            // 
            // l_Lipidios
            // 
            this.l_Lipidios.AutoSize = true;
            this.l_Lipidios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Lipidios.ForeColor = System.Drawing.Color.Purple;
            this.l_Lipidios.Location = new System.Drawing.Point(503, 18);
            this.l_Lipidios.Name = "l_Lipidios";
            this.l_Lipidios.Size = new System.Drawing.Size(62, 20);
            this.l_Lipidios.TabIndex = 16;
            this.l_Lipidios.Text = "Lípidios";
            // 
            // l_Carboidratos
            // 
            this.l_Carboidratos.AutoSize = true;
            this.l_Carboidratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Carboidratos.ForeColor = System.Drawing.Color.Purple;
            this.l_Carboidratos.Location = new System.Drawing.Point(311, 18);
            this.l_Carboidratos.Name = "l_Carboidratos";
            this.l_Carboidratos.Size = new System.Drawing.Size(100, 20);
            this.l_Carboidratos.TabIndex = 15;
            this.l_Carboidratos.Text = "Carboidratos";
            // 
            // l_Proteinas
            // 
            this.l_Proteinas.AutoSize = true;
            this.l_Proteinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Proteinas.ForeColor = System.Drawing.Color.Purple;
            this.l_Proteinas.Location = new System.Drawing.Point(104, 18);
            this.l_Proteinas.Name = "l_Proteinas";
            this.l_Proteinas.Size = new System.Drawing.Size(76, 20);
            this.l_Proteinas.TabIndex = 14;
            this.l_Proteinas.Text = "Proteínas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(7, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Total Kcal.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(414, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Lípidios:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(186, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "Carboidratos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Proteínas:";
            // 
            // CadRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 496);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadRecordatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadRecordatorio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gr_itens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitensrecordatoriodetalhadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).EndInit();
            this.gr_selecao.ResumeLayout(false);
            this.gr_selecao.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gr_Resultados.ResumeLayout(false);
            this.gr_totais.ResumeLayout(false);
            this.gr_totais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Pacientes;
        private System.Windows.Forms.Button bt_adicionarRec;
        private System.Windows.Forms.GroupBox gr_selecao;
        private System.Windows.Forms.GroupBox gr_itens;
        private System.Windows.Forms.DateTimePicker dt_DataHoraRec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DescricaoNome;
        private System.Windows.Forms.ComboBox cb_Recordatorios;
        private System.Windows.Forms.Button bt_EditarRec;
        private System.Windows.Forms.ComboBox cb_Taco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txt_QuantidadeItens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_adicionarItemRec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NutricionalDB nutricionalDB;
        private System.Windows.Forms.BindingSource vwitensrecordatoriodetalhadoBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_NomeDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoalimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_MedidasCaseiras;
        private System.Windows.Forms.Label l_gramas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gr_Resultados;
        private System.Windows.Forms.Button bt_ExcluirIntem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gr_totais;
        private System.Windows.Forms.Label l_Calorias;
        private System.Windows.Forms.Label l_Lipidios;
        private System.Windows.Forms.Label l_Carboidratos;
        private System.Windows.Forms.Label l_Proteinas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}