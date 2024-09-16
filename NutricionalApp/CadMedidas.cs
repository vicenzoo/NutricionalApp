using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutricionalApp.DatabaseConnection;

namespace NutricionalApp
{
    public partial class CadMedidas : Form
    {
        public CadMedidas()
        {
            InitializeComponent();
        }

        private void CadMedidas_Load(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                AtualizarDataGridView();
            }

        }

        private void AtualizarDataGridView()
        {
            using (var db = new DatabaseConnection())
            {
                try
                {
                    // Recarregar os dados no DataGridView
                    string query = "SELECT me.id,gr.grupo,me.medida_caseira,me.grama FROM taco_medidas me JOIN taco_grupos gr ON gr.grupo_id = me.grupo_id";
                    db.CarregarDadosSemFiltro(query, dataGridView1);
                    dataGridView1.Columns["id"].Width  = 50;
                    dataGridView1.Columns["id"].HeaderText = "ID";
                    dataGridView1.Columns["grupo"].Width  = 300;
                    dataGridView1.Columns["grupo"].HeaderText = "Grupo TACO";
                    dataGridView1.Columns["medida_caseira"].Width  = 150;
                    dataGridView1.Columns["medida_caseira"].HeaderText = "Medida Caseira";
                    dataGridView1.Columns["grama"].Width  = 75;
                    dataGridView1.Columns["grama"].HeaderText = "Grama";
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Erro ao atualizar a lista: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
