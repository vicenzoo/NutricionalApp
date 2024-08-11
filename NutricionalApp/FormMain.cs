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
        public FormMain()
        {
            InitializeComponent();
            TestCon();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            // Remove a transparência ao passar o mouse
            panel2.BackColor = Color.FromArgb(255, panel2.BackColor.R, panel2.BackColor.G, panel2.BackColor.B);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            // Aplica a transparência ao tirar o mouse de cima
            panel2.BackColor = Color.FromArgb(100, panel2.BackColor.R, panel2.BackColor.G, panel2.BackColor.B);
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
            CadNutri FormNutri = new CadNutri();
            FormNutri.MdiParent = this;

            FormNutri.Show();
        }

    }
}
