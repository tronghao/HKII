using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _21_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void getProcess()
        {
            Process[] pr = Process.GetProcesses();
            foreach(Process item in pr)
            {
                textBox1.Text = item.ProcessName + "\n" + textBox1.Text;

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getProcess();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("http://khaitam.byethost9.com/01.php");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process pro = new Process();
            pro.StartInfo.FileName = Application.StartupPath + "\\21-26.exe";
            pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pro.Start();
        }
    }
}
