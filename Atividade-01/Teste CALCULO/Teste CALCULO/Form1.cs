using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_CALCULO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double diametro, altura, volume;  //Este comando foi eliminado permanece para fins didáticos//

            diametro = Convert.ToDouble(textBox1.Text);
            altura = Convert.ToDouble(textBox2.Text);


            volume = (Math.PI / 4) * Math.Pow(diametro, 2) * altura;

            textBox3.Text = volume.ToString("F2");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double diametro, altura, volume;

            diametro = double.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text);


            volume = (Math.PI / 4) * Math.Pow(diametro, 2) * altura;

            textBox3.Text = volume.ToString("F2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }
    }
}
