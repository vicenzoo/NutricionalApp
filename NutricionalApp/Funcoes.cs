using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static NutricionalApp.Funcoes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NutricionalApp
{
    internal class Funcoes
    {
        public ToolStripButton CriarBotao(string texto, string toolTipText, Image imagem, EventHandler eventoClique)
        {
            ToolStripButton botao = new ToolStripButton();

            botao.Text = texto;
            botao.ToolTipText = toolTipText;
            botao.Image = imagem;
            botao.Size = new Size(371, 52); 
            botao.Padding = new Padding(5); 
            botao.Margin = new Padding(5);
            botao.ImageScaling = ToolStripItemImageScaling.None;

            if (eventoClique != null)
            {
                botao.Click += eventoClique;
            }

            return botao;
        }

        //Rotinas Nutricionais:

        public static double CalcularTMB(string protocolo, string sexo, double peso, double altura, int idade, double percentualGordura = 0)
        {
            if (protocolo == "FAO / OMS 2001")
            {
                if (sexo == "M")
                {
                    return (66.5 + (13.75 * peso) + (5.003 * altura) - (6.75 * idade));
                }
                else if (sexo == "F") 
                {
                    return (655 + (9.563 * peso) + (1.850 * altura) - (4.676 * idade));
                }
            }
            else if (protocolo == "FAO / OMS 2001")
            {
                if (sexo == "M")
                {
                    return (66.5 + (13.75 * peso) + (5.003 * altura) - (6.75 * idade));
                }
                else if (sexo == "F")
                {
                    return (655 + (9.563 * peso) + (1.850 * altura) - (4.676 * idade));
                }
            }

            // Se o protocolo não for reconhecido, pode-se lançar uma exceção ou retornar um valor padrão
            throw new ArgumentException("Protocolo não reconhecido.");
        }

        public static double CalcularVET(double tmb, double fatorAtividade)
        {
            return tmb * fatorAtividade;
        }

        public static void CalcularGastosEnergicos(double Peso,double Altura,int Idade,string Sexo,string Protocolo,double NivelAtividade,Label GEB,Label VET)
        {

            double tmb = CalcularTMB(Protocolo, Sexo, Peso, Altura, Idade);
            GEB.Text = $"{tmb.ToString("F0")}"  + " Kcal";
            double nivelatividade = NivelAtividade; 
            double vet = CalcularVET(tmb, nivelatividade);
            VET.Text = $"{vet.ToString("F0")}" + " Kcal";


        }


        // Função para calcular o VENTA diário
        public static void CalcularVentaDiario(double pesoAtual, double pesoDesejado, int dias,Label VENTA)
        {
            const double ventaPorKg = 7700;

            // Cálculo da diferença de peso (ΔPeso)
            double deltaPeso = pesoAtual - pesoDesejado;

            // Cálculo do VENTA total
            double ventaTotal = deltaPeso * ventaPorKg;

            // Cálculo do VENTA diário
            double ventaDiario = ventaTotal / dias;

            if (ventaDiario > 0)
            {
                VENTA.Text = $"-({Math.Abs(ventaDiario).ToString("F2")}) Kcal/dia";
            }
            else
            {
                VENTA.Text = $"+({Math.Abs(ventaDiario).ToString("F2")}) Kcal/dia";
            }
        }

    }
}
