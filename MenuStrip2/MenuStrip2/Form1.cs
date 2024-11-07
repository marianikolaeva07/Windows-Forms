using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(textBox1.Text);
            double b;
            if (radioButton1.Checked == true)
            {
                b = Math.Sin(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;    
            }
            if (radioButton2.Checked == true)
            {
                b = Math.Cos(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;
            }
            if (radioButton3.Checked == true)
            {
                b = Math.Tan(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;
            }
            if (radioButton4.Checked == true)
            {
                b = 1 / Math.Tan(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;
            }
        }

        private void задача1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void условиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
        }

        private void решениеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(textBox1.Text);
            double b;
            a1 = a1 * Math.PI / 180;
            if (radioButton1.Checked == true)
            {
                b = Math.Sin(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;
            }
            if (radioButton2.Checked == true)
            {
                b = Math.Cos(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;
            }
            if (radioButton3.Checked == true)
            {
                b = Math.Tan(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;
            }
            if (radioButton4.Checked == true)
            {
                b = 1 / Math.Tan(a1);
                string a = Convert.ToString(b);
                textBox2.Text = a;
            }
        }

        private void задача2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox4.Text);
            double D = b * b - 4 * a * c;
            double x1;
            double x2;
            if (D > 0)
            {
                x1 = (-b + (Math.Sqrt(D))) / (2 * a);
                x2 = (-b - (Math.Sqrt(D))) / (2 * a);
                textBox2.Text = x1 + "; " + x2;
            }
            if (D == 0)
            {
                x1 = (-b) / (2 * a);
                string x = Convert.ToString(x1);
                textBox2.Text = x;
            }
            if (D < 0)
            {
                MessageBox.Show("Нет корней", "Ошибка!");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
