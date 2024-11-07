using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label1.Visible = true;
            label1.Text = "Выполнили студентки 2 курса группы Ип1-21 Абрашкина Дарья Васильевна, Николаева Мария Романовна";
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
        }

        private void условиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Создать калькулятор вычисления наибольшего элемента массива (массив вводится с клавиатуры в одно текстовое поле)";
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void решениеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "Введите массив чисел: ";
            label3.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = -100;
            string s = textBox1.Text;
            string[] a = s.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = Convert.ToInt32(a[i]);
                if (b[i] > max) max = b[i];
            }
            label3.Text = "Максимальный элемент массива = " + max;
        }

        private void решениеЗадачиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "Введите слова через пробел: ";
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox2.Text;
            textBox2.Text = s1.Replace(textBox3.Text, textBox4.Text);
        }

        private void условиеЗадачиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label1.Visible = true;
            label1.Text = "Напишите программу замены слова или фразы введенного текста на другую";
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
