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
    public partial class CadNutri : Form
    {
        Image ImagemTemp;
        public CadNutri()
        {
            InitializeComponent();
        }

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

        private void mt_CPF_Leave(object sender, EventArgs e)
        {
            mt_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (IsCpf(mt_CPF.Text))
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
            mt_CPF.Mask = "000.000.000-00";
        }
    }
}
