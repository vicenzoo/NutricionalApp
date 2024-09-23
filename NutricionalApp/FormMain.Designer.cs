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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel4 = new System.Windows.Forms.Panel();
            this.l_Hora = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_idNutricionista = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Painel1Exibe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.queryTransformer1 = new ActiveQueryBuilder.Core.QueryTransformer.QueryTransformer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.l_Hora);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.bt_Logout);
            this.panel4.Controls.Add(this.splitter2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label_Nome);
            this.panel4.Controls.Add(this.label_idNutricionista);
            this.panel4.Controls.Add(this.splitter3);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Controls.Add(this.bt_Exit);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.bt_Painel1Exibe);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1184, 31);
            this.panel4.TabIndex = 13;
            // 
            // l_Hora
            // 
            this.l_Hora.AutoSize = true;
            this.l_Hora.Dock = System.Windows.Forms.DockStyle.Left;
            this.l_Hora.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Hora.ForeColor = System.Drawing.Color.White;
            this.l_Hora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_Hora.Location = new System.Drawing.Point(89, 0);
            this.l_Hora.Name = "l_Hora";
            this.l_Hora.Size = new System.Drawing.Size(55, 28);
            this.l_Hora.TabIndex = 43;
            this.l_Hora.Text = "Hora";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::NutricionalApp.Properties.Resources.Time_48;
            this.pictureBox3.Location = new System.Drawing.Point(55, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NutricionalApp.Properties.Resources.Watermelon_48;
            this.pictureBox2.Location = new System.Drawing.Point(750, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // bt_Logout
            // 
            this.bt_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Logout.FlatAppearance.BorderSize = 0;
            this.bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Logout.Image = global::NutricionalApp.Properties.Resources.Exit_Sign_16px;
            this.bt_Logout.Location = new System.Drawing.Point(928, 0);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(29, 31);
            this.bt_Logout.TabIndex = 40;
            this.bt_Logout.UseVisualStyleBackColor = true;
            this.bt_Logout.Visible = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(957, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(19, 31);
            this.splitter2.TabIndex = 39;
            this.splitter2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(976, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Nome.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.ForeColor = System.Drawing.Color.White;
            this.label_Nome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Nome.Location = new System.Drawing.Point(1010, 0);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(71, 28);
            this.label_Nome.TabIndex = 33;
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
            this.label_idNutricionista.Location = new System.Drawing.Point(1081, 0);
            this.label_idNutricionista.Name = "label_idNutricionista";
            this.label_idNutricionista.Size = new System.Drawing.Size(51, 21);
            this.label_idNutricionista.TabIndex = 31;
            this.label_idNutricionista.Text = "Nome";
            this.label_idNutricionista.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(29, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(26, 31);
            this.splitter3.TabIndex = 21;
            this.splitter3.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(1132, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(19, 31);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Exit.Image")));
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Exit.Location = new System.Drawing.Point(1151, 0);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(33, 31);
            this.bt_Exit.TabIndex = 16;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(600, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "NutricionalAPP";
            // 
            // bt_Painel1Exibe
            // 
            this.bt_Painel1Exibe.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Painel1Exibe.FlatAppearance.BorderSize = 0;
            this.bt_Painel1Exibe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Painel1Exibe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Painel1Exibe.Image = global::NutricionalApp.Properties.Resources.Menu_Squared_16;
            this.bt_Painel1Exibe.Location = new System.Drawing.Point(0, 0);
            this.bt_Painel1Exibe.Name = "bt_Painel1Exibe";
            this.bt_Painel1Exibe.Size = new System.Drawing.Size(29, 31);
            this.bt_Painel1Exibe.TabIndex = 14;
            this.bt_Painel1Exibe.UseVisualStyleBackColor = true;
            this.bt_Painel1Exibe.Click += new System.EventHandler(this.bt_Painel1Exibe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 480);
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
            // queryTransformer1
            // 
            this.queryTransformer1.AlwaysExpandColumnsInQuery = false;
            this.queryTransformer1.AlwaysWrapInSubQuery = false;
            this.queryTransformer1.Query = null;
            this.queryTransformer1.QueryProvider = null;
            this.queryTransformer1.RenameDuplicatedColumns = false;
            this.queryTransformer1.SQLGenerationOptions = null;
            this.queryTransformer1.Tag = null;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutricional";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Painel1Exibe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_idNutricionista;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button bt_Logout;
        private ActiveQueryBuilder.Core.QueryTransformer.QueryTransformer queryTransformer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label l_Hora;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

