﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Самостоятельная_по_кнопкам
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Другое имя";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
