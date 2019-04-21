using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listview_KT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadlist();
        }

        ImageList large;
        ImageList small;

        void loadlist()
        {
            large = new ImageList() { ImageSize = new Size(68, 68) };
            large.Images.Add(new Bitmap(Application.StartupPath + "\\image\\030.jpg"));
            large.Images.Add(new Bitmap(Application.StartupPath + "\\image\\049.jpg"));
            large.Images.Add(new Bitmap(Application.StartupPath + "\\image\\050.jpg"));

            small = new ImageList() { ImageSize = new Size(16, 16) };
            small.Images.Add(new Bitmap(Application.StartupPath + "\\image\\030.jpg"));
            small.Images.Add(new Bitmap(Application.StartupPath + "\\image\\049.jpg"));
            small.Images.Add(new Bitmap(Application.StartupPath + "\\image\\050.jpg"));

            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = large;
            listView1.SmallImageList = small;

            
                       

            listView1.Columns.Add("Họ Tên");
            listView1.Columns.Add("Lớp");
            listView1.Columns.Add("Tuổi");

            ListViewItem t1 = new ListViewItem();
            t1.Text = "Đổ Trọng Hảo";
            t1.ImageIndex = 0;
            t1.SubItems.Add(new ListViewItem.ListViewSubItem() {Text = "DA17TT" });
            t1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "19" });

            ListViewItem t2 = new ListViewItem();
            t2.Text = "Nguyễn Khánh Duy";
            t2.ImageIndex = 1;
            t2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "DA17QTM" });
            t2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "19" });

            listView1.Items.Add(t1);
            listView1.Items.Add(t2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            listView1.CheckBoxes = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.CheckBoxes = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
        }
    }
}
