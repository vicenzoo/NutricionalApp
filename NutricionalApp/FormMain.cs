using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutricionalApp
{

    public partial class FormMain : Form
    {
        public static Image ImagemPerfil;
        public FormMain()
        {
            InitializeComponent();
            TestCon();
            panel1.BackColor = Color.FromArgb(100, panel1.BackColor.R, panel1.BackColor.G, panel1.BackColor.B);
        }

        private void bt_Painel1Exibe_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }

            IsAdmSist();
            IsNutricionista();
        }



        private static NpgsqlConnection GetConnection()
        {

            string host = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            string port = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
            string userId = Environment.GetEnvironmentVariable("DB_USER") ?? "postgres";
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "adm";
            string database = Environment.GetEnvironmentVariable("DB_NAME") ?? "postgres";

            //Conexão SSL para o Banco
            var connectionString = $"Server={host};Port={port};User Id={userId};Password={password};Database={database};SslMode=Prefer;";
            return new NpgsqlConnection(connectionString);
        }
        
        private static void TestCon()
        {
            using(NpgsqlConnection con = GetConnection())
            {
                con.Open();
                if (con.State==ConnectionState.Open)
                {
                    //MessageBox.Show("Conectado!");





                }
                else
                {
                    MessageBox.Show("Não Conectado!");           
                }
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    this.Close();
            }
        }

        private void bt_resize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            FormSplash splash = Application.OpenForms.OfType<FormSplash>().FirstOrDefault();

            if (splash == null) // Se não estiver aberto
            {
                panel1.Visible = false;
                splash = new FormSplash();
                splash.MdiParent = this;
                splash.Show();
            }
            else
            {
                splash.Focus(); // Se já estiver aberto, traz o formulário para frente
            }

        }

        private void IsAdmSist()
        {
            if (LoginAdmSist.AdmSistOK) //Rotina Caso Seja um adminstrador do Sistema
            {
                toolStrip1.Items.RemoveAt(0); //Remove Botão Identifique-se

                ToolStripButton gerenciaNutri = new ToolStripButton();

                gerenciaNutri.Text = "Gerenciar Nutricionistas Cadastrados";
                gerenciaNutri.ToolTipText = "Este é um novo botão";
                gerenciaNutri.Image = gerenciaNutri.Image = Properties.Resources.background1;// (defina uma imagem, se necessário)

                // Adicione o botão ao ToolStrip
                toolStrip1.Items.Add(gerenciaNutri);

            }
        }

        private void IsNutricionista()
        {
            if (LoginNutri.NutriOk) //Rotina Caso Seja um adminstrador do Sistema
            {
                toolStrip1.Items.RemoveAt(0); //Remove Botão Identifique-se
                pictureBox1.Image = ImagemPerfil;
            }

        }

    }
}
