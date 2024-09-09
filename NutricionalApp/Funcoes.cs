using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
    }
}
