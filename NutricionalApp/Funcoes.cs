﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static NutricionalApp.Funcoes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static NutricionalApp.DatabaseConnection;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;
using System.Text.RegularExpressions;

namespace NutricionalApp
{
    internal class Funcoes
    {
        public ToolStripButton CriarBotao(string texto, string toolTipText, System.Drawing.Image imagem, EventHandler eventoClique)
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

        public static double CalcularTMB(string protocolo, string sexo, double peso, double altura, int idade, double percentualGordura)
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
            else if (protocolo == "HARRIS & BENEDICT 1919")
            {
                if (sexo == "M")
                {
                    return (66.47 + (13.75 * peso) + (5.003 * altura) - (6.755 * idade));
                }
                else if (sexo == "F")
                {
                    return (655.1 + (9.563 * peso) + (1.850 * altura) - (4.676 * idade));
                }
            }
            else if (protocolo == "SCHOFIELD 1985")
            {
                if (sexo == "M")
                {
                    if (idade >= 18 && idade <= 30)
                    {
                        return (15.057 * peso) + 692.2;
                    }
                    else if (idade > 30 && idade <= 60)
                    {
                        return (11.472 * peso) + 873.1;
                    }
                    else if (idade > 60)
                    {
                        return (11.711 * peso) + 587.7;
                    }
                }
                else if (sexo == "F")
                {
                    if (idade >= 18 && idade <= 30)
                    {
                        return (14.818 * peso) + 486.6;
                    }
                    else if (idade > 30 && idade <= 60)
                    {
                        return (8.126 * peso) + 845.6;
                    }
                    else if (idade > 60)
                    {
                        return (9.082 * peso) + 658.5;
                    }
                }
            }
            else if (protocolo == "KATCH-MCARDLE 1996")
            {
                var massaMagra = peso * (1 - percentualGordura / 100);
                return (370 + (21.6 * massaMagra));
            }

            // Se o protocolo não for reconhecido, pode-se lançar uma exceção ou retornar um valor padrão
            throw new ArgumentException("Protocolo não reconhecido.");
        }

        public static double CalcularVET(double tmb, double fatorAtividade)
        {
            return tmb * fatorAtividade;
        }

        public static void CalcularGastosEnergicos(double Peso, double Altura, int Idade, string Sexo, string Protocolo, double NivelAtividade, double PercentGordura, Label GEB, Label VET)
        {

            double tmb = CalcularTMB(Protocolo, Sexo, Peso, Altura, Idade, PercentGordura);
            GEB.Text = $"{tmb.ToString("F0")}"  + " Kcal";
            double nivelatividade = NivelAtividade;
            double vet = CalcularVET(tmb, nivelatividade);
            VET.Text = $"{vet.ToString("F0")}" + " Kcal";


        }

        // Função para calcular o VENTA diário
        public static void CalcularVentaDiario(double pesoAtual, double pesoDesejado, int dias, Label VENTA)
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

        public static void SomarGastoEnergetico(double met, DateTimePicker dateTimePicker, int frequenciaSemanal, double peso, Label VET,Label Kcal)
        {

            // Converte a duração em minutos (obtendo os minutos da parte de tempo)
            int duracaoMinutos = (dateTimePicker.Value.Hour * 60) + dateTimePicker.Value.Minute; // Total em minutos

            // Converte a duração para horas
            double duracaoHoras = duracaoMinutos / 60.0;

            // Calcula o gasto total da atividade por sessão
            double gastoPorSessao = met * peso * duracaoHoras;

            // Calcula o gasto semanal
            double gastoSemanal = gastoPorSessao * frequenciaSemanal;

            // Calcula o gasto diário médio
            double gastoDiarioMedio = gastoSemanal / 7.0;

            // Limpa a entrada e calcula o novo valor
            string cleanedInput = Regex.Replace(VET.Text, "[^0-9,.]", ""); // Remove letras e outros caracteres
            double valorAtual = double.Parse(cleanedInput, CultureInfo.InvariantCulture);

            double vetNovo = valorAtual + gastoDiarioMedio;

            // Atualiza as labels
            VET.Text = $"{vetNovo.ToString("F0")}" + " Kcal";
            Kcal.Text = $"{gastoDiarioMedio.ToString("F0")}" + " Kcal";
        }

        public static (double imc, string classificacao) CalcularIMC(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            string classificacao;

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                classificacao = "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                classificacao = "Obesidade grau 1";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                classificacao = "Obesidade grau 2";
            }
            else
            {
                classificacao = "Obesidade grau 3";
            }

