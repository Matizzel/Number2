using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форм
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine +
                "a= " + a.ToString();
            double b = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine +
                "b= " + b.ToString();
            double x = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine +
                "x= " + x.ToString();
            double G = a * x - Math.Sqrt(b);
            double G1 = 5.7 * (Math.Pow(x, 2) + Math.Pow(b, 2));
            double H = Math.Abs(x + b) - Math.Pow(a, 2);
            double H1 = Math.Pow(x, 2);
            double J = Math.Pow(Math.Tan(b), 2);
            double K = (G / G1) - ((H / H1) * J);
            textBox4.Text += Environment.NewLine + "y = " + K.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
