using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutricionalApp.DatabaseConnection;

namespace NutricionalApp
{

    public partial class FormMain : Form
    {
        public Perfil PerfilNutricionista { get; set; }

        public System.Windows.Forms.Label IDLabel
        {
            get { return label_idNutricionista; }
        }

        public FormMain()
        {
            InitializeComponent();
            TestCon();
            panel1.BackColor = Color.FromArgb(100, panel1.BackColor.R, panel1.BackColor.G, panel1.BackColor.B);
            
            // Inicializa e configura o Timer para a l_hora
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Start();

            // Inicializa a exibição da hora
            UpdateTime();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Atualiza a exibição da hora a cada segundo
            UpdateTime();
        }

        private void UpdateTime()
        {
            l_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
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

                Funcoes funcoes = new Funcoes();
                //ToolStripButton botaoGerenciarNutricionistas = funcoes.CriarBotao("Gerenciar Nutricionistas Cadastrados", "Gerencia Acesso a Nutricionistas Cadastrados", Properties.Resources.Watermelon);
                //toolStrip1.Items.Add(botaoGerenciarNutricionistas); // Adicione o botão ao ToolStrip
                pictureBox1.Image = Properties.Resources.Male_User_96;
            }
        }

        private void IsNutricionista()
        {
            if (LoginNutri.NutriOk) //Rotina Caso Seja um Nutricionista
            {
                pictureBox1.Image = PerfilNutricionista.Imagem;
                label_Nome.Text = PerfilNutricionista.Nome;
                label_idNutricionista.Text = "#" + PerfilNutricionista.Id;
                label_Nome.Visible = true;
                label_idNutricionista.Visible = true;

                toolStrip1.Items.RemoveAt(0); //Remove Botão Identifique-se
                Funcoes funcoes = new Funcoes();
                ToolStripButton botaoGerenciarNutricionistas = funcoes.CriarBotao(
                    "Gerenciar Pacientes Cadastrados",
                    "Adiciona Paciente",
                    Properties.Resources.Person_48,
                    BotaoGerenciarPacientes_Click
                );

                toolStrip1.Items.Add(botaoGerenciarNutricionistas); // Adicione o botão ao ToolStrip

            }

        }

        private void BotaoGerenciarPacientes_Click(object sender, EventArgs e)
        {
            CadUser user = Application.OpenForms.OfType<CadUser>().FirstOrDefault();

            if (user == null) // Se não estiver aberto
            {
                panel1.Visible = false;
                user = new CadUser();
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                user.Focus(); // Se já estiver aberto, traz o formulário para frente
            }
        }
    }
}
