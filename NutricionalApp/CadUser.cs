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
    public partial class CadUser : Form
    {
        public CadUser()
        {
            InitializeComponent();
            dtNasc.MaxDate = DateTime.Now;
        }

        private bool validaNulos()
        {
            if (txtNome.Text.Length == 0) return false;
            if (txtEmail.Text.Length == 0) return false;
            if (txtSenha.Text.Length == 0) return false;
            if (cbSexo.SelectedIndex == -1) return false;
            return true;
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
        }

        //Cancela Troca de Abas
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox1.Mask = "000.000.000-00";
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (IsCpf(maskedTextBox1.Text))
            {
                //MessageBox.Show("valído");
                bt_Seguinte1.Enabled = true;
                PicCPF.Visible = false;
            }
            else
            {
                //MessageBox.Show("não valído");
                bt_Seguinte1.Enabled = false;
                PicCPF.Visible = true;
            }
            maskedTextBox1.Mask = "000.000.000-00";
        }

    }
}
