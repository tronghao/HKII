using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace lap_trinh_Winform_c_sharp_Kteam_co_ban
{
    public partial class lable2 : Form
    {
        public lable2()
        {
            InitializeComponent();
            loadlb();
        }
        void loadlb()
        {
            Label lb = new Label();
            lb.Text = "Lable tạo bằng code";
            lb.AutoSize = true;
            this.Controls.Add(lb);
            lb.BackColor = Color.Purple;
            lb.ForeColor = Color.White;
            lb.Font = new Font("Times New Romans", 16F);
            lb.Location = new Point(40, 110);
            //Thread.Sleep(10000);  chờ hay chế độ ngủ
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
