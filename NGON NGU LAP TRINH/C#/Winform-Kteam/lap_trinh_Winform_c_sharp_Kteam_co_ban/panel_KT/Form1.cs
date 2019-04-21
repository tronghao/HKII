using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace panel_KT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Button btn = new Button();
            btn.Text = "Trọng Hảo";
            btn.Location = new Point(rand.Next(0, panel1.Size.Width), rand.Next(0, panel1.Size.Height));
            panel1.Controls.Add(btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Trọng Hảo";
            fp.Controls.Add(btn);
        }
    }
}
