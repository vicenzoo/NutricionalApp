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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_CadNutri_Click(object sender, EventArgs e)
        {
            CadNutri Cadnutri = Application.OpenForms.OfType<CadNutri>().FirstOrDefault();

            if (Cadnutri == null) // Se não estiver aberto
            {
                Cadnutri = new CadNutri();
                Cadnutri.MdiParent =  Application.OpenForms.OfType<FormMain>().FirstOrDefault(); ;
                Cadnutri.Show();
            }
            else
            {
                Cadnutri.Focus(); // Se já estiver aberto, traz o formulário para frente
            }
        }

        private void bt_loginAdm_Click(object sender, EventArgs e)
        {
            LoginAdmSist loginAdmSist = Application.OpenForms.OfType<LoginAdmSist>().FirstOrDefault();

            if (loginAdmSist == null) // Se não estiver aberto
            {
                loginAdmSist = new LoginAdmSist();
                loginAdmSist.MdiParent =  Application.OpenForms.OfType<FormMain>().FirstOrDefault(); ;
                loginAdmSist.Show();
            }
            else
            {
                loginAdmSist.Focus(); // Se já estiver aberto, traz o formulário para frente
            }
        }

        private void bt_LoginNutri_Click(object sender, EventArgs e)
        {
            LoginNutri loginNutri = Application.OpenForms.OfType<LoginNutri>().FirstOrDefault();

            if (loginNutri == null) // Se não estiver aberto
            {
                loginNutri = new LoginNutri();
                loginNutri.MdiParent =  Application.OpenForms.OfType<FormMain>().FirstOrDefault(); ;
                loginNutri.Show();
            }
            else
            {
                loginNutri.Focus(); // Se já estiver aberto, traz o formulário para frente
            }
        }

        private void FormSplash_Activated(object sender, EventArgs e)
        {
            if (LoginNutri.NutriOk)
            {
                this.Close();
            }
            if(LoginAdmSist.AdmSistOK)
            {
                this.Close();
            }
        }
    }
}
