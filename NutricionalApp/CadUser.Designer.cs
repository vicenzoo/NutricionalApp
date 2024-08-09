namespace NutricionalApp
{
    partial class CadUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picNasc = new System.Windows.Forms.PictureBox();
            this.picNome = new System.Windows.Forms.PictureBox();
            this.PicSenha = new System.Windows.Forms.PictureBox();
            this.PicMail = new System.Windows.Forms.PictureBox();
            this.PicSexo = new System.Windows.Forms.PictureBox();
            this.PicCPF = new System.Windows.Forms.PictureBox();
            this.picSobre = new System.Windows.Forms.PictureBox();
            this.bt_Seguinte1 = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_idade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNasc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre-se";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(22, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 297);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picNasc);
            this.tabPage1.Controls.Add(this.picNome);
            this.tabPage1.Controls.Add(this.PicSenha);
            this.tabPage1.Controls.Add(this.PicMail);
            this.tabPage1.Controls.Add(this.PicSexo);
            this.tabPage1.Controls.Add(this.PicCPF);
            this.tabPage1.Controls.Add(this.picSobre);
            this.tabPage1.Controls.Add(this.bt_Seguinte1);
            this.tabPage1.Controls.Add(this.txtSenha);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label_idade);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtNasc);
            this.tabPage1.Controls.Add(this.cbSexo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.txtSobrenome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Básicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picNasc
            // 
            this.picNasc.Image = global::NutricionalApp.Properties.Resources.General_Warning_Sign_16;
            this.picNasc.Location = new System.Drawing.Point(550, 51);
            this.picNasc.Name = "picNasc";
            this.picNasc.Size = new System.Drawing.Size(18, 17);
            this.picNasc.TabIndex = 22;
            this.picNasc.TabStop = false;
            this.picNasc.Visible = false;
            // 
            // picNome
            // 
            this.picNome.Image = global::NutricionalApp.Properties.Resources.General_Warning_Sign_16;
            this.picNome.Location = new System.Drawing.Point(269, 23);
            this.picNome.Name = "picNome";
            this.picNome.Size = new System.Drawing.Size(18, 17);
            this.picNome.TabIndex = 21;
            this.picNome.TabStop = false;
            this.picNome.Visible = false;
            // 
            // PicSenha
            // 
            this.PicSenha.Image = global::NutricionalApp.Properties.Resources.General_Warning_Sign_16;
            this.PicSenha.Location = new System.Drawing.Point(269, 170);
            this.PicSenha.Name = "PicSenha";
            this.PicSenha.Size = new System.Drawing.Size(18, 17);
            this.PicSenha.TabIndex = 20;
            this.PicSenha.TabStop = false;
            this.PicSenha.Visible = false;
            // 
            // PicMail
            // 
            this.PicMail.Image = global::NutricionalApp.Properties.Resources.General_Warning_Sign_16;
            this.PicMail.Location = new System.Drawing.Point(269, 136);
            this.PicMail.Name = "PicMail";
            this.PicMail.Size = new System.Drawing.Size(18, 17);
            this.PicMail.TabIndex = 19;
            this.PicMail.TabStop = false;
            this.PicMail.Visible = false;
            // 
            // PicSexo
            // 
            this.PicSexo.Image = global::NutricionalApp.Properties.Resources.General_Warning_Sign_16;
            this.PicSexo.Location = new System.Drawing.Point(186, 106);
            this.PicSexo.Name = "PicSexo";
            this.PicSexo.Size = new System.Drawing.Size(18, 17);
            this.PicSexo.TabIndex = 18;
            this.PicSexo.TabStop = false;
            this.PicSexo.Visible = false;
            // 
            // PicCPF
            // 
            this.PicCPF.Image = global::NutricionalApp.Properties.Resources.General_Warning_Sign_16;
            this.PicCPF.Location = new System.Drawing.Point(269, 77);
            this.PicCPF.Name = "PicCPF";
            this.PicCPF.Size = new System.Drawing.Size(18, 17);
            this.PicCPF.TabIndex = 17;
            this.PicCPF.TabStop = false;
            this.PicCPF.Visible = false;
            // 
            // picSobre
            // 
            this.picSobre.Image = global::NutricionalApp.Properties.Resources.General_Warning_Sign_16;
            this.picSobre.Location = new System.Drawing.Point(269, 51);
            this.picSobre.Name = "picSobre";
            this.picSobre.Size = new System.Drawing.Size(18, 17);
            this.picSobre.TabIndex = 16;
            this.picSobre.TabStop = false;
            this.picSobre.Visible = false;
            // 
            // bt_Seguinte1
            // 
            this.bt_Seguinte1.Location = new System.Drawing.Point(653, 242);
            this.bt_Seguinte1.Name = "bt_Seguinte1";
            this.bt_Seguinte1.Size = new System.Drawing.Size(75, 23);
            this.bt_Seguinte1.TabIndex = 15;
            this.bt_Seguinte1.Text = "Seguinte";
            this.bt_Seguinte1.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(82, 167);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(181, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email:";
            // 
            // label_idade
            // 
            this.label_idade.AutoSize = true;
            this.label_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idade.Location = new System.Drawing.Point(506, 32);
            this.label_idade.Name = "label_idade";
            this.label_idade.Size = new System.Drawing.Size(38, 13);
            this.label_idade.TabIndex = 10;
            this.label_idade.Text = "idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Nascimento:";
            // 
            // dtNasc
            // 
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNasc.Location = new System.Drawing.Point(363, 48);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(181, 20);
            this.dtNasc.TabIndex = 8;
            this.dtNasc.CloseUp += new System.EventHandler(this.dtNasc_CloseUp);
            this.dtNasc.ValueChanged += new System.EventHandler(this.dtNasc_CloseUp);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexo.Location = new System.Drawing.Point(82, 103);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(98, 21);
            this.cbSexo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(82, 74);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(181, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox1_MouseClick);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(82, 48);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(181, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sobrenome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 20);
            this.txtNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sobre Você";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(744, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contato";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(744, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Finalizar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sou Nutricionista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadUser";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNasc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSobre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.Label label_idade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button bt_Seguinte1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picSobre;
        private System.Windows.Forms.PictureBox picNasc;
        private System.Windows.Forms.PictureBox picNome;
        private System.Windows.Forms.PictureBox PicSenha;
        private System.Windows.Forms.PictureBox PicMail;
        private System.Windows.Forms.PictureBox PicSexo;
        private System.Windows.Forms.PictureBox PicCPF;
    }
}