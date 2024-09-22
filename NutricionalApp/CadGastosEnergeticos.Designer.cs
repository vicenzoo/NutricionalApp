namespace NutricionalApp
{
    partial class CadGastosEnergeticos
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
            this.cb_Pacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Gastoenergico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DescricaoNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gr_ExibeDados = new System.Windows.Forms.GroupBox();
            this.gr_VET = new System.Windows.Forms.GroupBox();
            this.VET = new System.Windows.Forms.Label();
            this.gr_GEB = new System.Windows.Forms.GroupBox();
            this.GEB = new System.Windows.Forms.Label();
            this.cb_Protocolo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_ResultVenta = new System.Windows.Forms.Label();
            this.txt_AlturaDesejada = new System.Windows.Forms.TextBox();
            this.txt_PesoDesejado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.l_descNivelAtividade = new System.Windows.Forms.Label();
            this.gr_atividade_fisica = new System.Windows.Forms.GroupBox();
            this.l_frequencia = new System.Windows.Forms.Label();
            this.l_met = new System.Windows.Forms.Label();
            this.cb_QntAtividade = new System.Windows.Forms.ComboBox();
            this.txt_frequencia = new System.Windows.Forms.TextBox();
            this.dt_tempo = new System.Windows.Forms.DateTimePicker();
            this.bt_adicionarItemAtividade = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_AtvFisica = new System.Windows.Forms.ComboBox();
            this.cb_NivelAtv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_EditarGasto = new System.Windows.Forms.Button();
            this.bt_adicionarGasto = new System.Windows.Forms.Button();
            this.l_idade = new System.Windows.Forms.Label();
            this.l_sexo = new System.Windows.Forms.Label();
            this.gr_ExibeDados.SuspendLayout();
            this.gr_VET.SuspendLayout();
            this.gr_GEB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gr_atividade_fisica.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Pacientes
            // 
            this.cb_Pacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pacientes.FormattingEnabled = true;
            this.cb_Pacientes.Location = new System.Drawing.Point(22, 31);
            this.cb_Pacientes.Name = "cb_Pacientes";
            this.cb_Pacientes.Size = new System.Drawing.Size(354, 21);
            this.cb_Pacientes.TabIndex = 4;
            this.cb_Pacientes.SelectedIndexChanged += new System.EventHandler(this.cb_Pacientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paciente:";
            // 
            // cb_Gastoenergico
            // 
            this.cb_Gastoenergico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gastoenergico.FormattingEnabled = true;
            this.cb_Gastoenergico.Location = new System.Drawing.Point(22, 72);
            this.cb_Gastoenergico.Name = "cb_Gastoenergico";
            this.cb_Gastoenergico.Size = new System.Drawing.Size(354, 21);
            this.cb_Gastoenergico.TabIndex = 15;
            this.cb_Gastoenergico.SelectedIndexChanged += new System.EventHandler(this.cb_Gastoenergico_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gastos Energeticos do Paciente:";
            // 
            // txt_DescricaoNome
            // 
            this.txt_DescricaoNome.Location = new System.Drawing.Point(457, 55);
            this.txt_DescricaoNome.Name = "txt_DescricaoNome";
            this.txt_DescricaoNome.Size = new System.Drawing.Size(299, 20);
            this.txt_DescricaoNome.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Novo Gasto Energetico:";
            // 
            // gr_ExibeDados
            // 
            this.gr_ExibeDados.Controls.Add(this.gr_VET);
            this.gr_ExibeDados.Controls.Add(this.gr_GEB);
            this.gr_ExibeDados.Controls.Add(this.cb_Protocolo);
            this.gr_ExibeDados.Controls.Add(this.label10);
            this.gr_ExibeDados.Controls.Add(this.bt_Salvar);
            this.gr_ExibeDados.Controls.Add(this.groupBox1);
            this.gr_ExibeDados.Controls.Add(this.l_descNivelAtividade);
            this.gr_ExibeDados.Controls.Add(this.gr_atividade_fisica);
            this.gr_ExibeDados.Controls.Add(this.cb_NivelAtv);
            this.gr_ExibeDados.Controls.Add(this.label4);
            this.gr_ExibeDados.Controls.Add(this.txt_Altura);
            this.gr_ExibeDados.Controls.Add(this.txt_Peso);
            this.gr_ExibeDados.Controls.Add(this.label3);
            this.gr_ExibeDados.Controls.Add(this.label2);
            this.gr_ExibeDados.Location = new System.Drawing.Point(22, 137);
            this.gr_ExibeDados.Name = "gr_ExibeDados";
            this.gr_ExibeDados.Size = new System.Drawing.Size(766, 287);
            this.gr_ExibeDados.TabIndex = 21;
            this.gr_ExibeDados.TabStop = false;
            this.gr_ExibeDados.Visible = false;
            // 
            // gr_VET
            // 
            this.gr_VET.BackColor = System.Drawing.Color.GhostWhite;
            this.gr_VET.Controls.Add(this.VET);
            this.gr_VET.Location = new System.Drawing.Point(373, 217);
            this.gr_VET.Name = "gr_VET";
            this.gr_VET.Size = new System.Drawing.Size(187, 59);
            this.gr_VET.TabIndex = 36;
            this.gr_VET.TabStop = false;
            this.gr_VET.Text = "VET / GET";
            this.gr_VET.Visible = false;
            // 
            // VET
            // 
            this.VET.AutoSize = true;
            this.VET.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VET.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VET.Location = new System.Drawing.Point(3, 16);
            this.VET.Name = "VET";
            this.VET.Size = new System.Drawing.Size(61, 37);
            this.VET.TabIndex = 1;
            this.VET.Text = "VET";
            // 
            // gr_GEB
            // 
            this.gr_GEB.BackColor = System.Drawing.Color.GhostWhite;
            this.gr_GEB.Controls.Add(this.GEB);
            this.gr_GEB.Location = new System.Drawing.Point(373, 152);
            this.gr_GEB.Name = "gr_GEB";
            this.gr_GEB.Size = new System.Drawing.Size(187, 59);
            this.gr_GEB.TabIndex = 35;
            this.gr_GEB.TabStop = false;
            this.gr_GEB.Text = "GEB / TMB";
            this.gr_GEB.Visible = false;
            // 
            // GEB
            // 
            this.GEB.AutoSize = true;
            this.GEB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GEB.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEB.Location = new System.Drawing.Point(3, 16);
            this.GEB.Name = "GEB";
            this.GEB.Size = new System.Drawing.Size(64, 37);
            this.GEB.TabIndex = 0;
            this.GEB.Text = "GEB";
            // 
            // cb_Protocolo
            // 
            this.cb_Protocolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Protocolo.FormattingEnabled = true;
            this.cb_Protocolo.Location = new System.Drawing.Point(376, 88);
            this.cb_Protocolo.Name = "cb_Protocolo";
            this.cb_Protocolo.Size = new System.Drawing.Size(358, 21);
            this.cb_Protocolo.TabIndex = 34;
            this.cb_Protocolo.SelectedIndexChanged += new System.EventHandler(this.cb_Protocolo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Protocolo:";
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(685, 253);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar.TabIndex = 32;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_ResultVenta);
            this.groupBox1.Controls.Add(this.txt_AlturaDesejada);
            this.groupBox1.Controls.Add(this.txt_PesoDesejado);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(274, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 51);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENTA:";
            // 
            // l_ResultVenta
            // 
            this.l_ResultVenta.AutoSize = true;
            this.l_ResultVenta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ResultVenta.Location = new System.Drawing.Point(364, 22);
            this.l_ResultVenta.Name = "l_ResultVenta";
            this.l_ResultVenta.Size = new System.Drawing.Size(62, 14);
            this.l_ResultVenta.TabIndex = 16;
            this.l_ResultVenta.Text = "Resultado";
            // 
            // txt_AlturaDesejada
            // 
            this.txt_AlturaDesejada.Location = new System.Drawing.Point(274, 19);
            this.txt_AlturaDesejada.Name = "txt_AlturaDesejada";
            this.txt_AlturaDesejada.Size = new System.Drawing.Size(73, 20);
            this.txt_AlturaDesejada.TabIndex = 14;
            // 
            // txt_PesoDesejado
            // 
            this.txt_PesoDesejado.Location = new System.Drawing.Point(99, 19);
            this.txt_PesoDesejado.Name = "txt_PesoDesejado";
            this.txt_PesoDesejado.Size = new System.Drawing.Size(73, 20);
            this.txt_PesoDesejado.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tempo em dias:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Peso Desejado:";
            // 
            // l_descNivelAtividade
            // 
            this.l_descNivelAtividade.AutoSize = true;
            this.l_descNivelAtividade.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_descNivelAtividade.Location = new System.Drawing.Point(7, 112);
            this.l_descNivelAtividade.Name = "l_descNivelAtividade";
            this.l_descNivelAtividade.Size = new System.Drawing.Size(144, 14);
            this.l_descNivelAtividade.TabIndex = 30;
            this.l_descNivelAtividade.Text = "Descrição Nivel Atividade";
            // 
            // gr_atividade_fisica
            // 
            this.gr_atividade_fisica.Controls.Add(this.l_frequencia);
            this.gr_atividade_fisica.Controls.Add(this.l_met);
            this.gr_atividade_fisica.Controls.Add(this.cb_QntAtividade);
            this.gr_atividade_fisica.Controls.Add(this.txt_frequencia);
            this.gr_atividade_fisica.Controls.Add(this.dt_tempo);
            this.gr_atividade_fisica.Controls.Add(this.bt_adicionarItemAtividade);
            this.gr_atividade_fisica.Controls.Add(this.label9);
            this.gr_atividade_fisica.Controls.Add(this.label8);
            this.gr_atividade_fisica.Controls.Add(this.label7);
            this.gr_atividade_fisica.Controls.Add(this.cb_AtvFisica);
            this.gr_atividade_fisica.Location = new System.Drawing.Point(7, 151);
            this.gr_atividade_fisica.Name = "gr_atividade_fisica";
            this.gr_atividade_fisica.Size = new System.Drawing.Size(358, 125);
            this.gr_atividade_fisica.TabIndex = 29;
            this.gr_atividade_fisica.TabStop = false;
            this.gr_atividade_fisica.Text = "Atividade Fisica:";
            // 
            // l_frequencia
            // 
            this.l_frequencia.AutoSize = true;
            this.l_frequencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_frequencia.Location = new System.Drawing.Point(298, 100);
            this.l_frequencia.Name = "l_frequencia";
            this.l_frequencia.Size = new System.Drawing.Size(26, 14);
            this.l_frequencia.TabIndex = 15;
            this.l_frequencia.Text = "Qnt";
            // 
            // l_met
            // 
            this.l_met.AutoSize = true;
            this.l_met.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_met.Location = new System.Drawing.Point(114, 22);
            this.l_met.Name = "l_met";
            this.l_met.Size = new System.Drawing.Size(30, 14);
            this.l_met.TabIndex = 14;
            this.l_met.Text = "MET";
            // 
            // cb_QntAtividade
            // 
            this.cb_QntAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QntAtividade.FormattingEnabled = true;
            this.cb_QntAtividade.Items.AddRange(new object[] {
            "Dia",
            "Semana",
            "Mês"});
            this.cb_QntAtividade.Location = new System.Drawing.Point(173, 96);
            this.cb_QntAtividade.Name = "cb_QntAtividade";
            this.cb_QntAtividade.Size = new System.Drawing.Size(119, 21);
            this.cb_QntAtividade.TabIndex = 13;
            this.cb_QntAtividade.SelectedIndexChanged += new System.EventHandler(this.cb_QntAtividade_SelectedIndexChanged);
            // 
            // txt_frequencia
            // 
            this.txt_frequencia.Location = new System.Drawing.Point(86, 97);
            this.txt_frequencia.Name = "txt_frequencia";
            this.txt_frequencia.Size = new System.Drawing.Size(71, 20);
            this.txt_frequencia.TabIndex = 12;
            // 
            // dt_tempo
            // 
            this.dt_tempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_tempo.Location = new System.Drawing.Point(86, 66);
            this.dt_tempo.Name = "dt_tempo";
            this.dt_tempo.Size = new System.Drawing.Size(71, 20);
            this.dt_tempo.TabIndex = 11;
            this.dt_tempo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dt_tempo_KeyDown);
            this.dt_tempo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dt_tempo_MouseDown);
            // 
            // bt_adicionarItemAtividade
            // 
            this.bt_adicionarItemAtividade.Image = global::NutricionalApp.Properties.Resources.Add_16;
            this.bt_adicionarItemAtividade.Location = new System.Drawing.Point(300, 38);
            this.bt_adicionarItemAtividade.Name = "bt_adicionarItemAtividade";
            this.bt_adicionarItemAtividade.Size = new System.Drawing.Size(47, 51);
            this.bt_adicionarItemAtividade.TabIndex = 10;
            this.bt_adicionarItemAtividade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_adicionarItemAtividade.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Frequencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Duração:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo de Atividade:";
            // 
            // cb_AtvFisica
            // 
            this.cb_AtvFisica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_AtvFisica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_AtvFisica.FormattingEnabled = true;
            this.cb_AtvFisica.Location = new System.Drawing.Point(13, 38);
            this.cb_AtvFisica.Name = "cb_AtvFisica";
            this.cb_AtvFisica.Size = new System.Drawing.Size(283, 21);
            this.cb_AtvFisica.TabIndex = 2;
            this.cb_AtvFisica.SelectedIndexChanged += new System.EventHandler(this.cb_AtvFisica_SelectedIndexChanged);
            // 
            // cb_NivelAtv
            // 
            this.cb_NivelAtv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NivelAtv.FormattingEnabled = true;
            this.cb_NivelAtv.Location = new System.Drawing.Point(7, 88);
            this.cb_NivelAtv.Name = "cb_NivelAtv";
            this.cb_NivelAtv.Size = new System.Drawing.Size(358, 21);
            this.cb_NivelAtv.TabIndex = 28;
            this.cb_NivelAtv.SelectedIndexChanged += new System.EventHandler(this.cb_NivelAtv_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nivel Atividade:";
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(85, 38);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(73, 20);
            this.txt_Altura.TabIndex = 26;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(6, 38);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(73, 20);
            this.txt_Peso.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Peso:";
            // 
            // bt_EditarGasto
            // 
            this.bt_EditarGasto.Enabled = false;
            this.bt_EditarGasto.Image = global::NutricionalApp.Properties.Resources.Edit_Text_File_16;
            this.bt_EditarGasto.Location = new System.Drawing.Point(311, 100);
            this.bt_EditarGasto.Name = "bt_EditarGasto";
            this.bt_EditarGasto.Size = new System.Drawing.Size(65, 30);
            this.bt_EditarGasto.TabIndex = 19;
            this.bt_EditarGasto.Text = "Editar";
            this.bt_EditarGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EditarGasto.UseVisualStyleBackColor = true;
            this.bt_EditarGasto.Click += new System.EventHandler(this.bt_EditarRec_Click);
            // 
            // bt_adicionarGasto
            // 
            this.bt_adicionarGasto.Image = global::NutricionalApp.Properties.Resources.Add_File_16px;
            this.bt_adicionarGasto.Location = new System.Drawing.Point(691, 81);
            this.bt_adicionarGasto.Name = "bt_adicionarGasto";
            this.bt_adicionarGasto.Size = new System.Drawing.Size(65, 30);
            this.bt_adicionarGasto.TabIndex = 17;
            this.bt_adicionarGasto.Text = "Novo";
            this.bt_adicionarGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_adicionarGasto.UseVisualStyleBackColor = true;
            this.bt_adicionarGasto.Click += new System.EventHandler(this.bt_adicionarRec_Click);
            // 
            // l_idade
            // 
            this.l_idade.AutoSize = true;
            this.l_idade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_idade.Location = new System.Drawing.Point(260, 15);
            this.l_idade.Name = "l_idade";
            this.l_idade.Size = new System.Drawing.Size(37, 14);
            this.l_idade.TabIndex = 38;
            this.l_idade.Text = "idade";
            // 
            // l_sexo
            // 
            this.l_sexo.AutoSize = true;
            this.l_sexo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_sexo.Location = new System.Drawing.Point(342, 15);
            this.l_sexo.Name = "l_sexo";
            this.l_sexo.Size = new System.Drawing.Size(34, 14);
            this.l_sexo.TabIndex = 39;
            this.l_sexo.Text = "sexo";
            // 
            // CadGastosEnergeticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.l_sexo);
            this.Controls.Add(this.l_idade);
            this.Controls.Add(this.gr_ExibeDados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_EditarGasto);
            this.Controls.Add(this.txt_DescricaoNome);
            this.Controls.Add(this.bt_adicionarGasto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Gastoenergico);
            this.Controls.Add(this.cb_Pacientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadGastosEnergeticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadGastosEnergeticos_Load);
            this.gr_ExibeDados.ResumeLayout(false);
            this.gr_ExibeDados.PerformLayout();
            this.gr_VET.ResumeLayout(false);
            this.gr_VET.PerformLayout();
            this.gr_GEB.ResumeLayout(false);
            this.gr_GEB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gr_atividade_fisica.ResumeLayout(false);
            this.gr_atividade_fisica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Pacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Gastoenergico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_EditarGasto;
        private System.Windows.Forms.TextBox txt_DescricaoNome;
        private System.Windows.Forms.Button bt_adicionarGasto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gr_ExibeDados;
        private System.Windows.Forms.Label l_descNivelAtividade;
        private System.Windows.Forms.GroupBox gr_atividade_fisica;
        private System.Windows.Forms.Label l_met;
        private System.Windows.Forms.ComboBox cb_QntAtividade;
        private System.Windows.Forms.TextBox txt_frequencia;
        private System.Windows.Forms.DateTimePicker dt_tempo;
        private System.Windows.Forms.Button bt_adicionarItemAtividade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_AtvFisica;
        private System.Windows.Forms.ComboBox cb_NivelAtv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_AlturaDesejada;
        private System.Windows.Forms.TextBox txt_PesoDesejado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Label l_frequencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_Protocolo;
        private System.Windows.Forms.Label l_ResultVenta;
        private System.Windows.Forms.GroupBox gr_VET;
        private System.Windows.Forms.GroupBox gr_GEB;
        private System.Windows.Forms.Label VET;
        private System.Windows.Forms.Label GEB;
        private System.Windows.Forms.Label l_idade;
        private System.Windows.Forms.Label l_sexo;
    }
}