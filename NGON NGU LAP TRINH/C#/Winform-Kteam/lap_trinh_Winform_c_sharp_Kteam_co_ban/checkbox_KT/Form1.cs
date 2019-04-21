using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace checkbox_KT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                string kq = "Xin Chào " + name + ". Bạn là người Việt Nam";
                MessageBox.Show(kq);
            }
            else
            {
                string kq2 = "Hello " + name +". You aren't vietnamese";
                MessageBox.Show(kq2);
            }
        }
    }
}
