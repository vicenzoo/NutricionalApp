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
    public partial class MntNutricionista : Form
    {
        public MntNutricionista()
        {
            InitializeComponent();
        }

        private void MntNutricionista_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nutricionalDB.nutricionista'. Você pode movê-la ou removê-la conforme necessário.
            this.nutricionistaTableAdapter.Fill(this.nutricionalDB.nutricionista);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha atual
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNome.Text = row.Cells["Nome"].Value.ToString() + " " + row.Cells["Sobrenome"].Value.ToString();
                txtCRN.Text = row.Cells["CRN"].Value.ToString();
                l_estudante.Text = row.Cells["Estudante"].Value.ToString();
            }
        }

        private void bt_PermitirRevogar_Click(object sender, EventArgs e)
        {

        }
    }
}
