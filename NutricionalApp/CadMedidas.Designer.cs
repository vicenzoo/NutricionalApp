namespace NutricionalApp
{
    partial class CadMedidas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gr_PropriedadesGrupo = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nutricionalDB = new NutricionalApp.NutricionalDB();
            this.txt_medidaCaseira = new System.Windows.Forms.TextBox();
            this.txt_gramas = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Grupos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_EditarRec = new System.Windows.Forms.Button();
            this.bt_adicionarMedida = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabelataco4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabela_taco4TableAdapter = new NutricionalApp.NutricionalDBTableAdapters.tabela_taco4TableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_BuscaTaco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiakcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiakjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lipideosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colesterolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fibraalimentarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinzasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magnesioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manganesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fosforoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ferroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potassioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zincoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retinolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiaminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riboflavinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piridoxinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niacinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitaminacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carboidratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gr_PropriedadesGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelataco4BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 506);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.gr_PropriedadesGrupo);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(768, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medidas Caseiras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gr_PropriedadesGrupo
            // 
            this.gr_PropriedadesGrupo.Controls.Add(this.label4);
            this.gr_PropriedadesGrupo.Controls.Add(this.cb_Grupos);
            this.gr_PropriedadesGrupo.Controls.Add(this.bt_EditarRec);
            this.gr_PropriedadesGrupo.Controls.Add(this.bt_adicionarMedida);
            this.gr_PropriedadesGrupo.Controls.Add(this.label3);
            this.gr_PropriedadesGrupo.Controls.Add(this.label2);
            this.gr_PropriedadesGrupo.Controls.Add(this.label1);
            this.gr_PropriedadesGrupo.Controls.Add(this.txt_id);
            this.gr_PropriedadesGrupo.Controls.Add(this.txt_gramas);
            this.gr_PropriedadesGrupo.Controls.Add(this.txt_medidaCaseira);
            this.gr_PropriedadesGrupo.Location = new System.Drawing.Point(3, 379);
            this.gr_PropriedadesGrupo.Name = "gr_PropriedadesGrupo";
            this.gr_PropriedadesGrupo.Size = new System.Drawing.Size(762, 89);
            this.gr_PropriedadesGrupo.TabIndex = 2;
            this.gr_PropriedadesGrupo.TabStop = false;
            this.gr_PropriedadesGrupo.Text = "Propriedades do grupo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nutricionalDB
            // 
            this.nutricionalDB.DataSetName = "NutricionalDB";
            this.nutricionalDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_medidaCaseira
            // 
            this.txt_medidaCaseira.Location = new System.Drawing.Point(329, 48);
            this.txt_medidaCaseira.Name = "txt_medidaCaseira";
            this.txt_medidaCaseira.Size = new System.Drawing.Size(219, 20);
            this.txt_medidaCaseira.TabIndex = 0;
            // 
            // txt_gramas
            // 
            this.txt_gramas.Location = new System.Drawing.Point(554, 48);
            this.txt_gramas.Name = "txt_gramas";
            this.txt_gramas.Size = new System.Drawing.Size(67, 20);
            this.txt_gramas.TabIndex = 1;
            this.txt_gramas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gramas_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(22, 48);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(79, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medida Caseira:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gramagem:";
            // 
            // cb_Grupos
            // 
            this.cb_Grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Grupos.FormattingEnabled = true;
            this.cb_Grupos.Location = new System.Drawing.Point(107, 47);
            this.cb_Grupos.Name = "cb_Grupos";
            this.cb_Grupos.Size = new System.Drawing.Size(216, 21);
            this.cb_Grupos.TabIndex = 14;
            this.cb_Grupos.SelectedIndexChanged += new System.EventHandler(this.cb_Grupos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Grupo:";
            // 
            // bt_EditarRec
            // 
            this.bt_EditarRec.Image = global::NutricionalApp.Properties.Resources.Edit_Text_File_16;
            this.bt_EditarRec.Location = new System.Drawing.Point(681, 53);
            this.bt_EditarRec.Name = "bt_EditarRec";
            this.bt_EditarRec.Size = new System.Drawing.Size(75, 30);
            this.bt_EditarRec.TabIndex = 13;
            this.bt_EditarRec.Text = "Editar";
            this.bt_EditarRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EditarRec.UseVisualStyleBackColor = true;
            this.bt_EditarRec.Click += new System.EventHandler(this.bt_EditarRec_Click);
            // 
            // bt_adicionarMedida
            // 
            this.bt_adicionarMedida.Image = global::NutricionalApp.Properties.Resources.Add_File_16px;
            this.bt_adicionarMedida.Location = new System.Drawing.Point(681, 19);
            this.bt_adicionarMedida.Name = "bt_adicionarMedida";
            this.bt_adicionarMedida.Size = new System.Drawing.Size(75, 30);
            this.bt_adicionarMedida.TabIndex = 12;
            this.bt_adicionarMedida.Text = "Novo";
            this.bt_adicionarMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_adicionarMedida.UseVisualStyleBackColor = true;
            this.bt_adicionarMedida.Click += new System.EventHandler(this.bt_adicionarMedida_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(768, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TACO Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.grupoDataGridViewTextBoxColumn,
            this.umidadeDataGridViewTextBoxColumn,
            this.energiakcalDataGridViewTextBoxColumn,
            this.energiakjDataGridViewTextBoxColumn,
            this.proteinaDataGridViewTextBoxColumn,
            this.lipideosDataGridViewTextBoxColumn,
            this.colesterolDataGridViewTextBoxColumn,
            this.fibraalimentarDataGridViewTextBoxColumn,
            this.cinzasDataGridViewTextBoxColumn,
            this.calcioDataGridViewTextBoxColumn,
            this.magnesioDataGridViewTextBoxColumn,
            this.manganesDataGridViewTextBoxColumn,
            this.fosforoDataGridViewTextBoxColumn,
            this.ferroDataGridViewTextBoxColumn,
            this.sodioDataGridViewTextBoxColumn,
            this.potassioDataGridViewTextBoxColumn,
            this.cobreDataGridViewTextBoxColumn,
            this.zincoDataGridViewTextBoxColumn,
            this.retinolDataGridViewTextBoxColumn,
            this.reDataGridViewTextBoxColumn,
            this.raeDataGridViewTextBoxColumn,
            this.tiaminaDataGridViewTextBoxColumn,
            this.riboflavinaDataGridViewTextBoxColumn,
            this.piridoxinaDataGridViewTextBoxColumn,
            this.niacinaDataGridViewTextBoxColumn,
            this.vitaminacDataGridViewTextBoxColumn,
            this.carboidratoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tabelataco4BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 40;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(768, 356);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabelataco4BindingSource
            // 
            this.tabelataco4BindingSource.DataMember = "tabela_taco4";
            this.tabelataco4BindingSource.DataSource = this.nutricionalDB;
            // 
            // tabela_taco4TableAdapter
            // 
            this.tabela_taco4TableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_BuscaTaco);
            this.groupBox1.Location = new System.Drawing.Point(3, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // txt_BuscaTaco
            // 
            this.txt_BuscaTaco.Location = new System.Drawing.Point(15, 41);
            this.txt_BuscaTaco.Name = "txt_BuscaTaco";
            this.txt_BuscaTaco.Size = new System.Drawing.Size(253, 20);
            this.txt_BuscaTaco.TabIndex = 0;
            this.txt_BuscaTaco.TextChanged += new System.EventHandler(this.txt_BuscaTaco_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = global::NutricionalApp.Properties.Resources.Search_16px;
            this.button1.Location = new System.Drawing.Point(274, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.txt_BuscaTaco_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descrição:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupoDataGridViewTextBoxColumn.Width = 250;
            // 
            // umidadeDataGridViewTextBoxColumn
            // 
            this.umidadeDataGridViewTextBoxColumn.DataPropertyName = "umidade";
            this.umidadeDataGridViewTextBoxColumn.HeaderText = "umidade";
            this.umidadeDataGridViewTextBoxColumn.Name = "umidadeDataGridViewTextBoxColumn";
            this.umidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // energiakcalDataGridViewTextBoxColumn
            // 
            this.energiakcalDataGridViewTextBoxColumn.DataPropertyName = "energia_kcal";
            this.energiakcalDataGridViewTextBoxColumn.HeaderText = "energia_kcal";
            this.energiakcalDataGridViewTextBoxColumn.Name = "energiakcalDataGridViewTextBoxColumn";
            this.energiakcalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // energiakjDataGridViewTextBoxColumn
            // 
            this.energiakjDataGridViewTextBoxColumn.DataPropertyName = "energia_kj";
            this.energiakjDataGridViewTextBoxColumn.HeaderText = "energia_kj";
            this.energiakjDataGridViewTextBoxColumn.Name = "energiakjDataGridViewTextBoxColumn";
            this.energiakjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proteinaDataGridViewTextBoxColumn
            // 
            this.proteinaDataGridViewTextBoxColumn.DataPropertyName = "proteina";
            this.proteinaDataGridViewTextBoxColumn.HeaderText = "proteina";
            this.proteinaDataGridViewTextBoxColumn.Name = "proteinaDataGridViewTextBoxColumn";
            this.proteinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lipideosDataGridViewTextBoxColumn
            // 
            this.lipideosDataGridViewTextBoxColumn.DataPropertyName = "lipideos";
            this.lipideosDataGridViewTextBoxColumn.HeaderText = "lipideos";
            this.lipideosDataGridViewTextBoxColumn.Name = "lipideosDataGridViewTextBoxColumn";
            this.lipideosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colesterolDataGridViewTextBoxColumn
            // 
            this.colesterolDataGridViewTextBoxColumn.DataPropertyName = "colesterol";
            this.colesterolDataGridViewTextBoxColumn.HeaderText = "colesterol";
            this.colesterolDataGridViewTextBoxColumn.Name = "colesterolDataGridViewTextBoxColumn";
            this.colesterolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fibraalimentarDataGridViewTextBoxColumn
            // 
            this.fibraalimentarDataGridViewTextBoxColumn.DataPropertyName = "fibra_alimentar";
            this.fibraalimentarDataGridViewTextBoxColumn.HeaderText = "fibra_alimentar";
            this.fibraalimentarDataGridViewTextBoxColumn.Name = "fibraalimentarDataGridViewTextBoxColumn";
            this.fibraalimentarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinzasDataGridViewTextBoxColumn
            // 
            this.cinzasDataGridViewTextBoxColumn.DataPropertyName = "cinzas";
            this.cinzasDataGridViewTextBoxColumn.HeaderText = "cinzas";
            this.cinzasDataGridViewTextBoxColumn.Name = "cinzasDataGridViewTextBoxColumn";
            this.cinzasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calcioDataGridViewTextBoxColumn
            // 
            this.calcioDataGridViewTextBoxColumn.DataPropertyName = "calcio";
            this.calcioDataGridViewTextBoxColumn.HeaderText = "calcio";
            this.calcioDataGridViewTextBoxColumn.Name = "calcioDataGridViewTextBoxColumn";
            this.calcioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magnesioDataGridViewTextBoxColumn
            // 
            this.magnesioDataGridViewTextBoxColumn.DataPropertyName = "magnesio";
            this.magnesioDataGridViewTextBoxColumn.HeaderText = "magnesio";
            this.magnesioDataGridViewTextBoxColumn.Name = "magnesioDataGridViewTextBoxColumn";
            this.magnesioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manganesDataGridViewTextBoxColumn
            // 
            this.manganesDataGridViewTextBoxColumn.DataPropertyName = "manganes";
            this.manganesDataGridViewTextBoxColumn.HeaderText = "manganes";
            this.manganesDataGridViewTextBoxColumn.Name = "manganesDataGridViewTextBoxColumn";
            this.manganesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fosforoDataGridViewTextBoxColumn
            // 
            this.fosforoDataGridViewTextBoxColumn.DataPropertyName = "fosforo";
            this.fosforoDataGridViewTextBoxColumn.HeaderText = "fosforo";
            this.fosforoDataGridViewTextBoxColumn.Name = "fosforoDataGridViewTextBoxColumn";
            this.fosforoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ferroDataGridViewTextBoxColumn
            // 
            this.ferroDataGridViewTextBoxColumn.DataPropertyName = "ferro";
            this.ferroDataGridViewTextBoxColumn.HeaderText = "ferro";
            this.ferroDataGridViewTextBoxColumn.Name = "ferroDataGridViewTextBoxColumn";
            this.ferroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sodioDataGridViewTextBoxColumn
            // 
            this.sodioDataGridViewTextBoxColumn.DataPropertyName = "sodio";
            this.sodioDataGridViewTextBoxColumn.HeaderText = "sodio";
            this.sodioDataGridViewTextBoxColumn.Name = "sodioDataGridViewTextBoxColumn";
            this.sodioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potassioDataGridViewTextBoxColumn
            // 
            this.potassioDataGridViewTextBoxColumn.DataPropertyName = "potassio";
            this.potassioDataGridViewTextBoxColumn.HeaderText = "potassio";
            this.potassioDataGridViewTextBoxColumn.Name = "potassioDataGridViewTextBoxColumn";
            this.potassioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cobreDataGridViewTextBoxColumn
            // 
            this.cobreDataGridViewTextBoxColumn.DataPropertyName = "cobre";
            this.cobreDataGridViewTextBoxColumn.HeaderText = "cobre";
            this.cobreDataGridViewTextBoxColumn.Name = "cobreDataGridViewTextBoxColumn";
            this.cobreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zincoDataGridViewTextBoxColumn
            // 
            this.zincoDataGridViewTextBoxColumn.DataPropertyName = "zinco";
            this.zincoDataGridViewTextBoxColumn.HeaderText = "zinco";
            this.zincoDataGridViewTextBoxColumn.Name = "zincoDataGridViewTextBoxColumn";
            this.zincoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retinolDataGridViewTextBoxColumn
            // 
            this.retinolDataGridViewTextBoxColumn.DataPropertyName = "retinol";
            this.retinolDataGridViewTextBoxColumn.HeaderText = "retinol";
            this.retinolDataGridViewTextBoxColumn.Name = "retinolDataGridViewTextBoxColumn";
            this.retinolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reDataGridViewTextBoxColumn
            // 
            this.reDataGridViewTextBoxColumn.DataPropertyName = "re";
            this.reDataGridViewTextBoxColumn.HeaderText = "re";
            this.reDataGridViewTextBoxColumn.Name = "reDataGridViewTextBoxColumn";
            this.reDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raeDataGridViewTextBoxColumn
            // 
            this.raeDataGridViewTextBoxColumn.DataPropertyName = "rae";
            this.raeDataGridViewTextBoxColumn.HeaderText = "rae";
            this.raeDataGridViewTextBoxColumn.Name = "raeDataGridViewTextBoxColumn";
            this.raeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiaminaDataGridViewTextBoxColumn
            // 
            this.tiaminaDataGridViewTextBoxColumn.DataPropertyName = "tiamina";
            this.tiaminaDataGridViewTextBoxColumn.HeaderText = "tiamina";
            this.tiaminaDataGridViewTextBoxColumn.Name = "tiaminaDataGridViewTextBoxColumn";
            this.tiaminaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // riboflavinaDataGridViewTextBoxColumn
            // 
            this.riboflavinaDataGridViewTextBoxColumn.DataPropertyName = "riboflavina";
            this.riboflavinaDataGridViewTextBoxColumn.HeaderText = "riboflavina";
            this.riboflavinaDataGridViewTextBoxColumn.Name = "riboflavinaDataGridViewTextBoxColumn";
            this.riboflavinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // piridoxinaDataGridViewTextBoxColumn
            // 
            this.piridoxinaDataGridViewTextBoxColumn.DataPropertyName = "piridoxina";
            this.piridoxinaDataGridViewTextBoxColumn.HeaderText = "piridoxina";
            this.piridoxinaDataGridViewTextBoxColumn.Name = "piridoxinaDataGridViewTextBoxColumn";
            this.piridoxinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // niacinaDataGridViewTextBoxColumn
            // 
            this.niacinaDataGridViewTextBoxColumn.DataPropertyName = "niacina";
            this.niacinaDataGridViewTextBoxColumn.HeaderText = "niacina";
            this.niacinaDataGridViewTextBoxColumn.Name = "niacinaDataGridViewTextBoxColumn";
            this.niacinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vitaminacDataGridViewTextBoxColumn
            // 
            this.vitaminacDataGridViewTextBoxColumn.DataPropertyName = "vitamina_c";
            this.vitaminacDataGridViewTextBoxColumn.HeaderText = "vitamina_c";
            this.vitaminacDataGridViewTextBoxColumn.Name = "vitaminacDataGridViewTextBoxColumn";
            this.vitaminacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carboidratoDataGridViewTextBoxColumn
            // 
            this.carboidratoDataGridViewTextBoxColumn.DataPropertyName = "carboidrato";
            this.carboidratoDataGridViewTextBoxColumn.HeaderText = "carboidrato";
            this.carboidratoDataGridViewTextBoxColumn.Name = "carboidratoDataGridViewTextBoxColumn";
            this.carboidratoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CadMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadMedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadMedidas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gr_PropriedadesGrupo.ResumeLayout(false);
            this.gr_PropriedadesGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelataco4BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NutricionalDB nutricionalDB;
        private System.Windows.Forms.GroupBox gr_PropriedadesGrupo;
        private System.Windows.Forms.TextBox txt_gramas;
        private System.Windows.Forms.TextBox txt_medidaCaseira;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_EditarRec;
        private System.Windows.Forms.Button bt_adicionarMedida;
        private System.Windows.Forms.ComboBox cb_Grupos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tabelataco4BindingSource;
        private NutricionalDBTableAdapters.tabela_taco4TableAdapter tabela_taco4TableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_BuscaTaco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiakcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiakjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lipideosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colesterolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fibraalimentarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinzasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magnesioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fosforoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ferroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potassioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zincoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retinolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiaminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riboflavinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piridoxinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niacinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitaminacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carboidratoDataGridViewTextBoxColumn;
    }
}