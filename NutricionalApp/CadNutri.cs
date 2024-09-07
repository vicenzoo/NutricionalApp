using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NutricionalApp
{
    public partial class CadNutri : Form
    {
        System.Drawing.Image ImagemTemp;
        public CadNutri()
        {
            InitializeComponent();
        }

        //Altera Imagem de Perfil
        private void bt_upload_Click(object sender, EventArgs e)
        {
            ImagemTemp = pictureBox1.Image;
            openFileDialog1.Filter = "Imagens|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Title = "Selecione uma imagem";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }

            bt_remover.Visible = true;
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bt_remover.Visible = false;
            pictureBox1.Image = ImagemTemp;
        }

        private void ck_souEstudante_Click(object sender, EventArgs e)
        {
            if (ck_souEstudante.Checked)
            {
                mt_CRN.Text = "0";
                mt_CRN.Enabled = false;
            }
            else
            {
                mt_CRN.Clear();
                mt_CRN.Enabled = true;
            }

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

        private void mt_CPF_Leave(object sender, EventArgs e)
        {
            mt_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (IsCpf(mt_CPF.Text))
            {
                //MessageBox.Show("valído");
                bt_finalizar.Enabled = true;
                PicCPF.Visible = false;
                picCPF2.Visible = true;
            }
            else
            {
                //MessageBox.Show("não valído");
                bt_finalizar.Enabled = false;
                PicCPF.Visible = true;
                picCPF2.Visible = false;
            }
            mt_CPF.Mask = "000.000.000-00";
        }

        //Formata Mascara padrão CPF
        private void mt_CPF_Enter(object sender, EventArgs e)
        {
            mt_CPF.Mask = "000.000.000-00";
        }

        //Calcula idade
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
        }

        //Valida se a Senha é forte
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

        //Define Senha forte
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (SenhaForte(txtSenha.Text))
            {
                label_forcaSenha.Text = "Senha forte!";
                label_forcaSenha.ForeColor = ColorTranslator.FromHtml("#66BB6A");
                PicSenha.Visible = false;
                label_obsSenha.Visible = false;
               // bt_finalizar.Enabled = true;
            }
            else
            {
                label_forcaSenha.Text = "Senha fraca!";
                label_forcaSenha.ForeColor = ColorTranslator.FromHtml("#EF5350");
                PicSenha.Visible = true;
                label_obsSenha.Visible = true;
               // bt_finalizar.Enabled = false;
            }
        }

        //Botão visualizar senha
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

        //Botão Repita a Senha
        private void txt_repitaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txt_repitaSenha.Text)
            {
                label_confiraSenha.Visible = true ;
                picsenha2.Visible = true;
                bt_finalizar.Enabled = false;
            }
            else
            {
                label_confiraSenha.Visible = false;
                picsenha2.Visible = false;
                bt_finalizar.Enabled = true;
            }
        }

        //Valida se email é valido
        static bool EmailValido(string email)
        {
            //Validação de Email nulo ou Invalido
            if (email.Length == 0)
            {
                return false;
            }

            if (Regex.IsMatch(email, "@"))
            {
                return false;
            }


            return true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool emailValido = EmailValido(txtEmail.Text);
            PicMail.Visible = emailValido;
            bt_finalizar.Enabled = false;
        }


        //Valida se email é valido
        static bool EmailExiste(string email)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();

                string result = db.CheckEmailNutricionista(email);
                //MessageBox.Show(result);
                if (result == "True")
                {
                    MessageBox.Show("Esse Email já Esta cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            bool emailExiste = EmailExiste(txtEmail.Text);
            PicMail.Visible = emailExiste;
            bt_finalizar.Enabled = false;
        }

        //Valida Nome e Sobrenome
        static bool NomeSobrenomeValido(string nome, string sobrenome)
        {
            string carcEsp = @"^[a-zA-Z0-9&&[^çÇ]]+$";
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
            if (!Regex.IsMatch(nome, carcEsp))
            {
                return false;
            }

            if (!Regex.IsMatch(sobrenome, carcEsp))
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
            bt_finalizar.Enabled = false;
        }

        //Função para Executar todas as Validações
        private void ExecutaValidacoes()
        {
            txtNome_TextChanged(txtNome.Text, EventArgs.Empty);
            txtEmail_TextChanged(txtEmail.Text, EventArgs.Empty);
            txtSenha_TextChanged(txtSenha, EventArgs.Empty);
            txtEmail_Leave(txtEmail.Text, EventArgs.Empty);
            mt_CPF_Leave(mt_CPF, EventArgs.Empty);
        }


        private void bt_Revalidar_Click(object sender, EventArgs e)
        {
            ExecutaValidacoes();
        }


        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            ExecutaValidacoes();

            if (ck_Confirmacao.Checked)
            {
                using (var db = new DatabaseConnection())
                {

                    db.OpenConnection();
                    using (var comm = new NpgsqlCommand(
                        "INSERT INTO public.nutricionista " +
                        "( \"Nome\", \"Sobrenome\", \"CPF\", \"CRN\", \"Data_Nascimento\", \"Data_Inclusao\", \"Email\", \"Senha\", \"ativo\",\"Estudante\", \"Nut_icon\") " +
                        "VALUES (@Nome, @Sobrenome, @CPF, @CRN, @Data_Nascimento, @Data_Inclusao, @Email, pgp_sym_encrypt(@Senha, 'password'), @ativo,@Estudante, @Nut_icon)",
                        db.GetConnection()))
                    {

                        comm.Parameters.AddWithValue("@Nome", txtNome.Text);
                        comm.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                        comm.Parameters.AddWithValue("@CPF", mt_CPF.Text); 
                        comm.Parameters.AddWithValue("@CRN", Convert.ToInt64(mt_CRN.Text));
                        comm.Parameters.AddWithValue("@Data_Nascimento", dtNasc.Value);
                        comm.Parameters.AddWithValue("@Data_Inclusao", DateTime.Now); // Data de inclusão
                        comm.Parameters.AddWithValue("@Email", txtEmail.Text);
                        comm.Parameters.AddWithValue("@Senha", txtSenha.Text); // Senha Encriptada
                        comm.Parameters.AddWithValue("@ativo", 'S');
                        if (ck_Confirmacao.Checked) comm.Parameters.AddWithValue("@Estudante", 'S');
                        else comm.Parameters.AddWithValue("@Estudante", 'N');

                        byte[] imagemParaBytes;
                        using (var ms = new System.IO.MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Salve a imagem no MemoryStream
                            imagemParaBytes = ms.ToArray(); // Converta para array de bytes
                        }

                        comm.Parameters.AddWithValue("@Nut_icon", imagemParaBytes); // Adicione a imagem como byte array



                        try
                        {
                            comm.ExecuteNonQuery();
                            txtNome.Clear();
                            txtSobrenome.Clear();
                            mt_CPF.Clear();
                            mt_CRN.Clear();
                            dtNasc.Value = DateTime.Now;
                            txtEmail.Clear();
                            txtSenha.Clear();
                            txt_repitaSenha.Clear();
                            bt_finalizar.Enabled = false;
                            picCPF2.Visible = false;
                            PicCPF.Visible = false;
                            MessageBox.Show("Cadastrado com Sucesso! Confira sua Caixa de Emails!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Para continuar, por favor marque a caixa de seleção para confirmar.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ck_Confirmacao.Focus();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


    }
}
