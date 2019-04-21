using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ung_dung_phan_mem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Label lb = new Label();
            lb.Text = " 0001 ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

       
    }
}
