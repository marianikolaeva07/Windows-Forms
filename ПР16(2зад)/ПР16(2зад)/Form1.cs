﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР16_2зад_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "ERROR!!!";
            label1.ForeColor = Color.Red;
            MessageBox.Show("Написано же\nНЕ трогать!", "Fatal ERROR!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hover";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Не трогай.";
        }
    }
}
