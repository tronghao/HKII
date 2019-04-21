using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gio_ngu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gThuc, pThuc, gNgu, pNgu, cKi;


            if (Int32.TryParse(gN.Text, out gNgu) == false || Int32.TryParse(pN.Text, out pNgu) == false || Int32.TryParse(cK.Text, out cKi) == false)
                kq.Text = "Bạn Nhập Sai! Nhập Lại đi bạn!";
            else
            {
                int tam = gNgu * 60 + pNgu + 90 * cKi + 14;
                gThuc = (tam / 60);
                pThuc = (tam % 60);


               while (gThuc > 24)
               {
                 gThuc -= 24;
               }

               kq.Text = "Giờ Bạn Thức: " + gThuc + " giờ " + pThuc + " phút (14 phút vào giấc ngủ)";

            }
            
        }
    }
}
