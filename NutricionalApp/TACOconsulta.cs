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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NutricionalApp
{
    public partial class CadMedidas : Form
    {
        int GrupoTaco = 0;
        public CadMedidas()
        {
            InitializeComponent();
        }

        private void CadMedidas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nutricionalDB.tabela_taco4'. Você pode movê-la ou removê-la conforme necessário.
            this.tabela_taco4TableAdapter.Fill(this.nutricionalDB.tabela_taco4);
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                AtualizarDataGridView();
                db.GetTacoGrupoCombobox(cb_Grupos);
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


        private void txt_gramas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Aceita apenas Numeros
            {
                e.Handled = true;
            }
        }

        private void bt_adicionarMedida_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                using (var comm = new NpgsqlCommand(
                 "INSERT INTO public.taco_medidas " +
                    "(grama, medida_caseira, grupo_id) " +
                    "VALUES (@grama,@medida_caseira, @grupo_id)",
                    db.GetConnection()))
                {

                    comm.Parameters.AddWithValue("@grama", Convert.ToInt32(txt_gramas.Text)); // Data de inclusão
                    comm.Parameters.AddWithValue("@medida_caseira", txt_medidaCaseira.Text);
                    comm.Parameters.AddWithValue("@grupo_id", GrupoTaco);

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro: {error}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                AtualizarDataGridView();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                txt_id.Text = row.Cells["id"].Value.ToString();
                txt_medidaCaseira.Text = row.Cells["medida_caseira"].Value.ToString();
                txt_gramas.Text = row.Cells["grama"].Value.ToString();
                cb_Grupos.Text = row.Cells["grupo"].Value.ToString(); 

            }
        }

        private void cb_Grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TacoGrupos TacoGrupoSelecionado = (TacoGrupos)cb_Grupos.SelectedItem;

            if (TacoGrupoSelecionado != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idTacogrupo = TacoGrupoSelecionado.Id;
                GrupoTaco = idTacogrupo;
               // MessageBox.Show($"ID da TACO selecionada: {idTacogrupo}");
            }
        }

        private void bt_EditarRec_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                using (var comm = new NpgsqlCommand(
                    "UPDATE public.taco_medidas " +
                    "SET grama = @grama, medida_caseira = @medida_caseira, grupo_id = @grupo_id " +
                    "WHERE id = @id",
                    db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@grama", Convert.ToInt32(txt_gramas.Text)); // Atualizar valor do campo 'grama'
                    comm.Parameters.AddWithValue("@medida_caseira", txt_medidaCaseira.Text);   // Atualizar valor do campo 'medida_caseira'
                    comm.Parameters.AddWithValue("@grupo_id", GrupoTaco); // Atualizar valor do campo 'grupo_id'
                    comm.Parameters.AddWithValue("@id", Convert.ToInt32(txt_id.Text));     

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro: {error}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                AtualizarDataGridView();
            }
        }

        private void txt_BuscaTaco_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_BuscaTaco.Text))
            {
                tabelataco4BindingSource.RemoveFilter();
            }
            else
            {
                tabelataco4BindingSource.Filter = $"descricao LIKE '*{txt_BuscaTaco.Text}*'";
            }
        }
    }
}
