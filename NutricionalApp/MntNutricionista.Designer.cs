namespace NutricionalApp
{
    partial class MntNutricionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MntNutricionista));
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_IDNutri = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_acessoSistema = new System.Windows.Forms.ComboBox();
            this.l_estudante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRN = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_PermitirRevogar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_filtroAtivo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nuticonDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_nutricionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Inclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Exclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutricionistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutricionalDB = new NutricionalApp.NutricionalDB();
            this.nutricionistaTableAdapter = new NutricionalApp.NutricionalDBTableAdapters.nutricionistaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.l_IDNutri);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSobrenome);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_acessoSistema);
            this.panel1.Controls.Add(this.l_estudante);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCRN);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_PermitirRevogar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 119);
            this.panel1.TabIndex = 0;
            // 
            // l_IDNutri
            // 
            this.l_IDNutri.AutoSize = true;
            this.l_IDNutri.Location = new System.Drawing.Point(52, 5);
            this.l_IDNutri.Name = "l_IDNutri";
            this.l_IDNutri.Size = new System.Drawing.Size(18, 13);
            this.l_IDNutri.TabIndex = 16;
            this.l_IDNutri.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(220, 21);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(245, 20);
            this.txtSobrenome.TabIndex = 14;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(55, 47);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(144, 20);
            this.txt_Email.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // cb_acessoSistema
            // 
            this.cb_acessoSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_acessoSistema.FormattingEnabled = true;
            this.cb_acessoSistema.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cb_acessoSistema.Location = new System.Drawing.Point(375, 46);
            this.cb_acessoSistema.Name = "cb_acessoSistema";
            this.cb_acessoSistema.Size = new System.Drawing.Size(90, 21);
            this.cb_acessoSistema.TabIndex = 11;
            // 
            // l_estudante
            // 
            this.l_estudante.AutoSize = true;
            this.l_estudante.Location = new System.Drawing.Point(178, 6);
            this.l_estudante.Name = "l_estudante";
            this.l_estudante.Size = new System.Drawing.Size(14, 13);
            this.l_estudante.TabIndex = 10;
            this.l_estudante.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estudante:";
            // 
            // txtCRN
            // 
            this.txtCRN.Location = new System.Drawing.Point(86, 74);
            this.txtCRN.Name = "txtCRN";
            this.txtCRN.Size = new System.Drawing.Size(113, 20);
            this.txtCRN.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Possui acesso ao Sistema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // bt_PermitirRevogar
            // 
            this.bt_PermitirRevogar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_PermitirRevogar.Image = global::NutricionalApp.Properties.Resources.What_I_Do_48;
            this.bt_PermitirRevogar.Location = new System.Drawing.Point(471, 0);
            this.bt_PermitirRevogar.Name = "bt_PermitirRevogar";
            this.bt_PermitirRevogar.Size = new System.Drawing.Size(243, 117);
            this.bt_PermitirRevogar.TabIndex = 0;
            this.bt_PermitirRevogar.Text = "Revogar / Permitir acesso ao Sistema";
            this.bt_PermitirRevogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_PermitirRevogar.UseVisualStyleBackColor = true;
            this.bt_PermitirRevogar.Click += new System.EventHandler(this.bt_PermitirRevogar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 48);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_filtroAtivo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFiltroNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por:";
            // 
            // cb_filtroAtivo
            // 
            this.cb_filtroAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtroAtivo.FormattingEnabled = true;
            this.cb_filtroAtivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cb_filtroAtivo.Location = new System.Drawing.Point(611, 18);
            this.cb_filtroAtivo.Name = "cb_filtroAtivo";
            this.cb_filtroAtivo.Size = new System.Drawing.Size(90, 21);
            this.cb_filtroAtivo.TabIndex = 12;
            this.cb_filtroAtivo.SelectedValueChanged += new System.EventHandler(this.cb_filtroAtivo_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome:";
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.Location = new System.Drawing.Point(56, 19);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(155, 20);
            this.txtFiltroNome.TabIndex = 9;
            this.txtFiltroNome.TextChanged += new System.EventHandler(this.txtFiltroNome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ativo:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 364);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nuticonDataGridViewImageColumn,
            this.Email,
            this.id_nutricionista,
            this.Estudante,
            this.CRN,
            this.Nome,
            this.Sobrenome,
            this.ativo,
            this.cpf,
            this.Data_Inclusao,
            this.Data_Alteracao,
            this.Data_Exclusao});
            this.dataGridView1.DataSource = this.nutricionistaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(716, 364);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nuticonDataGridViewImageColumn
            // 
            this.nuticonDataGridViewImageColumn.DataPropertyName = "Nut_icon";
            this.nuticonDataGridViewImageColumn.HeaderText = "Icone";
            this.nuticonDataGridViewImageColumn.Name = "nuticonDataGridViewImageColumn";
            this.nuticonDataGridViewImageColumn.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // id_nutricionista
            // 
            this.id_nutricionista.DataPropertyName = "id_nutricionista";
            this.id_nutricionista.HeaderText = "id_nutricionista";
            this.id_nutricionista.Name = "id_nutricionista";
            this.id_nutricionista.ReadOnly = true;
            this.id_nutricionista.Visible = false;
            // 
            // Estudante
            // 
            this.Estudante.DataPropertyName = "Estudante";
            this.Estudante.HeaderText = "Estudante";
            this.Estudante.Name = "Estudante";
            this.Estudante.ReadOnly = true;
            this.Estudante.Visible = false;
            // 
            // CRN
            // 
            this.CRN.DataPropertyName = "CRN";
            this.CRN.HeaderText = "CRN";
            this.CRN.Name = "CRN";
            this.CRN.ReadOnly = true;
            this.CRN.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Sobrenome
            // 
            this.Sobrenome.DataPropertyName = "Sobrenome";
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "CPF";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // Data_Inclusao
            // 
            this.Data_Inclusao.DataPropertyName = "Data_Inclusao";
            this.Data_Inclusao.HeaderText = "Data_Inclusao";
            this.Data_Inclusao.Name = "Data_Inclusao";
            this.Data_Inclusao.ReadOnly = true;
            // 
            // Data_Alteracao
            // 
            this.Data_Alteracao.DataPropertyName = "Data_Alteracao";
            this.Data_Alteracao.HeaderText = "Data_Alteracao";
            this.Data_Alteracao.Name = "Data_Alteracao";
            this.Data_Alteracao.ReadOnly = true;
            // 
            // Data_Exclusao
            // 
            this.Data_Exclusao.DataPropertyName = "Data_Exclusao";
            this.Data_Exclusao.HeaderText = "Data_Exclusao";
            this.Data_Exclusao.Name = "Data_Exclusao";
            this.Data_Exclusao.ReadOnly = true;
            // 
            // nutricionistaBindingSource
            // 
            this.nutricionistaBindingSource.DataMember = "nutricionista";
            this.nutricionistaBindingSource.DataSource = this.nutricionalDB;
            // 
            // nutricionalDB
            // 
            this.nutricionalDB.DataSetName = "NutricionalDB";
            this.nutricionalDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nutricionistaTableAdapter
            // 
            this.nutricionistaTableAdapter.ClearBeforeFill = true;
            // 
            // MntNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MntNutricionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Cadastro de Nutricionistas";
            this.Load += new System.EventHandler(this.MntNutricionista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private NutricionalDB nutricionalDB;
        private System.Windows.Forms.BindingSource nutricionistaBindingSource;
        private NutricionalDBTableAdapters.nutricionistaTableAdapter nutricionistaTableAdapter;
        private System.Windows.Forms.Button bt_PermitirRevogar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCRN;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_estudante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_acessoSistema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.DataGridViewImageColumn nuticonDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_nutricionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Inclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Alteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Exclusao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_IDNutri;
        private System.Windows.Forms.ComboBox cb_filtroAtivo;
    }
}