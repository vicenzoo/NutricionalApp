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
    public partial class CadGastosEnergeticos : Form
    {
        int NutricionistaID = 0;

        public CadGastosEnergeticos()
        {
            InitializeComponent();
        }

        private void CadGastosEnergeticos_Load(object sender, EventArgs e)
        {
            FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
            NutricionistaID = Convert.ToInt32(GetIDNutricionista.IDLabel.Text.Substring(1));

            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                db.GetPacientes(NutricionistaID, cb_Pacientes);
            }
        }
    }
}
