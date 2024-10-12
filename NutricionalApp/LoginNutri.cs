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

        private Image BordasRedondas(Image image)
        {
            // Reduz a imagem para o diâmetro desejado (150 pixels)
            Image resizedImage = new Bitmap(image, new Size(150, 150));

            // Cria uma nova imagem redonda
            Bitmap roundedImage = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Preenche a imagem arredondada
                using (Brush brush = new TextureBrush(resizedImage))
                {
                    g.FillEllipse(brush, 0, 0, 150, 150);
                }
            }

            // Libere os recursos de imagem
            resizedImage.Dispose();
            return roundedImage;
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
                        GetPerfil.fotoPerfil.Image = BordasRedondas(perfil.Imagem);
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
