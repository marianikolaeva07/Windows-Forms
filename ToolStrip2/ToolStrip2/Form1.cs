using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value += 5;
            if (toolStripProgressBar1.Value != 100)
            {
                toolStripLabel2.Text = "Подождите. Идет загрузка";
            }
            if (toolStripProgressBar1.Value == 100)
            {
                toolStripLabel2.Text = "Загрузка завершена";
                timer1.Stop();
            }
        }
    }
}
