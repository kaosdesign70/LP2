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

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0.0, valor2 = 0.0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textBox1.Text = (" ");
            label1.Text = (" ");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = (" ");
            operacao = "SOMA";
            label1.Text = "+";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                textBox1.Text = (valor1 + valor2).ToString("F2");
            }
            if(operacao == "SUBTRACAO")
            {
                textBox1.Text = (valor1 - valor2).ToString("F2");
            }
            if(operacao == "MULTIPLICA")
            {
                textBox1.Text = (valor1 * valor2).ToString("F2");

            }
            if(operacao == "DIVISAO")
            {
                textBox1.Text = (valor1 / valor2).ToString("F2");

            }

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = (" ");
            operacao = "SUBTRACAO";
            label1.Text = "-";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = (" ");
            operacao = "MULTIPLICA";
            label1.Text = "x";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = (" ");
            operacao = "DIVISAO";
            label1.Text = "/";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
