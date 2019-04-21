using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doc
{
    public partial class Form1 : Form
    {
        WebBrowser wbVN;
        WebBrowser wbE;
        bool is1 = true;
        bool is2 = true;
        public Form1()
        {
            InitializeComponent();
            change();

            wbVN = new WebBrowser();
            wbVN.Width = 0;
            wbVN.Height = 0;
            wbVN.Visible = false;
            wbVN.ScriptErrorsSuppressed = true;
            wbVN.Navigate("https://translate.google.com/?hl=vi/");
            wbVN.DocumentCompleted+=new WebBrowserDocumentCompletedEventHandler(wbVN_DocumentCompleted);
            this.Controls.Add(wbVN);

            wbE = new WebBrowser();
            wbE.Width = 0;
            wbE.Height = 0;
            wbE.Visible = false;
            wbE.ScriptErrorsSuppressed = true;
            wbE.Navigate("https://translate.google.com/?hl=vi");
            wbE.DocumentCompleted+=new WebBrowserDocumentCompletedEventHandler(wbE_DocumentCompleted);
            this.Controls.Add(wbE);
        }

void  wbE_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
{
 	is2 = false;
    change();
}

void  wbVN_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
{
 	is1 = false;
    change();
}

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label3.Text = "    Vui Lòng Nhập Text!";
                label3.ForeColor = Color.Red;
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {

                label3.Text = "Vui Lòng Chọn Ngôn Ngữ!";
                label3.ForeColor = Color.Red;
            }
            else if(radioButton1.Checked)
            {
                HtmlElement ele5 = wbVN.Document.GetElementById("sugg-item-en");
                ele5.InvokeMember("click");

                HtmlElement ele3 = wbE.Document.GetElementById("source");
                ele3.SetAttribute("value", textBox1.Text);

                HtmlElement ele4 = wbE.Document.GetElementById("gt-src-listen");
                ele4.InvokeMember("click");
            }
            else if (radioButton2.Checked)
            {

                HtmlElement ele6 = wbVN.Document.GetElementById("sugg-item-vi");
                ele6.InvokeMember("click");

                HtmlElement ele = wbVN.Document.GetElementById("source");
                ele.SetAttribute("value", textBox1.Text);

                HtmlElement ele2 = wbVN.Document.GetElementById("gt-src-listen");
                ele2.InvokeMember("click");
            }
        }
        public void change()
        {
            this.Enabled = !(is1 && is2);
        }
    }
}
