﻿namespace NutricionalApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_EditarRec = new System.Windows.Forms.Button();
            this.cb_Recordatorios = new System.Windows.Forms.ComboBox();
            this.txt_DescricaoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gr_itens = new System.Windows.Forms.GroupBox();
            this.gr_selecao = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Medida = new System.Windows.Forms.TextBox();
            this.txt_QuantidadeItens = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.bt_adicionarItemRec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nutricionalDB = new NutricionalApp.NutricionalDB();
            this.vwitensrecordatoriodetalhadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_itensrecordatorio_detalhadoTableAdapter = new NutricionalApp.NutricionalDBTableAdapters.vw_itensrecordatorio_detalhadoTableAdapter();
            this.recordatoriodescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoalimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_NomeDescricao = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gr_itens.SuspendLayout();
            this.gr_selecao.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitensrecordatoriodetalhadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 464);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.tabPage1.Size = new System.Drawing.Size(768, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            // 
            // bt_EditarRec
            // 
            this.bt_EditarRec.Enabled = false;
            this.bt_EditarRec.Image = global::NutricionalApp.Properties.Resources.Edit_Text_File_16;
            this.bt_EditarRec.Location = new System.Drawing.Point(684, 101);
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
            this.cb_Recordatorios.Location = new System.Drawing.Point(19, 49);
            this.cb_Recordatorios.Name = "cb_Recordatorios";
            this.cb_Recordatorios.Size = new System.Drawing.Size(354, 21);
            this.cb_Recordatorios.TabIndex = 10;
            this.cb_Recordatorios.SelectedIndexChanged += new System.EventHandler(this.cb_Recordatorios_SelectedIndexChanged);
            // 
            // txt_DescricaoNome
            // 
            this.txt_DescricaoNome.Location = new System.Drawing.Point(19, 110);
            this.txt_DescricaoNome.Name = "txt_DescricaoNome";
            this.txt_DescricaoNome.Size = new System.Drawing.Size(354, 20);
            this.txt_DescricaoNome.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição:";
            // 
            // gr_itens
            // 
            this.gr_itens.Controls.Add(this.dataGridView1);
            this.gr_itens.Location = new System.Drawing.Point(19, 296);
            this.gr_itens.Name = "gr_itens";
            this.gr_itens.Size = new System.Drawing.Size(740, 136);
            this.gr_itens.TabIndex = 5;
            this.gr_itens.TabStop = false;
            this.gr_itens.Text = "Itens:";
            this.gr_itens.Visible = false;
            // 
            // gr_selecao
            // 
            this.gr_selecao.Controls.Add(this.cb_NomeDescricao);
            this.gr_selecao.Controls.Add(this.label8);
            this.gr_selecao.Controls.Add(this.bt_adicionarItemRec);
            this.gr_selecao.Controls.Add(this.label7);
            this.gr_selecao.Controls.Add(this.txt_Medida);
            this.gr_selecao.Controls.Add(this.txt_QuantidadeItens);
            this.gr_selecao.Controls.Add(this.label6);
            this.gr_selecao.Controls.Add(this.label5);
            this.gr_selecao.Controls.Add(this.label4);
            this.gr_selecao.Controls.Add(this.label3);
            this.gr_selecao.Controls.Add(this.cb_Taco);
            this.gr_selecao.Controls.Add(this.dt_DataHoraRec);
            this.gr_selecao.Location = new System.Drawing.Point(19, 136);
            this.gr_selecao.Name = "gr_selecao";
            this.gr_selecao.Size = new System.Drawing.Size(740, 154);
            this.gr_selecao.TabIndex = 4;
            this.gr_selecao.TabStop = false;
            this.gr_selecao.Text = "Seleção:";
            this.gr_selecao.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Exemplo: Colher, Fatia...";
            // 
            // txt_Medida
            // 
            this.txt_Medida.AccessibleDescription = "";
            this.txt_Medida.Location = new System.Drawing.Point(91, 119);
            this.txt_Medida.Name = "txt_Medida";
            this.txt_Medida.Size = new System.Drawing.Size(128, 20);
            this.txt_Medida.TabIndex = 7;
            // 
            // txt_QuantidadeItens
            // 
            this.txt_QuantidadeItens.Location = new System.Drawing.Point(20, 119);
            this.txt_QuantidadeItens.Name = "txt_QuantidadeItens";
            this.txt_QuantidadeItens.Size = new System.Drawing.Size(65, 20);
            this.txt_QuantidadeItens.TabIndex = 6;
            this.txt_QuantidadeItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuantidadeItens_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Medida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 61);
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
            this.cb_Taco.Location = new System.Drawing.Point(192, 79);
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
            this.bt_adicionarRec.Location = new System.Drawing.Point(684, 65);
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
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 438);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resultados Gerais";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(375, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico:";
            this.groupBox1.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Arial", 10F);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(356, 177);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // bt_adicionarItemRec
            // 
            this.bt_adicionarItemRec.Image = global::NutricionalApp.Properties.Resources.Add_16;
            this.bt_adicionarItemRec.Location = new System.Drawing.Point(631, 89);
            this.bt_adicionarItemRec.Name = "bt_adicionarItemRec";
            this.bt_adicionarItemRec.Size = new System.Drawing.Size(103, 59);
            this.bt_adicionarItemRec.TabIndex = 9;
            this.bt_adicionarItemRec.Text = "Adicionar ao Recordatório";
            this.bt_adicionarItemRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_adicionarItemRec.UseVisualStyleBackColor = true;
            this.bt_adicionarItemRec.Click += new System.EventHandler(this.bt_adicionarItemRec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordatoriodescricaoDataGridViewTextBoxColumn,
            this.datarecDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn,
            this.descricaoalimentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwitensrecordatoriodetalhadoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(734, 117);
            this.dataGridView1.TabIndex = 0;
            // 
            // nutricionalDB
            // 
            this.nutricionalDB.DataSetName = "NutricionalDB";
            this.nutricionalDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwitensrecordatoriodetalhadoBindingSource
            // 
            this.vwitensrecordatoriodetalhadoBindingSource.DataMember = "vw_itensrecordatorio_detalhado";
            this.vwitensrecordatoriodetalhadoBindingSource.DataSource = this.nutricionalDB;
            // 
            // vw_itensrecordatorio_detalhadoTableAdapter
            // 
            this.vw_itensrecordatorio_detalhadoTableAdapter.ClearBeforeFill = true;
            // 
            // recordatoriodescricaoDataGridViewTextBoxColumn
            // 
            this.recordatoriodescricaoDataGridViewTextBoxColumn.DataPropertyName = "recordatorio_descricao";
            this.recordatoriodescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.recordatoriodescricaoDataGridViewTextBoxColumn.Name = "recordatoriodescricaoDataGridViewTextBoxColumn";
            this.recordatoriodescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordatoriodescricaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // datarecDataGridViewTextBoxColumn
            // 
            this.datarecDataGridViewTextBoxColumn.DataPropertyName = "data_rec";
            this.datarecDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datarecDataGridViewTextBoxColumn.Name = "datarecDataGridViewTextBoxColumn";
            this.datarecDataGridViewTextBoxColumn.ReadOnly = true;
            this.datarecDataGridViewTextBoxColumn.Width = 50;
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
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Tipo Medida";
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoalimentoDataGridViewTextBoxColumn
            // 
            this.descricaoalimentoDataGridViewTextBoxColumn.DataPropertyName = "descricao_alimento";
            this.descricaoalimentoDataGridViewTextBoxColumn.HeaderText = "Taco4";
            this.descricaoalimentoDataGridViewTextBoxColumn.Name = "descricaoalimentoDataGridViewTextBoxColumn";
            this.descricaoalimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoalimentoDataGridViewTextBoxColumn.Width = 325;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo:";
            // 
            // cb_NomeDescricao
            // 
            this.cb_NomeDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NomeDescricao.FormattingEnabled = true;
            this.cb_NomeDescricao.Items.AddRange(new object[] {
            "Café da Manhã",
            "Almoço",
            "",
            "",
            "Lanche da Manhã",
            "",
            "Lanche da Tarde",
            "",
            "Jantar",
            "",
            "Ceia"});
            this.cb_NomeDescricao.Location = new System.Drawing.Point(20, 37);
            this.cb_NomeDescricao.Name = "cb_NomeDescricao";
            this.cb_NomeDescricao.Size = new System.Drawing.Size(166, 21);
            this.cb_NomeDescricao.TabIndex = 11;
            // 
            // CadRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 496);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadRecordatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadRecordatorio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gr_itens.ResumeLayout(false);
            this.gr_selecao.ResumeLayout(false);
            this.gr_selecao.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwitensrecordatoriodetalhadoBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Medida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_adicionarItemRec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NutricionalDB nutricionalDB;
        private System.Windows.Forms.BindingSource vwitensrecordatoriodetalhadoBindingSource;
        private NutricionalDBTableAdapters.vw_itensrecordatorio_detalhadoTableAdapter vw_itensrecordatorio_detalhadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordatoriodescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoalimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_NomeDescricao;
    }
}