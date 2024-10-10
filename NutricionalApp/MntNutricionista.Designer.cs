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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_acessoSistema = new System.Windows.Forms.ComboBox();
            this.l_estudante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRN = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_PermitirRevogar = new System.Windows.Forms.Button();
            this.nutricionalDB = new NutricionalApp.NutricionalDB();
            this.nutricionistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutricionistaTableAdapter = new NutricionalApp.NutricionalDBTableAdapters.nutricionistaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nuticonDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Estudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Inclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Exclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionistaBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // cb_acessoSistema
            // 
            this.cb_acessoSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_acessoSistema.FormattingEnabled = true;
            this.cb_acessoSistema.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cb_acessoSistema.Location = new System.Drawing.Point(213, 85);
            this.cb_acessoSistema.Name = "cb_acessoSistema";
            this.cb_acessoSistema.Size = new System.Drawing.Size(90, 21);
            this.cb_acessoSistema.TabIndex = 11;
            // 
            // l_estudante
            // 
            this.l_estudante.AutoSize = true;
            this.l_estudante.Location = new System.Drawing.Point(373, 49);
            this.l_estudante.Name = "l_estudante";
            this.l_estudante.Size = new System.Drawing.Size(14, 13);
            this.l_estudante.TabIndex = 10;
            this.l_estudante.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estudante:";
            // 
            // txtCRN
            // 
            this.txtCRN.Location = new System.Drawing.Point(213, 47);
            this.txtCRN.Name = "txtCRN";
            this.txtCRN.Size = new System.Drawing.Size(90, 20);
            this.txtCRN.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Possui acesso ao Sistema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nutricionista:";
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
            // nutricionalDB
            // 
            this.nutricionalDB.DataSetName = "NutricionalDB";
            this.nutricionalDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nutricionistaBindingSource
            // 
            this.nutricionistaBindingSource.DataMember = "nutricionista";
            this.nutricionistaBindingSource.DataSource = this.nutricionalDB;
            // 
            // nutricionistaTableAdapter
            // 
            this.nutricionistaTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por:";
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(56, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 9;
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nutricionistaBindingSource;
            this.comboBox1.DisplayMember = "ativo";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(611, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 7;
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
            this.Estudante,
            this.CRN,
            this.Nome,
            this.Sobrenome,
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
            // MntNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MntNutricionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MntNutricionista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionistaBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_acessoSistema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewImageColumn nuticonDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Inclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Alteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Exclusao;
    }
}