﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutricionalApp.DatabaseConnection;

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

            get { return pictureBox1; }

        }

        public System.Windows.Forms.Label NomeLabel
        {
            get { return label_Nome; }
        }

        public System.Windows.Forms.Label IDLabel
        {
            get { return label_idNutricionista; }
        }


        public System.Windows.Forms.Button btExibePainel2
        {
            get { return bt_Painel2Exibe; }
        }

        private void MainForm_Load(object sender, EventArgs e) //Função para mudar a cor de fundo do formMain
        {
            // TODO: esta linha de código carrega dados na tabela 'nutricionalDB.log_atividades'. Você pode movê-la ou removê-la conforme necessário.
            this.log_atividadesTableAdapter.Fill(this.nutricionalDB.log_atividades);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.Beige; 
                    break;
                }
            }
        }
        public FormMain()
        {
            InitializeComponent();
            TestCon();
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

        private void bt_Painel2Exibe_Click(object sender, EventArgs e)
        {

            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;

                //Atualiza grid Log Atividades

                timer1.Interval = 60000; // intervalo (1 minuto)
                timer1.Tick += timer1_Tick;
                timer1.Start(); 
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Exibir mensagem de atualização
            l_atualiza.Text = "Atualizando...";

            // Chamar o método para atualizar a tabela
            using (var db = new DatabaseConnection())
            {
                var query = "SELECT \"data_movimento\", \"descricao\" FROM \"public\".\"log_atividades\"";
                db.CarregarDadosSemFiltro(query, dataGridView1);
            }

            l_atualiza.Text = "";
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
            using (NpgsqlConnection con = GetConnection())
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
                bt_Painel2Exibe.Visible = true;
                panel2.Visible = true;
                toolStrip1.Items.RemoveAt(0); //Remove Botão Identifique-se

                Funcoes funcoes = new Funcoes();
                ToolStripButton botaoGerenciarNutricionistas = funcoes.CriarBotao(
                    "Permitir / Revogar Acesso ao Sistema",
                    "Gerencia Nutricionistas",
                    Properties.Resources.Key_48,
                    bt_GerenciaNutricionista_Click
                );
                toolStrip1.Items.Add(botaoGerenciarNutricionistas); // Adicione o botão ao ToolStrip


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
                    "Adicionar Pacientes",
                    "Adicionar Paciente",
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

                ToolStripButton botaoGastoEnergetico = funcoes.CriarBotao(
                 "Gastos Energeticos",
                 "Adiciona e Gerencia Gastos Energeticos do Paciente",
                  Properties.Resources.Calculator_48,
                  bt_GastoEnergetico_Click
                );
                toolStrip1.Items.Add(botaoGastoEnergetico); // Adicione o botão ao ToolStrip

                ToolStripButton botaoAntrometria = funcoes.CriarBotao(
                    "Dados Antropometricos",
                    "Adiciona e Gerencia dados Antropometricos",
                    Properties.Resources.Industrial_Scales_48,
                    bt_Antrometria_Click
                );
                toolStrip1.Items.Add(botaoAntrometria); // Adicione o botão ao ToolStrip

                ToolStripButton botaoPlanoAlimentar = funcoes.CriarBotao(
                    "Plano Alimentar",
                    "Adiciona e Gerencia Plano Alimentar para Paciente",
                    Properties.Resources.Breakfast_48,
                    bt_planoAlimentar_click
                );
                toolStrip1.Items.Add(botaoPlanoAlimentar); // Adicione o botão ao ToolStrip


                NutricionistaExecutado = true;

            }

        }

        private void BotaoGerenciarPacientes_Click(object sender, EventArgs e)
        {
            CadUser user = Application.OpenForms.OfType<CadUser>().FirstOrDefault();

            if (user == null) // Se não estiver aberto
            {
                user = new CadUser();
                //user.MdiParent = this;
                user.Owner = this;
                user.Show();
                bt_Logout.Enabled = false;
            }
            else
            {
                user.Focus(); // Se já estiver aberto, traz o formulário para frente
            }
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {

            LoginNutri.NutriOk = false;
            LoginAdmSist.AdmSistOK = false;
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
            bt_Painel2Exibe.Visible = false;
            panel2.Visible = false;
            SistAdmExecutado = false;
            NutricionistaExecutado = false;
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
                //recordatorio.MdiParent = this;
                recordatorio.Owner = this;
                recordatorio.Show();
                recordatorio.PesquisarPaciente(CadUser.userNome);
                bt_Logout.Enabled = false;
            }
            else
            {
                recordatorio.Focus();
            }
        }

        public void bt_GastoEnergetico_Click(object sender, EventArgs e)
        {
            ShowGastosEnergico();
        }

        public void ShowGastosEnergico()
        {
            CadGastosEnergeticos GastoEnergetico = Application.OpenForms.OfType<CadGastosEnergeticos>().FirstOrDefault();

            if (GastoEnergetico == null)
            {
                GastoEnergetico = new CadGastosEnergeticos();
                //GastoEnergetico.MdiParent = this;
                GastoEnergetico.Owner = this;
                GastoEnergetico.Show();
                GastoEnergetico.PesquisarPaciente(CadUser.userNome);
                bt_Logout.Enabled = false;
            }
            else
            {
                GastoEnergetico.Focus();
            }
        }


        public void bt_Antrometria_Click(object sender, EventArgs e)
        {
            ShowAntropometria();
        }

        public void ShowAntropometria()
        {
            CadAntropometria antropometria = Application.OpenForms.OfType<CadAntropometria>().FirstOrDefault();

            if (antropometria == null)
            {
                antropometria = new CadAntropometria();
                //antropometria.MdiParent = this;
                antropometria.Owner = this;
                antropometria.Show();
                antropometria.PesquisarPaciente(CadUser.userNome);
                bt_Logout.Enabled = false;
            }
            else
            {
                antropometria.Focus();
            }
        }

        private void bt_planoAlimentar_click(object sender, EventArgs e)
        {
            ShowPlanoAlimentar();
        }

        public void ShowPlanoAlimentar()
        {
            CadPlanoAlimentar planoAlimentar = Application.OpenForms.OfType<CadPlanoAlimentar>().FirstOrDefault();

            if (planoAlimentar == null)
            {
                planoAlimentar = new CadPlanoAlimentar();
                //planoAlimentar.MdiParent = this;
                planoAlimentar.Owner = this;
                planoAlimentar.Show();
                planoAlimentar.PesquisarPaciente(CadUser.userNome);
                bt_Logout.Enabled = false;
            }
            else
            {
                planoAlimentar.Focus();
            }
        }

        private void bt_GerenciaNutricionista_Click(object sender, EventArgs e)
        {
            ShowGerenciaNutricionista();
        }

        public void ShowGerenciaNutricionista()
        {
            MntNutricionista manutencaoNutri = Application.OpenForms.OfType<MntNutricionista>().FirstOrDefault();

            if (manutencaoNutri == null)
            {
                manutencaoNutri = new MntNutricionista();
                //manutencaoNutri.MdiParent = this;
                manutencaoNutri.Owner = this;
                manutencaoNutri.Show();
                bt_Logout.Enabled = false;
            }
            else
            {
                manutencaoNutri.Focus();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = logatividadesBindingSource;
            bs.Filter = "descricao LIKE '%" + txtBusca.Text + "%'";
            dataGridView1.DataSource = bs;
        }
    }



}
