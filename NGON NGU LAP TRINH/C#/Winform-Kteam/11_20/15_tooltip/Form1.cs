using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15_tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolTip tt = new ToolTip() {ReshowDelay = 0 ,AutoPopDelay = 2000 ,IsBalloon = true ,ToolTipTitle = " Tooltip code",ToolTipIcon = ToolTipIcon.Error};
            tt.SetToolTip(button2, "Nội dung");
        }
    }
}
