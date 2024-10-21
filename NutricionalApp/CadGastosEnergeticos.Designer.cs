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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadGastosEnergeticos));
            this.cb_Pacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Gastoenergico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DescricaoNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gr_ExibeDados = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_validar = new System.Windows.Forms.Button();
            this.l_obsMassaMagra = new System.Windows.Forms.Label();
            this.l_MassaMagra = new System.Windows.Forms.Label();
            this.txt_massa_magra = new System.Windows.Forms.TextBox();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.gr_VET = new System.Windows.Forms.GroupBox();
            this.VET = new System.Windows.Forms.Label();
            this.gr_GEB = new System.Windows.Forms.GroupBox();
            this.GEB = new System.Windows.Forms.Label();
            this.cb_Protocolo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.l_descNivelAtividade = new System.Windows.Forms.Label();
            this.gr_atividade_fisica = new System.Windows.Forms.GroupBox();
            this.bt_ExcluirAtv = new System.Windows.Forms.Button();
            this.l_Calorias = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gr_VENTA = new System.Windows.Forms.GroupBox();
            this.VENTA = new System.Windows.Forms.Label();
            this.txt_DiasVenta = new System.Windows.Forms.TextBox();
            this.txt_PesoDesejado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nutricionalDB = new NutricionalApp.NutricionalDB();
            this.l_idade = new System.Windows.Forms.Label();
            this.l_sexo = new System.Windows.Forms.Label();
            this.bt_EditarGasto = new System.Windows.Forms.Button();
            this.bt_adicionarGasto = new System.Windows.Forms.Button();
            this.bt_SalvarPDF = new System.Windows.Forms.Button();
            this.gr_ExibeDados.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gr_VET.SuspendLayout();
            this.gr_GEB.SuspendLayout();
            this.gr_atividade_fisica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gr_VENTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).BeginInit();
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
            this.label5.Text = "Gastos Energéticos do Paciente:";
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
            this.label6.Text = "Novo Gasto Energético:";
            // 
            // gr_ExibeDados
            // 
            this.gr_ExibeDados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_ExibeDados.Controls.Add(this.groupBox3);
            this.gr_ExibeDados.Controls.Add(this.groupBox2);
            this.gr_ExibeDados.Controls.Add(this.groupBox1);
            this.gr_ExibeDados.Location = new System.Drawing.Point(22, 136);
            this.gr_ExibeDados.Name = "gr_ExibeDados";
            this.gr_ExibeDados.Size = new System.Drawing.Size(754, 497);
            this.gr_ExibeDados.TabIndex = 21;
            this.gr_ExibeDados.TabStop = false;
            this.gr_ExibeDados.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Altura);
            this.groupBox3.Controls.Add(this.txt_Peso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 82);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sobre o Paciente:";
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(126, 44);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(73, 20);
            this.txt_Altura.TabIndex = 30;
            this.txt_Altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Altura_KeyPress);
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(32, 44);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(73, 20);
            this.txt_Peso.TabIndex = 29;
            this.txt_Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Peso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Altura Atual (m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Peso Atual (Kg):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_SalvarPDF);
            this.groupBox2.Controls.Add(this.bt_validar);
            this.groupBox2.Controls.Add(this.l_obsMassaMagra);
            this.groupBox2.Controls.Add(this.l_MassaMagra);
            this.groupBox2.Controls.Add(this.txt_massa_magra);
            this.groupBox2.Controls.Add(this.bt_Salvar);
            this.groupBox2.Controls.Add(this.gr_VET);
            this.groupBox2.Controls.Add(this.gr_GEB);
            this.groupBox2.Controls.Add(this.cb_Protocolo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.l_descNivelAtividade);
            this.groupBox2.Controls.Add(this.gr_atividade_fisica);
            this.groupBox2.Controls.Add(this.cb_NivelAtv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 382);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gasto Energético:";
            // 
            // bt_validar
            // 
            this.bt_validar.Image = global::NutricionalApp.Properties.Resources.Calculator_48;
            this.bt_validar.Location = new System.Drawing.Point(659, 112);
            this.bt_validar.Name = "bt_validar";
            this.bt_validar.Size = new System.Drawing.Size(75, 84);
            this.bt_validar.TabIndex = 48;
            this.bt_validar.Text = "Calcular";
            this.bt_validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_validar.UseVisualStyleBackColor = true;
            this.bt_validar.Click += new System.EventHandler(this.bt_validar_Click);
            // 
            // l_obsMassaMagra
            // 
            this.l_obsMassaMagra.AutoSize = true;
            this.l_obsMassaMagra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_obsMassaMagra.Location = new System.Drawing.Point(395, 126);
            this.l_obsMassaMagra.Name = "l_obsMassaMagra";
            this.l_obsMassaMagra.Size = new System.Drawing.Size(229, 26);
            this.l_obsMassaMagra.TabIndex = 47;
            this.l_obsMassaMagra.Text = "Obs: O protocolo selecionado \r\nexige o preenchmento da Massa Magra";
            this.l_obsMassaMagra.Visible = false;
            // 
            // l_MassaMagra
            // 
            this.l_MassaMagra.AutoSize = true;
            this.l_MassaMagra.Location = new System.Drawing.Point(395, 102);
            this.l_MassaMagra.Name = "l_MassaMagra";
            this.l_MassaMagra.Size = new System.Drawing.Size(100, 13);
            this.l_MassaMagra.TabIndex = 16;
            this.l_MassaMagra.Text = "*Massa Magra (Kg):\r\n";
            this.l_MassaMagra.Visible = false;
            // 
            // txt_massa_magra
            // 
            this.txt_massa_magra.Location = new System.Drawing.Point(501, 99);
            this.txt_massa_magra.Name = "txt_massa_magra";
            this.txt_massa_magra.Size = new System.Drawing.Size(71, 20);
            this.txt_massa_magra.TabIndex = 46;
            this.txt_massa_magra.Visible = false;
            this.txt_massa_magra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_massa_magra_KeyPress);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Enabled = false;
            this.bt_Salvar.Image = global::NutricionalApp.Properties.Resources.Save_48;
            this.bt_Salvar.Location = new System.Drawing.Point(659, 286);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 84);
            this.bt_Salvar.TabIndex = 45;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // gr_VET
            // 
            this.gr_VET.BackColor = System.Drawing.Color.GhostWhite;
            this.gr_VET.Controls.Add(this.VET);
            this.gr_VET.Location = new System.Drawing.Point(202, 90);
            this.gr_VET.Name = "gr_VET";
            this.gr_VET.Size = new System.Drawing.Size(187, 59);
            this.gr_VET.TabIndex = 44;
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
            this.gr_GEB.Location = new System.Drawing.Point(9, 90);
            this.gr_GEB.Name = "gr_GEB";
            this.gr_GEB.Size = new System.Drawing.Size(187, 59);
            this.gr_GEB.TabIndex = 43;
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
            this.cb_Protocolo.Location = new System.Drawing.Point(377, 36);
            this.cb_Protocolo.Name = "cb_Protocolo";
            this.cb_Protocolo.Size = new System.Drawing.Size(350, 21);
            this.cb_Protocolo.TabIndex = 42;
            this.cb_Protocolo.SelectedIndexChanged += new System.EventHandler(this.cb_Protocolo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Protocolo:";
            // 
            // l_descNivelAtividade
            // 
            this.l_descNivelAtividade.AutoSize = true;
            this.l_descNivelAtividade.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_descNivelAtividade.Location = new System.Drawing.Point(6, 60);
            this.l_descNivelAtividade.Name = "l_descNivelAtividade";
            this.l_descNivelAtividade.Size = new System.Drawing.Size(144, 14);
            this.l_descNivelAtividade.TabIndex = 40;
            this.l_descNivelAtividade.Text = "Descrição Nivel Atividade";
            // 
            // gr_atividade_fisica
            // 
            this.gr_atividade_fisica.Controls.Add(this.bt_ExcluirAtv);
            this.gr_atividade_fisica.Controls.Add(this.l_Calorias);
            this.gr_atividade_fisica.Controls.Add(this.dataGridView1);
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
            this.gr_atividade_fisica.Location = new System.Drawing.Point(9, 155);
            this.gr_atividade_fisica.Name = "gr_atividade_fisica";
            this.gr_atividade_fisica.Size = new System.Drawing.Size(642, 217);
            this.gr_atividade_fisica.TabIndex = 39;
            this.gr_atividade_fisica.TabStop = false;
            this.gr_atividade_fisica.Text = "Atividade Fisica:";
            // 
            // bt_ExcluirAtv
            // 
            this.bt_ExcluirAtv.Enabled = false;
            this.bt_ExcluirAtv.Image = global::NutricionalApp.Properties.Resources.Delete_16;
            this.bt_ExcluirAtv.Location = new System.Drawing.Point(540, 19);
            this.bt_ExcluirAtv.Name = "bt_ExcluirAtv";
            this.bt_ExcluirAtv.Size = new System.Drawing.Size(45, 40);
            this.bt_ExcluirAtv.TabIndex = 18;
            this.bt_ExcluirAtv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_ExcluirAtv.UseVisualStyleBackColor = true;
            this.bt_ExcluirAtv.Click += new System.EventHandler(this.bt_ExcluirAtv_Click);
            // 
            // l_Calorias
            // 
            this.l_Calorias.AutoSize = true;
            this.l_Calorias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Calorias.Location = new System.Drawing.Point(328, 41);
            this.l_Calorias.Name = "l_Calorias";
            this.l_Calorias.Size = new System.Drawing.Size(52, 14);
            this.l_Calorias.TabIndex = 17;
            this.l_Calorias.Text = "Calorias";
            this.l_Calorias.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 119);
            this.dataGridView1.TabIndex = 16;
            // 
            // l_frequencia
            // 
            this.l_frequencia.AutoSize = true;
            this.l_frequencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_frequencia.Location = new System.Drawing.Point(456, 69);
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
            "Semana"});
            this.cb_QntAtividade.Location = new System.Drawing.Point(331, 65);
            this.cb_QntAtividade.Name = "cb_QntAtividade";
            this.cb_QntAtividade.Size = new System.Drawing.Size(119, 21);
            this.cb_QntAtividade.TabIndex = 13;
            this.cb_QntAtividade.SelectedIndexChanged += new System.EventHandler(this.cb_QntAtividade_SelectedIndexChanged);
            // 
            // txt_frequencia
            // 
            this.txt_frequencia.Location = new System.Drawing.Point(244, 66);
            this.txt_frequencia.Name = "txt_frequencia";
            this.txt_frequencia.Size = new System.Drawing.Size(71, 20);
            this.txt_frequencia.TabIndex = 12;
            this.txt_frequencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_frequencia_KeyPress);
            // 
            // dt_tempo
            // 
            this.dt_tempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_tempo.Location = new System.Drawing.Point(94, 65);
            this.dt_tempo.Name = "dt_tempo";
            this.dt_tempo.Size = new System.Drawing.Size(71, 20);
            this.dt_tempo.TabIndex = 11;
            this.dt_tempo.Value = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            // 
            // bt_adicionarItemAtividade
            // 
            this.bt_adicionarItemAtividade.Enabled = false;
            this.bt_adicionarItemAtividade.Image = global::NutricionalApp.Properties.Resources.Add_16;
            this.bt_adicionarItemAtividade.Location = new System.Drawing.Point(591, 19);
            this.bt_adicionarItemAtividade.Name = "bt_adicionarItemAtividade";
            this.bt_adicionarItemAtividade.Size = new System.Drawing.Size(45, 40);
            this.bt_adicionarItemAtividade.TabIndex = 10;
            this.bt_adicionarItemAtividade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_adicionarItemAtividade.UseVisualStyleBackColor = true;
            this.bt_adicionarItemAtividade.Click += new System.EventHandler(this.bt_adicionarItemAtividade_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 69);
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
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Duração (min):";
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
            this.cb_AtvFisica.Size = new System.Drawing.Size(302, 21);
            this.cb_AtvFisica.TabIndex = 2;
            this.cb_AtvFisica.SelectedIndexChanged += new System.EventHandler(this.cb_AtvFisica_SelectedIndexChanged);
            // 
            // cb_NivelAtv
            // 
            this.cb_NivelAtv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NivelAtv.FormattingEnabled = true;
            this.cb_NivelAtv.Location = new System.Drawing.Point(6, 36);
            this.cb_NivelAtv.Name = "cb_NivelAtv";
            this.cb_NivelAtv.Size = new System.Drawing.Size(358, 21);
            this.cb_NivelAtv.TabIndex = 38;
            this.cb_NivelAtv.SelectedIndexChanged += new System.EventHandler(this.cb_NivelAtv_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nivel Atividade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gr_VENTA);
            this.groupBox1.Controls.Add(this.txt_DiasVenta);
            this.groupBox1.Controls.Add(this.txt_PesoDesejado);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(273, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 82);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENTA:";
            // 
            // gr_VENTA
            // 
            this.gr_VENTA.BackColor = System.Drawing.Color.GhostWhite;
            this.gr_VENTA.Controls.Add(this.VENTA);
            this.gr_VENTA.Location = new System.Drawing.Point(186, 11);
            this.gr_VENTA.Name = "gr_VENTA";
            this.gr_VENTA.Size = new System.Drawing.Size(278, 59);
            this.gr_VENTA.TabIndex = 38;
            this.gr_VENTA.TabStop = false;
            this.gr_VENTA.Text = "Resultado:";
            this.gr_VENTA.Visible = false;
            // 
            // VENTA
            // 
            this.VENTA.AutoSize = true;
            this.VENTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VENTA.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VENTA.Location = new System.Drawing.Point(3, 16);
            this.VENTA.Name = "VENTA";
            this.VENTA.Size = new System.Drawing.Size(94, 37);
            this.VENTA.TabIndex = 1;
            this.VENTA.Text = "VENTA";
            // 
            // txt_DiasVenta
            // 
            this.txt_DiasVenta.Location = new System.Drawing.Point(110, 46);
            this.txt_DiasVenta.Name = "txt_DiasVenta";
            this.txt_DiasVenta.Size = new System.Drawing.Size(73, 20);
            this.txt_DiasVenta.TabIndex = 14;
            this.txt_DiasVenta.TextChanged += new System.EventHandler(this.txt_DiasVenta_TextChanged);
            this.txt_DiasVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiasVenta_KeyPress);
            // 
            // txt_PesoDesejado
            // 
            this.txt_PesoDesejado.Location = new System.Drawing.Point(110, 20);
            this.txt_PesoDesejado.Name = "txt_PesoDesejado";
            this.txt_PesoDesejado.Size = new System.Drawing.Size(73, 20);
            this.txt_PesoDesejado.TabIndex = 13;
            this.txt_PesoDesejado.TextChanged += new System.EventHandler(this.txt_DiasVenta_TextChanged);
            this.txt_PesoDesejado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PesoDesejado_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tempo (em dias):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Peso Desejado (kg):";
            // 
            // nutricionalDB
            // 
            this.nutricionalDB.DataSetName = "NutricionalDB";
            this.nutricionalDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bt_SalvarPDF
            // 
            this.bt_SalvarPDF.Enabled = false;
            this.bt_SalvarPDF.Image = global::NutricionalApp.Properties.Resources.PDF_48;
            this.bt_SalvarPDF.Location = new System.Drawing.Point(659, 199);
            this.bt_SalvarPDF.Name = "bt_SalvarPDF";
            this.bt_SalvarPDF.Size = new System.Drawing.Size(75, 84);
            this.bt_SalvarPDF.TabIndex = 49;
            this.bt_SalvarPDF.Text = "Salvar PDF";
            this.bt_SalvarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_SalvarPDF.UseVisualStyleBackColor = true;
            this.bt_SalvarPDF.Click += new System.EventHandler(this.bt_SalvarPDF_Click);
            // 
            // CadGastosEnergeticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 645);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadGastosEnergeticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos Energéticos";
            this.Load += new System.EventHandler(this.CadGastosEnergeticos_Load);
            this.gr_ExibeDados.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gr_VET.ResumeLayout(false);
            this.gr_VET.PerformLayout();
            this.gr_GEB.ResumeLayout(false);
            this.gr_GEB.PerformLayout();
            this.gr_atividade_fisica.ResumeLayout(false);
            this.gr_atividade_fisica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gr_VENTA.ResumeLayout(false);
            this.gr_VENTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_DiasVenta;
        private System.Windows.Forms.TextBox txt_PesoDesejado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_idade;
        private System.Windows.Forms.Label l_sexo;
        private System.Windows.Forms.GroupBox gr_VENTA;
        private System.Windows.Forms.Label VENTA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gr_VET;
        private System.Windows.Forms.Label VET;
        private System.Windows.Forms.GroupBox gr_GEB;
        private System.Windows.Forms.Label GEB;
        private System.Windows.Forms.ComboBox cb_Protocolo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l_descNivelAtividade;
        private System.Windows.Forms.GroupBox gr_atividade_fisica;
        private System.Windows.Forms.Label l_frequencia;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Salvar;
        private NutricionalDB nutricionalDB;
        private System.Windows.Forms.Label l_MassaMagra;
        private System.Windows.Forms.TextBox txt_massa_magra;
        private System.Windows.Forms.Label l_obsMassaMagra;
        private System.Windows.Forms.Button bt_validar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_Calorias;
        private System.Windows.Forms.Button bt_ExcluirAtv;
        private System.Windows.Forms.Button bt_SalvarPDF;
    }
}