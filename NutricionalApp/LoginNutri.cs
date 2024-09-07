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
    public partial class LoginNutri : Form
    {
        public static bool NutriOk;
        public LoginNutri()
        {
            InitializeComponent();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar != '\0')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }



        private void bt_login_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();

                string email = txtEmail.Text;
                string pass = txtSenha.Text;

                string result = db.CheckNutricionista(email, pass);

                if (result == "true")
                {
                    MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NutriOk = true;

                    FormMain formMainInstance = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
                    var perfil = db.RetornaPerfil(txtEmail.Text);

                    if (perfil != null)
                    {
                        formMainInstance.PerfilNutricionista = perfil;
                        formMainInstance.PerfilNutricionista = perfil;

                        // Se necessário, use a imagem da instância do FormMain
                        var imagem = perfil.Imagem;
                        var nome = perfil.Nome;
                        var id = perfil.Id;

                        // Faça o que precisar com a imagem, nome e ID
                    }
                    else
                    {
                        MessageBox.Show("Perfil não encontrado.");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NutriOk = false;
                }
            }
        }
    }
}
