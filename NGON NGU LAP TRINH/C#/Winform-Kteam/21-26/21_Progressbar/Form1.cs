using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21_Progressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
           
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i >= 100)
            {
                return;
            }
            else 
            {
                 i+=5;
                 label1.Text = i.ToString() + "%"; 
                 progressBar1.PerformStep();
            }
            
        }
    }
}
