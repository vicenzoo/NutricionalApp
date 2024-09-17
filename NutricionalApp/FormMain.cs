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

namespace NutricionalApp
{

    public partial class FormMain : Form
    {
        private static bool NutricionistaExecutado = false;
        private static bool SistAdmExecutado = false;
        public Button Logout
        {
          get { return bt_Logout; }
        }

        public PictureBox fotoPerfil
        {

            get { return pictureBox1;  }
        
        }

        public System.Windows.Forms.Label NomeLabel
        {
            get { return label_Nome; }
        }

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
            UpdateTime(); // Atualiza a exibição da hora
        }

        private void UpdateTime()
        {
            l_Hora.Text = DateTime.Now.ToString("HH:mm");
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
            if (SistAdmExecutado)
            {
                return; // Já foi executado
            }


            if (LoginAdmSist.AdmSistOK) //Rotina Caso Seja um adminstrador do Sistema
            {
                toolStrip1.Items.RemoveAt(0); //Remove Botão Identifique-se

                Funcoes funcoes = new Funcoes();
                //ToolStripButton botaoGerenciarNutricionistas = funcoes.CriarBotao("Gerenciar Nutricionistas Cadastrados", "Gerencia Acesso a Nutricionistas Cadastrados", Properties.Resources.Watermelon);
                //toolStrip1.Items.Add(botaoGerenciarNutricionistas); // Adicione o botão ao ToolStrip
                pictureBox1.Image = Properties.Resources.Male_User_96;


                SistAdmExecutado = true;
            }

        }

        private void IsNutricionista()
        {
            if (NutricionistaExecutado)
            {
                return; // Já foi executado
            }

            if (LoginNutri.NutriOk) //Rotina Caso Seja um Nutricionista
            {


                toolStrip1.Items.RemoveAt(0); //Remove Botão Identifique-se
                Funcoes funcoes = new Funcoes();
                ToolStripButton botaoGerenciarNutricionistas = funcoes.CriarBotao(
                    "Gerenciar Pacientes Cadastrados",
                    "Adiciona Paciente",
                    Properties.Resources.Person_48,
                    BotaoGerenciarPacientes_Click
                );
                toolStrip1.Items.Add(botaoGerenciarNutricionistas); // Adicione o botão ao ToolStrip

                ToolStripButton botaoRecordatorio = funcoes.CriarBotao(
                    "Recordatorio 24 Horas",
                    "Adiciona e Gerencia Recordatorios",
                    Properties.Resources.Restaurant_48,
                    bt_recordatorio_Click
                );
                toolStrip1.Items.Add(botaoRecordatorio); // Adicione o botão ao ToolStrip


                NutricionistaExecutado = true;

            }

        }

        private void BotaoGerenciarPacientes_Click(object sender, EventArgs e)
        {
            CadUser user = Application.OpenForms.OfType<CadUser>().FirstOrDefault();

            if (user == null) // Se não estiver aberto
            {
                user = new CadUser();
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                user.Focus(); // Se já estiver aberto, traz o formulário para frente
            }
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {

            LoginNutri.NutriOk = false;
            toolStrip1.Items.Clear();
            toolStrip1.Refresh(); 

            // Criar novamente o botão "Identifique-se"
            Funcoes funcoes = new Funcoes();
            ToolStripButton botaoIdentifique_se = funcoes.CriarBotao(
                "Identifique-se",
                "Identifique-se",
                Properties.Resources.Customer_16,
                bt_login_Click
            );

            toolStrip1.Items.Add(botaoIdentifique_se); 
            toolStrip1.Refresh();


            label_Nome.Text = "";
            label_Nome.Visible = false;
            label_idNutricionista.Text = "";
            label_idNutricionista.Visible = false;
            pictureBox1.Image = null;
            bt_Logout.Visible = false;
        }

        private void bt_recordatorio_Click(object sender, EventArgs e)
        {
            ShowRecordatorio();
        }

        public void ShowRecordatorio()
        {
            CadRecordatorio recordatorio = Application.OpenForms.OfType<CadRecordatorio>().FirstOrDefault();

            if (recordatorio == null)
            {
                recordatorio = new CadRecordatorio();
                recordatorio.MdiParent = this;
                recordatorio.Show();
            }
            else
            {
                recordatorio.Focus();
            }
        }


    }
}
