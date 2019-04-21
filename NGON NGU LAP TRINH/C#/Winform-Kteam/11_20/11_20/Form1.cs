using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addCB();
           
        }

        void addCB()
        {
            List<string> cb = new List<string>() { "1", "2" };
            comboBox1.DataSource = cb;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
           
             if (cb.SelectedValue == "1")
            {
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\image\\1.jpg");
            }
            else if (cb.SelectedValue == "2")
            {
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\image\\2.ico");
            }
        }
    }
}
