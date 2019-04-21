using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _19_Thread
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ThreadStart ts = new ThreadStart(soChay);
            Thread thr = new Thread(soChay);
            thr.IsBackground = true;
            thr.Start();
        }

        void soChay()
        {
            int k;
            if (Int32.TryParse(textBox1.Text, out k) == true)
            {
                for (int i = 0; i <= k; i++)
                {
                    label1.Text = i.ToString();
                    Thread.Sleep(50);
                }
            }

        }
        int speed;
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thr2 = new Thread(chuyen);
            thr2.IsBackground = true;
            thr2.Start();

        }
       void chuyen()
       {
           if(Int32.TryParse(textBox2.Text, out speed)== false)
           {
               speed = -1;
           }
           if (speed < 1) return;
           while (true)
           {
               if (checkBox2.Checked == false)
               {
                    if (checkBox1.Checked)
                     {
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                     }
                      else
                     {
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                     }
                     Thread.Sleep(speed);
               }
               
           }
       }

     

        
    }
}
