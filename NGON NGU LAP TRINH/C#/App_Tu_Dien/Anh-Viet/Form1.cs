using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Anh_Viet
{
    public partial class Form1 : Form
    {
        speakText EN;
        speakText VN;
        DictionaryManager dicm;
        bool isloading1 = true;
        bool isloading2 =true;
        public Form1()
        {
            InitializeComponent();
            changeloading();
            dicm = new DictionaryManager();
            dicm.loadtoCB(CBEng);
            EN = new speakText();
            VN = new speakText();
            

            WebBrowser EngW = new WebBrowser();
            EngW.Width = 0;
            EngW.Height = 0;
            EngW.Visible = false;
            EngW.ScriptErrorsSuppressed = true;
            EngW.Navigate("http://responsivevoice.org/text-to-speech-languages/us-english-text-to-speech/");
            EngW.DocumentCompleted+=new WebBrowserDocumentCompletedEventHandler(EngW_DocumentCompleted);
            this.Controls.Add(EngW);

            WebBrowser vnW = new WebBrowser();
            vnW.Width = 0;
            vnW.Height = 0;
            vnW.Visible = false;
            vnW.ScriptErrorsSuppressed = true;
            vnW.Navigate("http://responsivevoice.org/text-to-speech-languages/van-ban-de-noi-trong-tieng-viet/");
            vnW.DocumentCompleted+=new WebBrowserDocumentCompletedEventHandler(vnW_DocumentCompleted);
            this.Controls.Add(vnW);

            EN.Add(EngW);
            VN.Add(vnW);

        }

void  vnW_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
{
    isloading1 = false;
    changeloading();
}

void  EngW_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
{
    isloading2 = false;
    changeloading();
}
void changeloading()
{
    this.Enabled = !(isloading1 && isloading2);
}
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            //dicm.ghi();
        }

        private void CBEng_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null) return;

            DictionaryData data = cb.SelectedItem as DictionaryData;
            TBVN.Text = data.Meaning;
            TBMT.Text = data.Explaination;
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (eng.Text == "" || vn.Text == "")
            {
                label8.Text = "Lỗi Nhập Liệu";
                label8.ForeColor = Color.Red;
            }
            else
            {
                dicm.them(eng, vn, MT, CBEng);
                label8.Text = "Thành Công";
                label8.ForeColor = Color.Blue;
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EN.speak((CBEng.SelectedItem as DictionaryData).Key);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VN.speak(TBVN.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            VN.speak(TBMT.Text);
        }

 
    }
}
