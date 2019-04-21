using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace button_KT
{
    public partial class button1 : Form
    {
        public button1()
        {
            InitializeComponent();
        }
        int i = 0;
        void addButton()
        {
            Random rand = new Random();
            Button btn = new Button() {Text = i.ToString() , Location = new Point (rand.Next(0,this.Size.Width), rand.Next(0, this.Size.Height)) };
            this.Controls.Add(btn);
            i++;
            btn.Click += new EventHandler(btn_Click);

        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addButton();
        }
    }
}
