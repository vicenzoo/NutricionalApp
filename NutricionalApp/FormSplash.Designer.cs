namespace NutricionalApp
{
    partial class FormSplash
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_loginAdm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_CadNutri = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_LoginNutri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.bt_loginAdm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(362, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 237);
            this.panel1.TabIndex = 0;
            // 
            // bt_loginAdm
            // 
            this.bt_loginAdm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_loginAdm.FlatAppearance.BorderSize = 0;
            this.bt_loginAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_loginAdm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_loginAdm.Image = global::NutricionalApp.Properties.Resources.Administrator_24;
            this.bt_loginAdm.Location = new System.Drawing.Point(0, 192);
            this.bt_loginAdm.Name = "bt_loginAdm";
            this.bt_loginAdm.Size = new System.Drawing.Size(59, 45);
            this.bt_loginAdm.TabIndex = 15;
            this.bt_loginAdm.UseVisualStyleBackColor = true;
            this.bt_loginAdm.Click += new System.EventHandler(this.bt_loginAdm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.bt_CadNutri);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.bt_LoginNutri);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bt_CadNutri
            // 
            this.bt_CadNutri.Location = new System.Drawing.Point(25, 170);
            this.bt_CadNutri.Name = "bt_CadNutri";
            this.bt_CadNutri.Size = new System.Drawing.Size(96, 40);
            this.bt_CadNutri.TabIndex = 23;
            this.bt_CadNutri.Text = "Cadastro Nutricionista";
            this.bt_CadNutri.UseVisualStyleBackColor = true;
            this.bt_CadNutri.Click += new System.EventHandler(this.bt_CadNutri_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(309, 37);
            this.label10.TabIndex = 22;
            this.label10.Text = "O que você deseja fazer ?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NutricionalApp.Properties.Resources.Enter_96;
            this.pictureBox2.Location = new System.Drawing.Point(231, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NutricionalApp.Properties.Resources.Plus_96;
            this.pictureBox1.Location = new System.Drawing.Point(25, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_LoginNutri
            // 
            this.bt_LoginNutri.Location = new System.Drawing.Point(231, 170);
            this.bt_LoginNutri.Name = "bt_LoginNutri";
            this.bt_LoginNutri.Size = new System.Drawing.Size(96, 40);
            this.bt_LoginNutri.TabIndex = 1;
            this.bt_LoginNutri.Text = "Login Nutricionista";
            this.bt_LoginNutri.UseVisualStyleBackColor = true;
            this.bt_LoginNutri.Click += new System.EventHandler(this.bt_LoginNutri_Click);
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(421, 237);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FormSplash_Activated);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_LoginNutri;
        private System.Windows.Forms.Button bt_loginAdm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_CadNutri;
    }
}