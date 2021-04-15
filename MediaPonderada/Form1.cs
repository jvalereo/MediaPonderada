using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MediaPonderada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Treinamento - Calcule a medida pondera da nota dos alunos, tipo double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo doubles

            double nota1, nota2, nota3, peso1, peso2, peso3, somaPeso, media;

            //Declarando as variaveis nota dos pesos

            peso1 = 3.5;
            peso2 = 7.5;
            peso3 = 5.0;


            //Declarando a variaveis soma de todos os pesos

            somaPeso = peso1 + peso2 + peso3;


            //Declarando entrada de dado no textbox

            nota1 = double.Parse(textBoxPortugues.Text, CultureInfo.InvariantCulture);
            nota2 = double.Parse(textBoxMatematica.Text, CultureInfo.InvariantCulture);
            nota3 = double.Parse(textBoxCiencia.Text,CultureInfo.InvariantCulture);


            //Declarando a variavel media da nota ponderada

            media = (nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) / somaPeso ;
            
            //imprimir saida de dados no MessagemBox, concatenação


            MessageBox.Show("A media ponderada = " + media.ToString("F2", CultureInfo.InvariantCulture),
                "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Teste de novo!!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo limpar textbo, focus

            textBoxPortugues.Text = " ";
            textBoxMatematica.Text = " ";
            textBoxCiencia.Text = " ";
            textBoxPortugues.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair da aplicação 

            Close();

        }

        //Fim do programa
    }
}
