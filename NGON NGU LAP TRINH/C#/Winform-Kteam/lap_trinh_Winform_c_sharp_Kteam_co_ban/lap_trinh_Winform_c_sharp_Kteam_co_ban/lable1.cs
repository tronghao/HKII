using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lap_trinh_Winform_c_sharp_Kteam_co_ban
{
    public partial class lable1 : Form
    {
        public lable1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "PhêRô";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lable2 f2 = new lable2();
            
            f2.ShowDialog(); // form 1 k thể thao tác
                            // f2.Show(); có thể thao tác tất cả các form
        }
    }
}
