using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nam_Am_Lich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Nam;
            if (Int32.TryParse(year.Text, out Nam) == false)
            {
                kq.Text = "Lỗi Nhập Liệu!";
            }
            else if (Nam < 0)
            {
                kq.Text = "Lỗi Nhập Liệu!";
            }
            else{
                string[] Can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
                string[] Chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thình", "Tỵ", "Ngọ", "Mùi" };
                int start, end;
                start = Nam % 10;
                end = Nam % 12;
                kq.Text= Can[start] + " " +Chi[end];
            }
        }    
    }
}
