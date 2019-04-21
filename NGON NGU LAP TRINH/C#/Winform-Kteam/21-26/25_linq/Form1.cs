using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _25_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadcb();
        }
        List<Food> lf;
        void loadcb()
        {
            lf = new List<Food>();
            lf.Add(new Food("Mực Nướng sa tế", 100000f));
            lf.Add(new Food("Ếch Núp Lùm", 40000f));
            lf.Add(new Food("Rồng Phun Nước", 50000f));
            lf.Add(new Food("Thiếu nữ tt", 500000f));
            lf.Add(new Food("Bánh Tráng nướng", 10000f));
            comboBox1.DataSource = lf;
            comboBox1.DisplayMember = "nameF";
        }
        List<Food> lf2;
        private void button1_Click(object sender, EventArgs e)
        {
            lf2 = new List<Food>();
            lf2 = lf.Where(p => p.nameF == textBox1.Text).ToList();
            comboBox2.DataSource = lf2;
            comboBox2.DisplayMember = "nameF";
        }
    }
    public class Food
    {

        public string nameF { get; set; }
        public float price { get; set; }

        public Food()
        {
        }
        public Food(string name, float gia)
        {
            this.nameF = name;
            this.price = gia;
        }
    }
}
