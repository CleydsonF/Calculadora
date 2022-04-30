using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_WindowsForm_01_Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 + num2;

            resultadoTotal.Text = resultado.ToString();
            textNumero1.Clear();
            textNumero2.Clear();
        }

        private void resultadoTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 - num2;

            resultadoTotal.Text = resultado.ToString();
            textNumero1.Clear();
            textNumero2.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 / num2;

            resultadoTotal.Text = resultado.ToString();
            textNumero1.Clear();
            textNumero2.Clear();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 * num2;

            resultadoTotal.Text = resultado.ToString();
            textNumero1.Clear();
            textNumero2.Clear();
        }
    }
}
