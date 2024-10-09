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
        bool DataNasc = false;
        public static string userNome { get; set; }

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
                bt_remover.Visible = true;
            }


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
            DataNasc =  true;
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
        }

        static bool NomeSobrenomeValido(string nome, string sobrenome)
        {
            string carcEsp = @"^[a-zA-Z0-9&&[^çÇ]]+$";
            //Validação de nome e sobrenome nulo ou menor que 4 Caracteres
            if (nome.Length == 0 ^ nome.Length < 4)
            {
                return false;
            }

            if (sobrenome.Length == 0 ^ sobrenome.Length < 4 ^ sobrenome == null)
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

            // Se ambos os campos forem válidos, habilita o botão
            bt_Seguinte1.Enabled = nomeSobreValido && DataNasc;
        }
        private void bt_Revalidar_Click(object sender, EventArgs e)
        {
            ExecutaValidacoes();
        }


        private void bt_Seguinte1_Click(object sender, EventArgs e)
        {
            ExecutaValidacoes();

            if (bt_Seguinte1.Enabled) 
            {
                tabControl1.SelectedIndex = 1;
                l_exibeNome.Text = txtNome.Text + " " + txtSobrenome.Text;
                userNome = txtNome.Text + " " + txtSobrenome.Text;
                if (mt_CPF.Text.Length == 0) l_exibeCPF.Text = "CPF Não Informado";
                else l_exibeCPF.Text = mt_CPF.Text;
                l_exibeDataNasc.Text =  dtNasc.Value.ToString("dd/MM/yyyy");
                l_exibeSexo.Text = cbSexo.Text;
                l_exibeIdade.Text = label_idade.Text;
                if (txtEmail.Text.Length > 0) l_exibeEmail.Text = txtEmail.Text;
                else l_exibeEmail.Text = "Email Não Informado";
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                using (var comm = new NpgsqlCommand(
                    "INSERT INTO public.paciente " +
                    "(\"nome\", \"sobrenome\", \"cpf\", \"sexo\", \"data_nascimento\", \"data_inclusao\", \"email\", nutricionista_id, \"data_vinculo\", ativo, \"pac_icon\") " +
                    "VALUES (@Nome, @Sobrenome, @CPF, @Sexo, @data_nascimento, @Data_Inclusao, @Email, @nutricionista_id, @Data_Vinculo, @ativo, @Pac_icon)",
                    db.GetConnection()))
                {
                    // Definindo os parâmetros
                    comm.Parameters.AddWithValue("@Nome", txtNome.Text);
                    comm.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);

                    if (mt_CPF.Text.Length > 0)
                    {
                        comm.Parameters.AddWithValue("@CPF", mt_CPF.Text);
                    }
                    else
                    {
                        comm.Parameters.AddWithValue("@CPF", DBNull.Value);
                    }

                    if (cbSexo.Text == "Masculino") 
                    {
                        comm.Parameters.AddWithValue("@Sexo", "M");
                    }
                    else if (cbSexo.Text == "Feminino")
                    {
                        comm.Parameters.AddWithValue("@Sexo", "F");
                    }

                    comm.Parameters.AddWithValue("@data_nascimento", dtNasc.Value);
                    comm.Parameters.AddWithValue("@Data_Inclusao", DateTime.Now); // Data de inclusão Hoje
                    if (txtEmail.Text.Length > 0)
                    {
                        comm.Parameters.AddWithValue("@Email", txtEmail.Text);
                    } else
                    {
                        comm.Parameters.AddWithValue("@Email", DBNull.Value);

                    }

                    FormMain GetIDNutricionista = Application.OpenForms.OfType<FormMain>().FirstOrDefault(); //Função para Pegar o Numero de ID do Nutricionista
                    int ID = 0;
                    ID = Convert.ToInt32(GetIDNutricionista.IDLabel.Text.Substring(1));
                    comm.Parameters.AddWithValue("@nutricionista_id", ID);
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
                        comm.ExecuteScalar();


                        /* l_exibeNome.Text = "";
                         l_exibeCPF.Text = "";
                         l_exibeDataNasc.Text = "";
                         l_exibeSexo.Text  = "";
                         l_exibeIdade.Text  = "";
                         l_exibeEmail.Text  = ""; */

                        txtNome.Clear();
                        txtSobrenome.Clear();
                        mt_CPF.Clear();
                        txtEmail.Clear();
                        bt_Seguinte1.Enabled = false;
                        bt_Finalizar.Enabled = false;
                        label_Adicionar.Visible = true;
                        bt_AvAntropometrica.Visible = true;
                        bt_Gastos.Visible = true;
                        bt_Recordatorio.Visible = true;
                        bt_PlanoAlimentar.Visible = true;
                        MessageBox.Show("Paciente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (PostgresException pgError)
                    {
                        MessageBox.Show($"Erro PostgreSQL: {pgError.Message}\nColuna: {pgError.ColumnName}\nDetalhes: {pgError.Detail}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Erro geral: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void bt_Recordatorio_Click(object sender, EventArgs e)
        {
            FormMain recordatorio = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (recordatorio != null)
            {
                recordatorio.ShowRecordatorio(); // Chama o método público
            }
        }

        private void bt_Gastos_Click(object sender, EventArgs e)
        {
            FormMain GastoEnergico = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (GastoEnergico != null)
            {
                GastoEnergico.ShowGastosEnergico(); // Chama o método público
            }
        }

        private void bt_AvAntropometrica_Click(object sender, EventArgs e)
        {
            FormMain AvaliacaoAntropometrica = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (AvaliacaoAntropometrica != null)
            {
                AvaliacaoAntropometrica.ShowAntropometria(); // Chama o método público
            }
        }

        private void bt_PlanoAlimentar_Click(object sender, EventArgs e)
        {
            FormMain PlanoAlimentar = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (PlanoAlimentar != null)
            {
                PlanoAlimentar.ShowPlanoAlimentar(); // Chama o método público
            }
        }
    }
}
