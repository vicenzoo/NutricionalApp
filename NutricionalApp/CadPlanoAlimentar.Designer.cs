﻿namespace NutricionalApp
{
    partial class CadPlanoAlimentar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bt_grPersonaliza = new System.Windows.Forms.Button();
            this.txt_gramaPersonalizado = new System.Windows.Forms.TextBox();
            this.rb_grPersonalizado = new System.Windows.Forms.RadioButton();
            this.rb_grMeia = new System.Windows.Forms.RadioButton();
            this.rb_gramaInt = new System.Windows.Forms.RadioButton();
            this.cb_NomeDescricao = new System.Windows.Forms.ComboBox();
            this.bt_adicionarPlano = new System.Windows.Forms.Button();
            this.cb_Pacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gr_Resultados = new System.Windows.Forms.GroupBox();
            this.bt_ExcluirAtv = new System.Windows.Forms.Button();
            this.l_Qnt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_Calorias = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.l_Lipidios = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.l_Carboidratos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l_Proteinas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_ExcluirIntem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.l_gramas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_EditarPlano = new System.Windows.Forms.Button();
            this.cb_PlanosAlimentares = new System.Windows.Forms.ComboBox();
            this.txt_DescricaoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gr_itens = new System.Windows.Forms.GroupBox();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gr_selecao = new System.Windows.Forms.GroupBox();
            this.bt_adicionarItemPlano = new System.Windows.Forms.Button();
            this.txt_QuantidadeItens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Taco = new System.Windows.Forms.ComboBox();
            this.dt_DataHoraPlano = new System.Windows.Forms.DateTimePicker();
            this.tabPage4.SuspendLayout();
            this.gr_Resultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gr_itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gr_selecao.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_grPersonaliza
            // 
            this.bt_grPersonaliza.Location = new System.Drawing.Point(592, 81);
            this.bt_grPersonaliza.Name = "bt_grPersonaliza";
            this.bt_grPersonaliza.Size = new System.Drawing.Size(75, 23);
            this.bt_grPersonaliza.TabIndex = 20;
            this.bt_grPersonaliza.Text = "Aplicar";
            this.bt_grPersonaliza.UseVisualStyleBackColor = true;
            this.bt_grPersonaliza.Visible = false;
            this.bt_grPersonaliza.Click += new System.EventHandler(this.bt_grPersonaliza_Click);
            // 
            // txt_gramaPersonalizado
            // 
            this.txt_gramaPersonalizado.Location = new System.Drawing.Point(495, 83);
            this.txt_gramaPersonalizado.Name = "txt_gramaPersonalizado";
            this.txt_gramaPersonalizado.Size = new System.Drawing.Size(91, 20);
            this.txt_gramaPersonalizado.TabIndex = 19;
            this.txt_gramaPersonalizado.Visible = false;
            this.txt_gramaPersonalizado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gramaPersonalizado_KeyPress);
            // 
            // rb_grPersonalizado
            // 
            this.rb_grPersonalizado.AutoSize = true;
            this.rb_grPersonalizado.Location = new System.Drawing.Point(495, 64);
            this.rb_grPersonalizado.Name = "rb_grPersonalizado";
            this.rb_grPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.rb_grPersonalizado.TabIndex = 18;
            this.rb_grPersonalizado.Text = "Personalizado";
            this.rb_grPersonalizado.UseVisualStyleBackColor = true;
            this.rb_grPersonalizado.CheckedChanged += new System.EventHandler(this.rb_grPersonalizado_CheckedChanged);
            // 
            // rb_grMeia
            // 
            this.rb_grMeia.AutoSize = true;
            this.rb_grMeia.Location = new System.Drawing.Point(404, 64);
            this.rb_grMeia.Name = "rb_grMeia";
            this.rb_grMeia.Size = new System.Drawing.Size(85, 17);
            this.rb_grMeia.TabIndex = 17;
            this.rb_grMeia.Text = "Meia Porção";
            this.rb_grMeia.UseVisualStyleBackColor = true;
            this.rb_grMeia.CheckedChanged += new System.EventHandler(this.rb_grMeia_CheckedChanged);
            // 
            // rb_gramaInt
            // 
            this.rb_gramaInt.AutoSize = true;
            this.rb_gramaInt.Checked = true;
            this.rb_gramaInt.Location = new System.Drawing.Point(327, 64);
            this.rb_gramaInt.Name = "rb_gramaInt";
            this.rb_gramaInt.Size = new System.Drawing.Size(71, 17);
            this.rb_gramaInt.TabIndex = 16;
            this.rb_gramaInt.TabStop = true;
            this.rb_gramaInt.Text = "Gr. Inteira";
            this.rb_gramaInt.UseVisualStyleBackColor = true;
            this.rb_gramaInt.CheckedChanged += new System.EventHandler(this.rb_gramaInt_CheckedChanged);
            // 
            // cb_NomeDescricao
            // 
            this.cb_NomeDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NomeDescricao.FormattingEnabled = true;
            this.cb_NomeDescricao.Items.AddRange(new object[] {
            "Café da Manhã",
            "Lanche da Manhã",
            "Almoço",
            "Lanche da Tarde",
            "Jantar",
            "Ceia"});
            this.cb_NomeDescricao.Location = new System.Drawing.Point(20, 37);
            this.cb_NomeDescricao.Name = "cb_NomeDescricao";
            this.cb_NomeDescricao.Size = new System.Drawing.Size(166, 21);
            this.cb_NomeDescricao.TabIndex = 11;
            // 
            // bt_adicionarPlano
            // 
            this.bt_adicionarPlano.Image = global::NutricionalApp.Properties.Resources.Add_File_16px;
            this.bt_adicionarPlano.Location = new System.Drawing.Point(684, 16);
            this.bt_adicionarPlano.Name = "bt_adicionarPlano";
            this.bt_adicionarPlano.Size = new System.Drawing.Size(75, 30);
            this.bt_adicionarPlano.TabIndex = 3;
            this.bt_adicionarPlano.Text = "Novo";
            this.bt_adicionarPlano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_adicionarPlano.UseVisualStyleBackColor = true;
            this.bt_adicionarPlano.Click += new System.EventHandler(this.bt_adicionarPlano_Click);
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
            this.tabPage4.Size = new System.Drawing.Size(848, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resultados Gerais";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gr_Resultados
            // 
            this.gr_Resultados.Controls.Add(this.bt_ExcluirAtv);
            this.gr_Resultados.Controls.Add(this.l_Qnt);
            this.gr_Resultados.Controls.Add(this.label7);
            this.gr_Resultados.Controls.Add(this.l_Calorias);
            this.gr_Resultados.Controls.Add(this.label13);
            this.gr_Resultados.Controls.Add(this.l_Lipidios);
            this.gr_Resultados.Controls.Add(this.label12);
            this.gr_Resultados.Controls.Add(this.l_Carboidratos);
            this.gr_Resultados.Controls.Add(this.label11);
            this.gr_Resultados.Controls.Add(this.l_Proteinas);
            this.gr_Resultados.Controls.Add(this.label10);
            this.gr_Resultados.Controls.Add(this.bt_ExcluirIntem);
            this.gr_Resultados.Controls.Add(this.dataGridView2);
            this.gr_Resultados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gr_Resultados.Location = new System.Drawing.Point(0, 228);
            this.gr_Resultados.Name = "gr_Resultados";
            this.gr_Resultados.Size = new System.Drawing.Size(848, 260);
            this.gr_Resultados.TabIndex = 2;
            this.gr_Resultados.TabStop = false;
            this.gr_Resultados.Text = "Resultados:";
            // 
            // bt_ExcluirAtv
            // 
            this.bt_ExcluirAtv.Image = global::NutricionalApp.Properties.Resources.Delete_48;
            this.bt_ExcluirAtv.Location = new System.Drawing.Point(659, 192);
            this.bt_ExcluirAtv.Name = "bt_ExcluirAtv";
            this.bt_ExcluirAtv.Size = new System.Drawing.Size(154, 60);
            this.bt_ExcluirAtv.TabIndex = 40;
            this.bt_ExcluirAtv.Text = "Excluir Plano Alimentar";
            this.bt_ExcluirAtv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ExcluirAtv.UseVisualStyleBackColor = true;
            this.bt_ExcluirAtv.Click += new System.EventHandler(this.bt_ExcluirAtv_Click);
            // 
            // l_Qnt
            // 
            this.l_Qnt.AutoSize = true;
            this.l_Qnt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Qnt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_Qnt.Location = new System.Drawing.Point(409, 190);
            this.l_Qnt.Name = "l_Qnt";
            this.l_Qnt.Size = new System.Drawing.Size(39, 21);
            this.l_Qnt.TabIndex = 24;
            this.l_Qnt.Text = "Qnt.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(253, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantidade Total:";
            // 
            // l_Calorias
            // 
            this.l_Calorias.AutoSize = true;
            this.l_Calorias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Calorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_Calorias.Location = new System.Drawing.Point(351, 219);
            this.l_Calorias.Name = "l_Calorias";
            this.l_Calorias.Size = new System.Drawing.Size(66, 21);
            this.l_Calorias.TabIndex = 22;
            this.l_Calorias.Text = "Calorias";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(253, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 22);
            this.label13.TabIndex = 21;
            this.label13.Text = "Total Kcal.:";
            // 
            // l_Lipidios
            // 
            this.l_Lipidios.AutoSize = true;
            this.l_Lipidios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Lipidios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_Lipidios.Location = new System.Drawing.Point(86, 219);
            this.l_Lipidios.Name = "l_Lipidios";
            this.l_Lipidios.Size = new System.Drawing.Size(64, 21);
            this.l_Lipidios.TabIndex = 20;
            this.l_Lipidios.Text = "Lípidios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(6, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "Lípidios:";
            // 
            // l_Carboidratos
            // 
            this.l_Carboidratos.AutoSize = true;
            this.l_Carboidratos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Carboidratos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_Carboidratos.Location = new System.Drawing.Point(125, 190);
            this.l_Carboidratos.Name = "l_Carboidratos";
            this.l_Carboidratos.Size = new System.Drawing.Size(100, 21);
            this.l_Carboidratos.TabIndex = 18;
            this.l_Carboidratos.Text = "Carboidratos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Carboidratos:";
            // 
            // l_Proteinas
            // 
            this.l_Proteinas.AutoSize = true;
            this.l_Proteinas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Proteinas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_Proteinas.Location = new System.Drawing.Point(98, 161);
            this.l_Proteinas.Name = "l_Proteinas";
            this.l_Proteinas.Size = new System.Drawing.Size(75, 21);
            this.l_Proteinas.TabIndex = 16;
            this.l_Proteinas.Text = "Proteínas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Proteínas:";
            // 
            // bt_ExcluirIntem
            // 
            this.bt_ExcluirIntem.Image = global::NutricionalApp.Properties.Resources.Close_16;
            this.bt_ExcluirIntem.Location = new System.Drawing.Point(659, 161);
            this.bt_ExcluirIntem.Name = "bt_ExcluirIntem";
            this.bt_ExcluirIntem.Size = new System.Drawing.Size(154, 27);
            this.bt_ExcluirIntem.TabIndex = 13;
            this.bt_ExcluirIntem.Text = "Excluir Item Selecionado";
            this.bt_ExcluirIntem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ExcluirIntem.UseVisualStyleBackColor = true;
            this.bt_ExcluirIntem.Click += new System.EventHandler(this.bt_ExcluirIntem_Click);
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
            this.dataGridView2.Size = new System.Drawing.Size(842, 139);
            this.dataGridView2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 226);
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
            this.chart1.Size = new System.Drawing.Size(842, 207);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // l_gramas
            // 
            this.l_gramas.AutoSize = true;
            this.l_gramas.Location = new System.Drawing.Point(263, 83);
            this.l_gramas.Name = "l_gramas";
            this.l_gramas.Size = new System.Drawing.Size(38, 13);
            this.l_gramas.TabIndex = 15;
            this.l_gramas.Text = "Grama";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 514);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.bt_EditarPlano);
            this.tabPage1.Controls.Add(this.cb_PlanosAlimentares);
            this.tabPage1.Controls.Add(this.txt_DescricaoNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gr_itens);
            this.tabPage1.Controls.Add(this.gr_selecao);
            this.tabPage1.Controls.Add(this.bt_adicionarPlano);
            this.tabPage1.Controls.Add(this.cb_Pacientes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Planos Alimentares do Paciente:";
            // 
            // bt_EditarPlano
            // 
            this.bt_EditarPlano.Enabled = false;
            this.bt_EditarPlano.Image = global::NutricionalApp.Properties.Resources.Edit_Text_File_16;
            this.bt_EditarPlano.Location = new System.Drawing.Point(379, 57);
            this.bt_EditarPlano.Name = "bt_EditarPlano";
            this.bt_EditarPlano.Size = new System.Drawing.Size(129, 30);
            this.bt_EditarPlano.TabIndex = 11;
            this.bt_EditarPlano.Text = "Editar / Visualizar";
            this.bt_EditarPlano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EditarPlano.UseVisualStyleBackColor = true;
            this.bt_EditarPlano.Click += new System.EventHandler(this.bt_EditarPlano_Click);
            // 
            // cb_PlanosAlimentares
            // 
            this.cb_PlanosAlimentares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PlanosAlimentares.FormattingEnabled = true;
            this.cb_PlanosAlimentares.Location = new System.Drawing.Point(19, 63);
            this.cb_PlanosAlimentares.Name = "cb_PlanosAlimentares";
            this.cb_PlanosAlimentares.Size = new System.Drawing.Size(354, 21);
            this.cb_PlanosAlimentares.TabIndex = 10;
            this.cb_PlanosAlimentares.SelectedIndexChanged += new System.EventHandler(this.cb_PlanosAlimentares_SelectedIndexChanged);
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
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Novo Plano Alimentar:";
            // 
            // gr_itens
            // 
            this.gr_itens.Controls.Add(this.cb_filtro);
            this.gr_itens.Controls.Add(this.label6);
            this.gr_itens.Controls.Add(this.dataGridView1);
            this.gr_itens.Location = new System.Drawing.Point(19, 209);
            this.gr_itens.Name = "gr_itens";
            this.gr_itens.Size = new System.Drawing.Size(806, 223);
            this.gr_itens.TabIndex = 5;
            this.gr_itens.TabStop = false;
            this.gr_itens.Text = "Itens:";
            this.gr_itens.Visible = false;
            // 
            // cb_filtro
            // 
            this.cb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "",
            "Café da Manhã",
            "Lanche da Manhã",
            "Almoço",
            "Lanche da Tarde",
            "Jantar",
            "Ceia"});
            this.cb_filtro.Location = new System.Drawing.Point(68, 22);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(233, 21);
            this.cb_filtro.TabIndex = 18;
            this.cb_filtro.SelectedIndexChanged += new System.EventHandler(this.cb_filtro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Período:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // gr_selecao
            // 
            this.gr_selecao.Controls.Add(this.bt_grPersonaliza);
            this.gr_selecao.Controls.Add(this.txt_gramaPersonalizado);
            this.gr_selecao.Controls.Add(this.rb_grPersonalizado);
            this.gr_selecao.Controls.Add(this.rb_grMeia);
            this.gr_selecao.Controls.Add(this.rb_gramaInt);
            this.gr_selecao.Controls.Add(this.l_gramas);
            this.gr_selecao.Controls.Add(this.cb_NomeDescricao);
            this.gr_selecao.Controls.Add(this.label8);
            this.gr_selecao.Controls.Add(this.bt_adicionarItemPlano);
            this.gr_selecao.Controls.Add(this.txt_QuantidadeItens);
            this.gr_selecao.Controls.Add(this.label5);
            this.gr_selecao.Controls.Add(this.label4);
            this.gr_selecao.Controls.Add(this.label3);
            this.gr_selecao.Controls.Add(this.cb_Taco);
            this.gr_selecao.Controls.Add(this.dt_DataHoraPlano);
            this.gr_selecao.Location = new System.Drawing.Point(19, 90);
            this.gr_selecao.Name = "gr_selecao";
            this.gr_selecao.Size = new System.Drawing.Size(806, 113);
            this.gr_selecao.TabIndex = 4;
            this.gr_selecao.TabStop = false;
            this.gr_selecao.Text = "Seleção:";
            this.gr_selecao.Visible = false;
            // 
            // bt_adicionarItemPlano
            // 
            this.bt_adicionarItemPlano.Image = global::NutricionalApp.Properties.Resources.Add_16;
            this.bt_adicionarItemPlano.Location = new System.Drawing.Point(697, 33);
            this.bt_adicionarItemPlano.Name = "bt_adicionarItemPlano";
            this.bt_adicionarItemPlano.Size = new System.Drawing.Size(103, 63);
            this.bt_adicionarItemPlano.TabIndex = 9;
            this.bt_adicionarItemPlano.Text = "Adicionar ao Plano Alimentar";
            this.bt_adicionarItemPlano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_adicionarItemPlano.UseVisualStyleBackColor = true;
            this.bt_adicionarItemPlano.Click += new System.EventHandler(this.bt_adicionarItemPlano_Click);
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
            // dt_DataHoraPlano
            // 
            this.dt_DataHoraPlano.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_DataHoraPlano.Location = new System.Drawing.Point(20, 80);
            this.dt_DataHoraPlano.Name = "dt_DataHoraPlano";
            this.dt_DataHoraPlano.Size = new System.Drawing.Size(166, 20);
            this.dt_DataHoraPlano.TabIndex = 0;
            // 
            // CadPlanoAlimentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 514);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadPlanoAlimentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadPlanoAlimentar_Load);
            this.tabPage4.ResumeLayout(false);
            this.gr_Resultados.ResumeLayout(false);
            this.gr_Resultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gr_itens.ResumeLayout(false);
            this.gr_itens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gr_selecao.ResumeLayout(false);
            this.gr_selecao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_grPersonaliza;
        private System.Windows.Forms.TextBox txt_gramaPersonalizado;
        private System.Windows.Forms.RadioButton rb_grPersonalizado;
        private System.Windows.Forms.RadioButton rb_grMeia;
        private System.Windows.Forms.RadioButton rb_gramaInt;
        private System.Windows.Forms.ComboBox cb_NomeDescricao;
        private System.Windows.Forms.Button bt_adicionarPlano;
        private System.Windows.Forms.ComboBox cb_Pacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gr_Resultados;
        private System.Windows.Forms.Label l_Qnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_Calorias;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_Lipidios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label l_Carboidratos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_Proteinas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_ExcluirIntem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label l_gramas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_EditarPlano;
        private System.Windows.Forms.ComboBox cb_PlanosAlimentares;
        private System.Windows.Forms.TextBox txt_DescricaoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gr_itens;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gr_selecao;
        private System.Windows.Forms.Button bt_adicionarItemPlano;
        private System.Windows.Forms.TextBox txt_QuantidadeItens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Taco;
        private System.Windows.Forms.DateTimePicker dt_DataHoraPlano;
        private System.Windows.Forms.Button bt_ExcluirAtv;
    }
}