            return (imc, classificacao);
        }

        public static (double rcq, string classificacao) CalcularRCQ(double cintura, double quadril,string sexo)
        {
            double rcq = cintura / quadril;
            string classificacao;

            if (sexo == "M")
            {
                if (rcq < 0.90)
                {
                    classificacao = "Excelente";
                }
                else if (rcq >= 0.90 && rcq < 0.95)
                {
                    classificacao = "Bom";
                }
                else
                {
                    classificacao = "Ruim";
                }
            }
            else if (sexo == "F")
            {
                if (rcq < 0.80)
                {
                    classificacao = "Excelente";
                }
                else if (rcq >= 0.80 && rcq < 0.85)
                {
                    classificacao = "Bom";
                }
                else
                {
                    classificacao = "Ruim";
                }
            }
            else
            {
                classificacao = "Não foi possível classificar";
            }


            return (rcq, classificacao);
        }

        public static void CalcularComposicaoCorporal(
        double peso, string sexo,int idade, string protocolo,double biceps, double triceps, double subescapular, double suprailica,
        double peitoral, double abdominal, double coxa, Label Resultados,GroupBox grupo)
        {
            grupo.Text = "Resultados Composição Corporal (" + protocolo + "):";
            if (protocolo == "4 pregas: Durmin & Wormersley")
            {
                double somaDobras = biceps + triceps + subescapular + suprailica;
                double densidadeCorporal = CalcularDensidadeCorporalDurminEWormersley(sexo, somaDobras);

                double percentualMassaGorda = (4.95 / densidadeCorporal - 4.50) * 100;
                double percentualMassaMagra = 100 - percentualMassaGorda;
                double massaGorda = peso * percentualMassaGorda / 100;
                double massaMagra = peso - massaGorda;

                Resultados.Text = "";
                Resultados.Text = ($"Percentual Massa Gorda: {percentualMassaGorda:F2}% " + "\n");
                Resultados.Text =  Resultados.Text  + ($"Percentual Massa Magra: {percentualMassaMagra:F2}% " + "\n");
                Resultados.Text =  Resultados.Text  +  ($"Massa Gorda: {massaGorda:F2} kg " + "\n");
                Resultados.Text =  Resultados.Text  +  ($"Massa Magra: {massaMagra:F2} kg " + "\n");
                Resultados.Text =  Resultados.Text  +  ($"Densidade Corporal: {densidadeCorporal:F4}");


            }
            else if (protocolo == "3 pregas: Jackson & Pollock")
            {
                double somaDobras = sexo == "M"
                    ? peitoral + abdominal + coxa //Verdadeiro
                    : triceps + suprailica + subescapular; //Falso (Feminino)

                double densidadeCorporal = CalcularDensidadeCorporalJacksonEPollock(sexo, somaDobras,idade);

                double percentualMassaGorda = (4.95 / densidadeCorporal - 4.50) * 100;
                double percentualMassaMagra = 100 - percentualMassaGorda;
                double massaGorda = peso * percentualMassaGorda / 100;
                double massaMagra = peso - massaGorda;

                Resultados.Text = "";
                Resultados.Text = ($"Percentual Massa Gorda: {percentualMassaGorda:F2}% " + "\n");
                Resultados.Text =  Resultados.Text  + ($"Percentual Massa Magra: {percentualMassaMagra:F2}% " + "\n");
                Resultados.Text =  Resultados.Text  +  ($"Massa Gorda: {massaGorda:F2} kg " + "\n");
                Resultados.Text =  Resultados.Text  +  ($"Massa Magra: {massaMagra:F2} kg " + "\n");
                Resultados.Text =  Resultados.Text  +  ($"Densidade Corporal: {densidadeCorporal:F4}");

            }


        }

        public static double CalcularDensidadeCorporalDurminEWormersley(string sexo, double somaDobras)
        {
            if (sexo == "M")
            {
                return 1.1631 - 0.0632 * Math.Log10(somaDobras);
            }
            else if (sexo == "F")
            {
                return 1.1599 - 0.0717 * Math.Log10(somaDobras);
            }
            throw new ArgumentException("Sexo não reconhecido.");
        }

        public static double CalcularDensidadeCorporalJacksonEPollock(string sexo, double somaDobras, int idade)
        {
            double densidadeCorporal;

            if (sexo == "M") // Masculino
            {
                densidadeCorporal = 1.10938 - (0.0008267 * somaDobras) + (0.0000016 * Math.Pow(somaDobras, 2)) - (0.0002574 * idade);
            }
            else // Feminino
            {
                densidadeCorporal = 1.0994921 - (0.0009929 * somaDobras) + (0.0000023 * Math.Pow(somaDobras, 2)) - (0.0001392 * idade);
            }

            return densidadeCorporal;
        }


    }
}
