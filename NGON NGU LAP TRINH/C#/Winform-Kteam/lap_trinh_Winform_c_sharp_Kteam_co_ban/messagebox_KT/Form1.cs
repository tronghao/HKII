using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace messagebox_KT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nội Dung", "Cái này là Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            DialogResult kq = MessageBox.Show("Nội Dung", "Cái này là Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            switch (kq)
            {
                case System.Windows.Forms.DialogResult.OK: MessageBox.Show("Bạn đã hiểu"); break;
                case System.Windows.Forms.DialogResult.Cancel: MessageBox.Show("Hủy thành công"); break;
            }
        }
    }
}
