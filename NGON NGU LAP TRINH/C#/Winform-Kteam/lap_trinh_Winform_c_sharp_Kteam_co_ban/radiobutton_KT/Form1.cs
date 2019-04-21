using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace radiobutton_KT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* cach 1
        void showkq(Label lb, Panel pn)
        {
            RadioButton rd = null;
            foreach (RadioButton item in pn.Controls)
            {
                if (item != null &&item.Checked)
                {
                    rd = item;
                    break;
                }
            }
            if (rd != null)
                lb.Text = rd.Text;
        }
        */
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // showkq(label2, panel1);

            //cach 2
            RadioButton rd = sender as RadioButton;
            if (rd.Checked)
            {
                label2.Text = rd.Text;
            }
            
        }
    }
}
