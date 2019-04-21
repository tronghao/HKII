using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Kéo_Bua_Bao
{
    
    public partial class Form2 : Form
    {
        public NumericUpDown nbr;
        public Label lb;
        public int tsmay;
        public int tsnguoi;
        public int lcmay;
        public string keo = "\\image\\03.jpg";
        public string bua = "\\image\\04.jpg";
        public string bao = "\\image\\05.jpg";
        public string buon = "\\image\\07.png";
        public string vui = "\\image\\06.jpg";
        public int lcnguoi;
        public bool isclick1 = false;
        public bool isclick2 = false;
        public bool isclick3 = false;
        public int click1dem = 0;
        public int click2dem = 0;
        public int click3dem = 0;
        public int value1;
        public bool isclickWin = false;
        public bool isclickMany = false;
        public bool isclickedWin = false;

        public Form2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            name.Text = "NeverStop";
            toolTip1.SetToolTip(name, "Không giới hạn Tỉ Số");
        }
        public void playback()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\start.wav");
            simpleSound.Play();
        }
        private void btK_Click(object sender, EventArgs e)
        {
            if (isclick2 || isclick3 || click1dem >0)
            {
                MessageBox.Show("Không thể click. Xin Chờ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isclick1 = true;
            click1dem++;
            lcnguoi = 0;
            Thread th = new Thread(random1);
            th.Start();
           
        }

        private void btB_Click(object sender, EventArgs e)
        {
            if (isclick1 || isclick3 || click2dem >0)
            {
                MessageBox.Show("Không thể click. Xin Chờ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            isclick2 = true;
            click2dem++;
            lcnguoi = 1;
            Thread th = new Thread(random1);
            th.Start();
            
        }

        private void BTBao_Click(object sender, EventArgs e)
        {
            if (isclick1 || isclick2 || click3dem >0)
            {
                MessageBox.Show("Không thể click. Xin Chờ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isclick3 = true;
            click3dem++;
            lcnguoi = 2;
            Thread th = new Thread(random1);
            th.Start();
            
        }
        public void random1()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                label2.Text = rand.Next(100,999).ToString();
                
            }
            int random2 = Convert.ToInt32(label2.Text);
            if (random2 % 3 == 0) label2.Text = "Kéo";
            else if (random2 % 3 == 1) label2.Text = "Búa";
            else label2.Text = "Bao";
            showkq(label2.Text);
            if (isclick1) isclick1 = false;
            if (isclick2) isclick2 = false;
            if (isclick3) isclick3 = false;
            click1dem = click2dem = click3dem = 0;
            win();
            many();
            
        }
        public void many()
        {
            if (isclickMany)
            {
                if (tsmay >= 1)
                {
                    MessageBox.Show("Điểm của bạn: " + tsnguoi, "Thông Báo");
                    tsmay = tsnguoi = 0;
                    TSN.Text = tsnguoi.ToString();
                    TSM.Text = tsmay.ToString();
                }
            }
        }
        public void win()
        {
            if (isclickWin)
            {
                if (tsmay == nbr.Value)
                {
                    MessageBox.Show("           Bạn Đã Thua!\n Tỉ Số (Computer-user): " + tsmay + "-" + tsnguoi, "Thông Báo");
                    tsmay = tsnguoi = 0;
                    TSN.Text = tsnguoi.ToString();
                    TSM.Text = tsmay.ToString();

                }
                else if (tsnguoi == nbr.Value)
                {
                    MessageBox.Show("           Bạn Đã Thắng!\n Tỉ Số (Computer-user): " + tsmay + "-" + tsnguoi, "Thông Báo");
                    tsmay = tsnguoi = 0;
                    TSN.Text = tsnguoi.ToString();
                    TSM.Text = tsmay.ToString();
                }
           }
        }
        public void showkq(string click)
        {
            lcmay = click == "Kéo" ? 0 : click == "Búa" ? 1 : 2;
            
            switch (lcnguoi)
            {
                case 0:
                    {
                        if (lcmay == 0)
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + keo);
                            pcstate.Image = new Bitmap(Application.StartupPath + vui);
                            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\ok.wav");
                            simpleSound.Play();
                            TSM.Text = tsmay.ToString();
                            TSN.Text = tsnguoi.ToString();
                        }
                        else if (lcmay == 1)
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + bua);
                            pcstate.Image = new Bitmap(Application.StartupPath + buon);
                            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Hardware Fail.wav");
                            simpleSound.Play();
                            tsmay++;
                            TSM.Text = tsmay.ToString();
                            TSN.Text = tsnguoi.ToString();
                        }
                        else
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + bao);
                            pcstate.Image = new Bitmap(Application.StartupPath + vui);
                            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\ok.wav");
                            simpleSound.Play();
                            tsnguoi++;
                            TSN.Text = tsnguoi.ToString();
                            TSM.Text = tsmay.ToString();
                        }
                        break;
                    }
                case 1:
                    {
                        if (lcmay == 1)
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + bua);
                            pcstate.Image = new Bitmap(Application.StartupPath + vui);
                            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\ok.wav");
                            simpleSound.Play();
                            
                            TSM.Text = tsmay.ToString();
                            TSN.Text = tsnguoi.ToString();
                        }
                        else if (lcmay == 2)
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + bao);
                            pcstate.Image = new Bitmap(Application.StartupPath + buon);
                            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Hardware Fail.wav");
                            simpleSound.Play();
                            tsmay++;
                            TSM.Text = tsmay.ToString();
                            TSN.Text = tsnguoi.ToString();
                        }
                        else
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + keo);
                            pcstate.Image = new Bitmap(Application.StartupPath + vui);
                            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\ok.wav");
                            simpleSound.Play();
                            tsnguoi++;
                            TSN.Text = tsnguoi.ToString();
                            TSM.Text = tsmay.ToString();
                        }
                        break;
                    }
                case 2:
                    {
                        if (lcmay == 2)
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + bao);
                            pcstate.Image = new Bitmap(Application.StartupPath + vui);
                            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\ok.wav");
                            simpleSound.Play();
                            TSM.Text = tsmay.ToString();
                            TSN.Text = tsnguoi.ToString();
                        }
                        else if (lcmay == 0)
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + keo);
                            pcstate.Image = new Bitmap(Application.StartupPath + buon);
                            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Hardware Fail.wav");
                            simpleSound.Play();
                            tsmay++;
                            TSM.Text = tsmay.ToString();
                            TSN.Text = tsnguoi.ToString();
                        }
                        else
                        {
                            BTM.BackgroundImage = new Bitmap(Application.StartupPath + bua);
                            pcstate.Image = new Bitmap(Application.StartupPath + vui);
                            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath +"\\ok.wav");
                            simpleSound.Play();
                            tsnguoi++;
                            TSN.Text = tsnguoi.ToString();
                            TSM.Text = tsmay.ToString();
                        }
                        break;
                    }
            }

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            tsmay = tsnguoi = 0;
            TSN.Text = tsnguoi.ToString();
            TSM.Text = tsmay.ToString();
        }

        private void resetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            tsmay = tsnguoi = 0;
            TSN.Text = tsnguoi.ToString();
            TSM.Text = tsmay.ToString();
        }

        private void BTM_Click(object sender, EventArgs e)
        {

        }

        private void winNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            tsmay = tsnguoi = 0;
            TSN.Text = tsnguoi.ToString();
            TSM.Text = tsmay.ToString();
            isclickWin = true;
            isclickMany = false;
            nbr = new NumericUpDown() { Location = new Point(70,11), Width = 50, Value = 3, Minimum = 1, Maximum =100};
            lb = new Label() { Text = "Tỉ Số Thắng:", Location = new Point(0, 13) };
            pnNumberic.Controls.Add(nbr);
            pnNumberic.Controls.Add(lb);
            //nbr.Enabled = true;
            name.Text = "WinNumber";
            toolTip1.SetToolTip(name, "Chiến Thắng với số điểm đạt trước");
        }

        private void winManyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(isclickedWin) nbr.Enabled = false;
            tsmay = tsnguoi = 0;
            TSN.Text = tsnguoi.ToString();
            TSM.Text = tsmay.ToString();
            isclickMany = true;
            isclickWin = false;
            isclickedWin = true;
            name.Text = "WinMany";
            toolTip1.SetToolTip(name, "Solo sinh tử");
        }

        private void neverStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(isclickedWin) nbr.Enabled = false;
            tsmay = tsnguoi = 0;
            TSN.Text = tsnguoi.ToString();
            TSM.Text = tsmay.ToString();
            isclickMany = false;
            isclickWin = false;
            name.Text = "NeverStop";
        }

        
        
    }
}
