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

        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost,Port=5432,User Id=postgres;Password=adm;Database=Nutricional;");
        }
        
        private static void TestCon()
        {
            using(NpgsqlConnection con = GetConnection())
            {
                con.Open();
                if (con.State==ConnectionState.Open)
                {
                    Console.WriteLine("Conectado!!");
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
    }
}
