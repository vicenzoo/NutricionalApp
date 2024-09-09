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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NutricionalApp
{
    public partial class LoginNutri : Form
    {
        public static bool NutriOk;
        public LoginNutri()
        {
            InitializeComponent();
            txtEmail.Text = Properties.Settings.Default.Email;
            txtSenha.Text = Properties.Settings.Default.Senha;
            ck_Salvar.Checked = Properties.Settings.Default.Checkbox;
        }

        private void SalvarLogin()
        {
            if (ck_Salvar.Checked)
            {
                Properties.Settings.Default.Email = txtEmail.Text;
                Properties.Settings.Default.Senha = txtSenha.Text;
                Properties.Settings.Default.Checkbox = ck_Salvar.Checked;
            }
            else
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Senha = "";
                Properties.Settings.Default.Checkbox = false;
            }

            Properties.Settings.Default.Save();
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
                    SalvarLogin();

                    var perfil = db.RetornaPerfil(txtEmail.Text);

                    if (perfil != null)
                    {

                        // Se necessário, use a imagem da instância do FormMain
                        var imagem = perfil.Imagem;
                        var nome = perfil.Nome;
                        var id = perfil.Id;


                        FormMain GetPerfil = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista

                        GetPerfil.IDLabel.Visible = true;
                        GetPerfil.NomeLabel.Visible = true;
                        GetPerfil.IDLabel.Text = "#" + Convert.ToString(perfil.Id);
                        GetPerfil.NomeLabel.Text = nome;
                        GetPerfil.fotoPerfil.Image = perfil.Imagem;
                        GetPerfil.Logout.Visible = true;

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
