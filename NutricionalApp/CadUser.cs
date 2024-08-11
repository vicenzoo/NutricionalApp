using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutricionalApp
{

    public partial class CadUser : Form
    {

        Image ImagemTemp;
        public CadUser()
        {
            InitializeComponent();
            dtNasc.MaxDate = DateTime.Now;
            cbSexo.SelectedIndex = 1;
        }

        //Fazer Upload de Imagem 
        private void bt_upload_Click(object sender, EventArgs e)
        {
            ImagemTemp = pictureBox1.Image;
            openFileDialog1.Filter = "Imagens|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Title = "Selecione uma imagem";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

            bt_remover.Visible = true;
        }

        //Remover imagem
        private void bt_remover_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bt_remover.Visible = false;
            pictureBox1.Image = ImagemTemp;
        }

        //Valida CPF
        Func<string, bool> IsCpf = cpf =>
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        };

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (IsCpf(maskedTextBox1.Text))
            {
                //MessageBox.Show("valído");
                bt_Seguinte1.Enabled = true;
                PicCPF.Visible = false;
                picCPF2.Visible = true;
            }
            else
            {
                //MessageBox.Show("não valído");
                bt_Seguinte1.Enabled = false;
                PicCPF.Visible = true;
                picCPF2.Visible = false;
            }
            maskedTextBox1.Mask = "000.000.000-00";
        }

        //Valida Idade
        private int CalculaIdade(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            // Caso não tenha feito Aniversario
            if (birthDate.Date > today.AddYears(-age)) age--;

            return age;
        }

        private void dtNasc_CloseUp(object sender, EventArgs e)
        {
            int idade = CalculaIdade(dtNasc.Value);

            label_idade.Text = "";
            label_idade.Text = Convert.ToString(idade);
            label_idadeComplemento.Visible = true;
        }

        //Valida se A senha é forte
        static bool SenhaForte(string senha)
        {
            if (senha.Length < 8)
                return false;

            if (!Regex.IsMatch(senha, @"[A-Z]")) // Verifica se tem pelo menos uma letra maiúscula
                return false;

            if (!Regex.IsMatch(senha, @"[a-z]")) // Verifica se tem pelo menos uma letra minúscula
                return false;

            if (!Regex.IsMatch(senha, @"[0-9]")) // Verifica se tem pelo menos um dígito numérico
                return false;

            if (!Regex.IsMatch(senha, @"[\W_]")) // Verifica se tem pelo menos um caractere especial
                return false;

            return true;
        }


        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (SenhaForte(txtSenha.Text))
            {
                label_forcaSenha.Text = "Senha forte!";
                label_forcaSenha.ForeColor = ColorTranslator.FromHtml("#66BB6A");
                PicSenha.Visible = false;
                label_obsSenha.Visible = false;
                bt_Seguinte1.Enabled = true;
            }
            else
            {
                label_forcaSenha.Text = "Senha fraca!";
                label_forcaSenha.ForeColor = ColorTranslator.FromHtml("#EF5350");
                PicSenha.Visible = true;
                label_obsSenha.Visible = true;
                bt_Seguinte1.Enabled = false;
            }
        }

        //Visualizar Senha
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

        //Cancela Troca de Abas
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = true;

            if(bt_Seguinte1.Enabled & bt_Seguinte2.Enabled)
            {
                e.Cancel = false;
            }
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox1.Mask = "000.000.000-00";
        }


        //Valida se email é valido
        static bool EmailValido(string email)
        {
            //Validação de Email nulo ou Invalido
            if (email.Length == 0)
            {
                return false;
            }

            if(Regex.IsMatch(email, "@"))
            {
               return false;
            }


            return true;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool emailValido = EmailValido(txtEmail.Text);
            PicMail.Visible = emailValido;
            bt_Seguinte1.Enabled = false;
        }

        static bool NomeSobrenomeValido(string nome, string sobrenome)
        {
            string carcEsp = @"^[a-zA-Z0-9]+$";
            //Validação de nome nulo ou menor que 4 Caracteres
            if (nome.Length == 0 ^ nome.Length <= 4)
            {
                return false;
            }

            //Validação de sobrenome nulo ou menor que 4 Caracteres
            if (sobrenome.Length == 0 ^ sobrenome.Length <= 4)
            {
                return false;
            }

            //Validação de Caracteres Especiais
            if (Regex.IsMatch(nome, carcEsp))
            {
                return false;
            }

            if (Regex.IsMatch(sobrenome, carcEsp))
            {
                return false;
            }

            return true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            bool nomeSobreValido = NomeSobrenomeValido(txtNome.Text, txtSobrenome.Text);
            picNome.Visible = nomeSobreValido;
            picSobre.Visible = nomeSobreValido;
            bt_Seguinte1.Enabled = false;
        }

        private void ExecutaValidacoes()
        {
            txtNome_TextChanged(txtNome.Text, EventArgs.Empty);
            txtEmail_TextChanged(txtEmail.Text, EventArgs.Empty);
            txtSenha_TextChanged(txtSenha, EventArgs.Empty);
            maskedTextBox1_Leave(maskedTextBox1, EventArgs.Empty);

        }



        private void bt_Seguinte1_Click(object sender, EventArgs e)
        {
            ExecutaValidacoes();

            if (bt_Seguinte1.Enabled) 
            {
                tabControl1.SelectedIndex = 1;
            }


        }



        /// 
        /// Aba "Sobre Você"
        /// 




    }
}
