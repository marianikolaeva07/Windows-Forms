using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Самостоятельная_таб_контрол
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c;
            if (radioButton1.Checked == true)
            {
                label3.Text = "a + b";
                c = a + b;
                string c1 = Convert.ToString(c);
                textBox3.Text = c1; 
            }
            if (radioButton2.Checked == true)
            {
                label3.Text = "a - b";
                c = a - b;
                string c1 = Convert.ToString(c);
                textBox3.Text = c1;
            }
            if (radioButton3.Checked == true)
            {
                label3.Text = "a * b";
                c = a * b;
                string c1 = Convert.ToString(c);
                textBox3.Text = c1;
            }
            if (radioButton4.Checked == true)
            {
                label3.Text = "a / b";
                c = a / b;
                string c1 = Convert.ToString(c);
                textBox3.Text = c1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a1 = textBox4.Text;
            string b1 = textBox5.Text;
            double n = Convert.ToDouble(a1);
            double n1 = Convert.ToDouble(b1);
            double sum = 0;
            double c = n;
            for (double i = n; i < n1; i++)
            {
                c = i + 1;
                if (c % 2 == 0)
                    label6.Text += " " + c.ToString();
                if (c % 2 == 0)
                {
                    sum = sum + c;
                }
            }
            label7.Text = "Сумма чётных чисел = " + sum;
        }
    }
}
