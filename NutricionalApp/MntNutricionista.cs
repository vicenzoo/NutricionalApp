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
using static NutricionalApp.DatabaseConnection;

namespace NutricionalApp
{
    public partial class MntNutricionista : Form
    {
        public MntNutricionista()
        {
            InitializeComponent();
            this.TopMost = true;
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
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtSobrenome.Text = row.Cells["Sobrenome"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txtCRN.Text = row.Cells["CRN"].Value.ToString();
                l_estudante.Text = row.Cells["Estudante"].Value.ToString();
                cb_acessoSistema.SelectedItem = row.Cells["ativo"].Value.ToString();
                l_IDNutri.Text =  row.Cells["id_nutricionista"].Value.ToString();
            }
        }

        private void bt_PermitirRevogar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar os dados ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                         "UPDATE public.nutricionista " +
                         "SET \"Nome\" = @nome," +
                         "\"Sobrenome\" = @sobrenome," +
                         "\"CRN\" = @crn," +
                         "\"Email\" = @email," +
                         "\"Data_Alteracao\" = @data_alteracao," +
                         "\"Data_Exclusao\" = @data_exclusao," +
                         "ativo  = @ativo " +
                         "WHERE id_nutricionista = @id_nutricionista",
                         db.GetConnection()))
                    {
                        // Adicionando os parâmetros com seus respectivos valores
                        comm.Parameters.AddWithValue("@id_nutricionista", Convert.ToInt32(l_IDNutri.Text));
                        comm.Parameters.AddWithValue("@nome", txtNome.Text);
                        comm.Parameters.AddWithValue("@sobrenome", txtSobrenome.Text);
                        comm.Parameters.AddWithValue("@crn", Convert.ToInt32(txtCRN.Text));
                        comm.Parameters.AddWithValue("@email", txt_Email.Text);

                        if (cb_acessoSistema.SelectedItem.ToString() == "S")
                        {
                            comm.Parameters.AddWithValue("@data_alteracao", DateTime.Now);
                            comm.Parameters.AddWithValue("@Data_Exclusao", DBNull.Value);
                        }
                        else
                        {
                            comm.Parameters.AddWithValue("@data_alteracao", DBNull.Value);
                            comm.Parameters.AddWithValue("@Data_Exclusao", DateTime.Now);
                        }

                        comm.Parameters.AddWithValue("@ativo", cb_acessoSistema.SelectedItem.ToString());

                        try
                        {
                            comm.ExecuteNonQuery();

                            string query = "SELECT \"id_nutricionista\", \"Nome\", \"Sobrenome\", \"CPF\", \"CRN\", \"Data_Nascimento\", \"Idade\", \"Data_Inclusao\", \"Data_Alteracao\", \"Data_Exclusao\", \"Email\", \"ativo\", \"Nut_icon\", \"Senha\", \"Estudante\" FROM \"public\".\"nutricionista\"";

                            db.CarregarDadosSemFiltro(query, dataGridView1);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show($"Erro: {error.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

        }

        private void txtFiltroNome_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = nutricionistaBindingSource;
            bs.Filter = "Nome LIKE '%" + txtFiltroNome.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void cb_filtroAtivo_SelectedValueChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = nutricionistaBindingSource;
            bs.Filter = "ativo = '" + cb_filtroAtivo.SelectedItem.ToString() + "'";
            dataGridView1.DataSource = bs;
        }
    }
}
