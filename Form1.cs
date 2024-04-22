using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoradat6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // enum é uma lista de opção.
        enum Operacao
        {
            Soma,
            Subtrai,
            Divide,
            Multiplica,
            Nenhuma
        }

        static Operacao ultimaOperaçao = Operacao.Nenhuma;







        private void buttonNum_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }


        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (ultimaOperaçao == Operacao.Nenhuma)
            {

                ultimaOperaçao = Operacao.Soma;
            }
            else
            { 
                FazerCalculo(ultimaOperaçao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void FazerCalculo(Operacao ultimaOperaçao)
        {
            //Uma lista de números do tipo "double" (real)
            // Uma lista é um vetor MELHORADO.
            List<double> listaDeNumeros = new List<double>();


            switch (ultimaOperaçao)
            {
                case Operacao.Soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Divide:
                    listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Nenhuma:
                    break;
                default:
                    break;
            }





        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (ultimaOperaçao != Operacao.Nenhuma)
            {
                _ = ultimaOperaçao == Operacao.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperaçao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }
        

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (ultimaOperaçao != Operacao.Nenhuma)
            {
                FazerCalculo(ultimaOperaçao);
            }
           ultimaOperaçao = Operacao.Nenhuma;   
         }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            if(ultimaOperaçao != Operacao.Nenhuma)
            {
                _ = ultimaOperaçao == Operacao.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperaçao);
            }
            textBoxDisplay.Text += (sender as Button).Text;

        }

        private void buttonBarra_Click(object sender, EventArgs e)
        {

            if (ultimaOperaçao != Operacao.Nenhuma)
            {
                _ = ultimaOperaçao == Operacao.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperaçao);
            }
            textBoxDisplay.Text += (sender as Button).Text;










        }
    }
}
