using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _17_contextmenustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var item = new ToolStripLabel() { Text = "cut" };
            var item2 = new ToolStripLabel() { Text = "copy" };
            var item3 = new ToolStripLabel() { Text = "paste" };
            item.Click += new EventHandler(item_Click);
            item2.Click += new EventHandler(item2_Click);
            item3.Click += new EventHandler(item3_Click);
            contextMenuStrip1.Items.Add(item);
            contextMenuStrip1.Items.Add(item2);
            contextMenuStrip1.Items.Add(item3);
        }

        void item3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn paste!");
        }

        void item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn copy!");
        }

        void item_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn cut!");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //contextMenuStrip1.Show(this, this.PointToClient(MousePosition));
                //contextMenuStrip1.Show(textBox1, new Point(50,0));
            }
            
        }
    }
}
