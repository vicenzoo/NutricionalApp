using ActiveQueryBuilder.Core;
using Npgsql;
using System;
using System.Collections;
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
    public partial class CadRecordatorio : Form
    {
        int PacienteId;
        int NutricionistaID = 0;
        public CadRecordatorio()
        {
            InitializeComponent();
            dt_DataHoraRec.CustomFormat = "dd/MM/yyyy HH:mm";
            dt_DataHoraRec.Value = DateTime.Now;
            dt_DataHoraRec.MaxDate = DateTime.Now;
        }

        private void CadRecordatorio_Load(object sender, EventArgs e)
        {
            FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
            NutricionistaID = Convert.ToInt32(GetIDNutricionista.IDLabel.Text.Substring(1));

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetPacientes(NutricionistaID, cb_Pacientes);
            }
        }

        private void cb_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenha o paciente selecionado
            Paciente pacienteSelecionado = (Paciente)cb_Pacientes.SelectedItem;

            if (pacienteSelecionado != null)
            {
                // Exibe ou usa o id do paciente selecionado
                int idPaciente = pacienteSelecionado.Id;
                PacienteId = idPaciente;
                //MessageBox.Show($"ID do paciente selecionado: {idPaciente}");

                txt_DescricaoNome.Clear();
                txt_DescricaoNome.Text = "Recordatório para " + cb_Pacientes.Text;
            }
        }

        private void bt_adicionarRec_Click(object sender, EventArgs e)
        {
            if (cb_Pacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Paciente!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja Iniciar o Recordatorio deste Paciente ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new DatabaseConnection())
                {

                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                     "INSERT INTO public.recordatorio_24h " +
                        "( \"Data_Inclusao\",descricao_nome, paciente_id, nutricionista_id, ativo) " +
                        "VALUES (@Data_Inclusao,@descricao_nome, @paciente_id, @nutricionista_id, @ativo)",
                        db.GetConnection()))
                    {

                        comm.Parameters.AddWithValue("@Data_Inclusao", DateTime.Now); // Data de inclusão
                        comm.Parameters.AddWithValue("@descricao_nome",txt_DescricaoNome.Text);
                        comm.Parameters.AddWithValue("@paciente_id", PacienteId);
                        comm.Parameters.AddWithValue("@nutricionista_id", NutricionistaID); 
                        comm.Parameters.AddWithValue("@ativo", 'S');
                        gr_selecao.Visible = true;
                        gr_Resultados.Visible = true;

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


                }


            }
            else
            {
                bt_adicionarRec.Focus();
            }
        }
    }
}