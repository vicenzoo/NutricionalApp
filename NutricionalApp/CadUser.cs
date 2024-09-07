using Npgsql;
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
        bool nomeSobreValido = false;
        bool emailValid = false;
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
            mt_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (IsCpf(mt_CPF.Text))
            {
                //MessageBox.Show("valído");
                bt_Revalidar_Click(sender,e);
                PicCPF.Visible = false;
                picCPF2.Visible = true;
            }
            else
            {
                //MessageBox.Show("não valído");
                bt_Revalidar_Click(sender, e);
                PicCPF.Visible = true;
                picCPF2.Visible = false;
            }
            mt_CPF.Mask = "000.000.000-00";
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

        //Cancela Troca de Abas
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = true;

            if(bt_Seguinte1.Enabled)
            {
                e.Cancel = false;
            }
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            mt_CPF.Mask = "000.000.000-00";
        }


        //Valida se email é valido
        static bool EmailValido(string email)
        {
            //Validação de Email nulo ou Invalido
            // Validação simples do e-mail
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Verifica se o e-mail contém '@' e está em um formato válido
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool emailOk = EmailValido(txtEmail.Text);
            PicMail.Visible = !emailOk;


            if (emailOk)
            {
                emailValid = true;
            }
            else
            {
                emailValid = false;
            }
            bt_Revalidar_Click(sender, e);
        }

        static bool NomeSobrenomeValido(string nome, string sobrenome)
        {
            string carcEsp = @"^[a-zA-Z0-9&&[^çÇ]]+$";
            //Validação de nome e sobrenome nulo ou menor que 4 Caracteres
            if (nome.Length == 0 ^ nome.Length <= 4)
            {
                return false;
            }

            if (sobrenome.Length == 0 ^ sobrenome.Length <= 4 ^ sobrenome == null)
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
            bool nomeOk = NomeSobrenomeValido(txtNome.Text, txtSobrenome.Text);
            picNome.Visible = !nomeOk;
            picSobre.Visible = !nomeOk;

            if (nomeOk) {
                nomeSobreValido = true;
            }
            else
            {
                nomeSobreValido = false;
            }
        }

        private void ExecutaValidacoes()
        {
            txtNome_TextChanged(txtNome.Text, EventArgs.Empty);
            txtEmail_TextChanged(txtEmail.Text, EventArgs.Empty);
            // Se ambos os campos forem válidos, habilita o botão
            bt_Seguinte1.Enabled = nomeSobreValido && emailValid;
        }
        private void bt_Revalidar_Click(object sender, EventArgs e)
        {
            dtNasc_CloseUp(sender, e); // "Força" Atualiza Idade
            ExecutaValidacoes();
        }


        private void bt_Seguinte1_Click(object sender, EventArgs e)
        {
            ExecutaValidacoes();

            if (bt_Seguinte1.Enabled) 
            {
                tabControl1.SelectedIndex = 1;
                l_exibeNome.Text = txtNome.Text + " " + txtSobrenome.Text;
                if (mt_CPF.Text.Length == 0) l_exibeCPF.Text = "CPF Não Informado";
                else l_exibeCPF.Text = mt_CPF.Text;
                l_exibeDataNasc.Text = Convert.ToString(dtNasc.Value);
                l_exibeSexo.Text = cbSexo.SelectedText;
                l_exibeIdade.Text = label_idade.Text;
                l_exibeEmail.Text = txtEmail.Text;
            }


        }


        /// 
        /// Aba "Sobre Você"
        /// 

        //Validar Apenas Numeros 
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        //Classificação IMC
        static string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                return "Obesidade Grau I";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III";
            }
        }

        private void bt_verifica_Click(object sender, EventArgs e)
        {
          /*  if(txtAltura.Text.Length == 0 & txtPeso.Text.Length == 0)
            {

            }
            else
            {
                double IMC = Convert.ToDouble(txtPeso.Text) / ((Convert.ToDouble(txtAltura.Text) * Convert.ToDouble(txtAltura.Text)));
                label_IMC.Visible = true;
                label_IMC.Text = Convert.ToString(IMC);
                label_complementoIMC.Visible = true;
                label_complementoIMC.Text =  ClassificarIMC(IMC);
                bt_Seguinte2.Enabled = true;}
            } */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                using (var comm = new NpgsqlCommand(
                    "INSERT INTO public.paciente " +
                    "(\"Nome\", \"Sobrenome\", \"CPF\", \"Sexo\", \"data_nascimento\", \"idade\", \"Data_Inclusao\", \"Email\", nutricionista_id, \"Data_Vinculo\", ativo, \"Pac_icon\") " +
                    "VALUES (@Nome, @Sobrenome, @CPF, @Sexo, @data_nascimento, @idade, @Data_Inclusao, @Email, @nutricionista_id, @Data_Vinculo, @ativo, @Pac_icon)",
                    db.GetConnection()))
                {
                    // Definindo os parâmetros
                    comm.Parameters.AddWithValue("@Nome", txtNome.Text);
                    comm.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                    comm.Parameters.AddWithValue("@CPF", mt_CPF.Text);
                    comm.Parameters.AddWithValue("@Sexo", cbSexo.Text); ;
                    comm.Parameters.AddWithValue("@data_nascimento", dtNasc.Value);
                    comm.Parameters.AddWithValue("@idade", label_idade.Text);
                    comm.Parameters.AddWithValue("@Email", txtEmail.Text);


                    FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista

                    comm.Parameters.AddWithValue("@nutricionista_id", GetIDNutricionista.IDLabel.Text.Substring(1));
                    comm.Parameters.AddWithValue("@Data_Vinculo", DateTime.Now);
                    comm.Parameters.AddWithValue("@ativo", 'S');  // Define como ativo

                    // Conversão de imagem para byte array
                    byte[] imagemParaBytes;
                    using (var ms = new System.IO.MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Salva a imagem no MemoryStream
                        imagemParaBytes = ms.ToArray(); // Converte para array de bytes
                    }

                    comm.Parameters.AddWithValue("@Pac_icon", imagemParaBytes); // Adiciona a imagem como byte array

                    // Tentativa de execução do comando
                    try
                    {
                        comm.ExecuteNonQuery();
                        txtNome.Clear();
                        txtSobrenome.Clear();
                        mt_CPF.Clear();

                        dtNasc.Value = DateTime.Now;
                        txtEmail.Clear();
                        MessageBox.Show("Paciente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

    }
}
