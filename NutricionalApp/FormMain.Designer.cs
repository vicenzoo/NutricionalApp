namespace NutricionalApp
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_idNutricionista = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.bt_Painel2Exibe = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bt_Painel1Exibe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_atualiza = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datamovimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logatividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutricionalDB = new NutricionalApp.NutricionalDB();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_atualizaGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.log_atividadesTableAdapter = new NutricionalApp.NutricionalDBTableAdapters.log_atividadesTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logatividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_Logout);
            this.panel4.Controls.Add(this.splitter4);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label_Nome);
            this.panel4.Controls.Add(this.label_idNutricionista);
            this.panel4.Controls.Add(this.splitter2);
            this.panel4.Controls.Add(this.bt_Painel2Exibe);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.splitter3);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Controls.Add(this.bt_Painel1Exibe);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1184, 50);
            this.panel4.TabIndex = 13;
            // 
            // bt_Logout
            // 
            this.bt_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Logout.FlatAppearance.BorderSize = 0;
            this.bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Logout.Image = global::NutricionalApp.Properties.Resources.Logout_24;
            this.bt_Logout.Location = new System.Drawing.Point(876, 0);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(47, 50);
            this.bt_Logout.TabIndex = 52;
            this.bt_Logout.UseVisualStyleBackColor = true;
            this.bt_Logout.Visible = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(923, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(19, 50);
            this.splitter4.TabIndex = 51;
            this.splitter4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(942, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Nome.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.ForeColor = System.Drawing.Color.White;
            this.label_Nome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Nome.Location = new System.Drawing.Point(995, 0);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(71, 28);
            this.label_Nome.TabIndex = 49;
            this.label_Nome.Text = "Nome";
            this.label_Nome.Visible = false;
            // 
            // label_idNutricionista
            // 
            this.label_idNutricionista.AutoSize = true;
            this.label_idNutricionista.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_idNutricionista.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idNutricionista.ForeColor = System.Drawing.Color.White;
            this.label_idNutricionista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_idNutricionista.Location = new System.Drawing.Point(1066, 0);
            this.label_idNutricionista.Name = "label_idNutricionista";
            this.label_idNutricionista.Size = new System.Drawing.Size(51, 21);
            this.label_idNutricionista.TabIndex = 48;
            this.label_idNutricionista.Text = "Nome";
            this.label_idNutricionista.Visible = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(1117, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(19, 50);
            this.splitter2.TabIndex = 43;
            this.splitter2.TabStop = false;
            // 
            // bt_Painel2Exibe
            // 
            this.bt_Painel2Exibe.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Painel2Exibe.FlatAppearance.BorderSize = 0;
            this.bt_Painel2Exibe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Painel2Exibe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Painel2Exibe.Image = global::NutricionalApp.Properties.Resources.Menu_24;
            this.bt_Painel2Exibe.Location = new System.Drawing.Point(1136, 0);
            this.bt_Painel2Exibe.Name = "bt_Painel2Exibe";
            this.bt_Painel2Exibe.Size = new System.Drawing.Size(29, 50);
            this.bt_Painel2Exibe.TabIndex = 42;
            this.bt_Painel2Exibe.UseVisualStyleBackColor = true;
            this.bt_Painel2Exibe.Visible = false;
            this.bt_Painel2Exibe.Click += new System.EventHandler(this.bt_Painel2Exibe_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::NutricionalApp.Properties.Resources.Watermelon_w_100;
            this.pictureBox2.Location = new System.Drawing.Point(55, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1110, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(29, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(26, 50);
            this.splitter3.TabIndex = 21;
            this.splitter3.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(1165, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(19, 50);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // bt_Painel1Exibe
            // 
            this.bt_Painel1Exibe.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Painel1Exibe.FlatAppearance.BorderSize = 0;
            this.bt_Painel1Exibe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Painel1Exibe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Painel1Exibe.Image = global::NutricionalApp.Properties.Resources.Menu_24;
            this.bt_Painel1Exibe.Location = new System.Drawing.Point(0, 0);
            this.bt_Painel1Exibe.Name = "bt_Painel1Exibe";
            this.bt_Painel1Exibe.Size = new System.Drawing.Size(29, 50);
            this.bt_Painel1Exibe.TabIndex = 14;
            this.bt_Painel1Exibe.UseVisualStyleBackColor = true;
            this.bt_Painel1Exibe.Click += new System.EventHandler(this.bt_Painel1Exibe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 461);
            this.panel1.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(373, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::NutricionalApp.Properties.Resources.Customer_16;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(371, 52);
            this.toolStripButton1.Text = "Identifique-se";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton1.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(799, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 461);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_atualiza);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ultimas Atividades:";
            // 
            // l_atualiza
            // 
            this.l_atualiza.AutoSize = true;
            this.l_atualiza.Location = new System.Drawing.Point(341, 0);
            this.l_atualiza.Name = "l_atualiza";
            this.l_atualiza.Size = new System.Drawing.Size(0, 13);
            this.l_atualiza.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(379, 401);
            this.panel5.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datamovimentoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logatividadesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(379, 401);
            this.dataGridView1.TabIndex = 5;
            // 
            // datamovimentoDataGridViewTextBoxColumn
            // 
            this.datamovimentoDataGridViewTextBoxColumn.DataPropertyName = "data_movimento";
            this.datamovimentoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datamovimentoDataGridViewTextBoxColumn.Name = "datamovimentoDataGridViewTextBoxColumn";
            this.datamovimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 230;
            // 
            // logatividadesBindingSource
            // 
            this.logatividadesBindingSource.DataMember = "log_atividades";
            this.logatividadesBindingSource.DataSource = this.nutricionalDB;
            // 
            // nutricionalDB
            // 
            this.nutricionalDB.DataSetName = "NutricionalDB";
            this.nutricionalDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_atualizaGrid);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtBusca);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 39);
            this.panel3.TabIndex = 5;
            // 
            // bt_atualizaGrid
            // 
            this.bt_atualizaGrid.Image = global::NutricionalApp.Properties.Resources.Sync_16;
            this.bt_atualizaGrid.Location = new System.Drawing.Point(340, 3);
            this.bt_atualizaGrid.Name = "bt_atualizaGrid";
            this.bt_atualizaGrid.Size = new System.Drawing.Size(36, 30);
            this.bt_atualizaGrid.TabIndex = 6;
            this.bt_atualizaGrid.UseVisualStyleBackColor = true;
            this.bt_atualizaGrid.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busca:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(51, 8);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(283, 22);
            this.txtBusca.TabIndex = 4;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // log_atividadesTableAdapter
            // 
            this.log_atividadesTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutricional";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logatividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutricionalDB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_Painel1Exibe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Painel2Exibe;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_idNutricionista;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private NutricionalDB nutricionalDB;
        private System.Windows.Forms.BindingSource logatividadesBindingSource;
        private NutricionalDBTableAdapters.log_atividadesTableAdapter log_atividadesTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_atualiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamovimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_atualizaGrid;
    }
}

