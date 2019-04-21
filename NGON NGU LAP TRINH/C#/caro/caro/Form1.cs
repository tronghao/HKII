using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace caro
{
    public partial class Form1 : Form
    {
        public List<player> pl;
        public int curenplayer =0;
        public List<List<Button>> maTrix;
        public Form1()
        {
            InitializeComponent();
            loadBanCo();
            pl = new List<player>()
            {
                new player("Monter", Image.FromFile(Application.StartupPath + "\\image\\04.jpg")),
                new player("SuperMan", Image.FromFile(Application.StartupPath + "\\image\\05.jpg"))
            };

            changePlayer();

            timer1.Interval = cons.INTERVAL;
            progressBar1.Step = cons.STEP;
            
        }
        #region endgame
        public void endGame()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\end.wav");
            simpleSound.Play(); 
            pnbanco.Enabled = false;
            timer1.Stop();
            progressBar1.Value = 0;
            
            MessageBox.Show("Kết Thúc Game!", "Thông Báo");
              
        }

        public bool isEndGame(Button btn)
        {
            return ngang(btn) || doc(btn) || cheoChinh(btn) || cheoPhu(btn);
        }
        public Point getPoint(Button btn)
        {
            int doc = Convert.ToInt32(btn.Tag);
            int ngang = maTrix[doc].IndexOf(btn);
            Point pt = new Point(ngang, doc);
            return pt;
        }

        public bool ngang(Button btn)
        {
            Point pt = getPoint(btn);
            
            int countL = 0;            
            for (int i = pt.X; i >= 0; i--)
            {
                if ((maTrix[pt.Y][i]).BackgroundImage == btn.BackgroundImage)
                {
                    countL++;
                }
                else
                {
                    break;
                }
            }
            int countR = 0;
            for (int i = pt.X+1; i < cons.WIDTH_BC; i++)
            {
                if ((maTrix[pt.Y][i]).BackgroundImage == btn.BackgroundImage)
                {
                    countR++;
                }
                else
                {
                    break;
                }
            }

                return countL + countR >= 5;
        }


        public bool doc(Button btn)
        {
            Point pt = getPoint(btn);

            int countT = 0;
            for (int i = pt.Y; i >= 0; i--)
            {
                if ((maTrix[i][pt.X]).BackgroundImage == btn.BackgroundImage)
                {
                    countT++;
                }
                else
                {
                    break;
                }
            }
            int countB = 0;
            for (int i = pt.Y + 1; i < cons.HEIGHT_BC; i++)
            {
                if ((maTrix[i][pt.X]).BackgroundImage == btn.BackgroundImage)
                {
                    countB++;
                }
                else
                {
                    break;
                }
            }

            return countT + countB >= 5;
        }


        public bool cheoChinh(Button btn)
        {
            Point point = getPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (maTrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= cons.WIDTH_BC - point.X; i++)
            {
                if (point.Y + i >= cons.HEIGHT_BC || point.X + i >= cons.WIDTH_BC)
                    break;

                if (maTrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom >= 5;

        }


        public bool cheoPhu(Button btn)
        {
            Point point = getPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > cons.WIDTH_BC || point.Y - i < 0)
                    break;

                if (maTrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= cons.WIDTH_BC - point.X; i++)
            {
                if (point.Y + i >= cons.HEIGHT_BC || point.X - i < 0)
                    break;

                if (maTrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom >= 5;
        }
        #endregion
        #region tạo bàn cờ
        void loadBanCo()
        {
            timer1.Stop();
            progressBar1.Value = 0;
            
            pnbanco.Controls.Clear();
            pnbanco.Enabled = true;
            maTrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width =0, Location = new Point(0,0)};
            for (int i = 0; i <cons.HEIGHT_BC; i++)
            {
                maTrix.Add(new List<Button>());
                for (int j = 0; j < cons.WIDTH_BC; j++)
                {
                    Button btn = new Button() 
                    { 
                        Location = new Point(oldbtn.Width + oldbtn.Location.X, oldbtn.Location.Y) ,
                        Width = cons.WIDTH_SIZE_BC,
                        Height = cons.HEIGHT_SIZE_BC,
                        Tag = i.ToString()
                    };
                    
                    btn.Click += new EventHandler(btn_Click);
                    pnbanco.Controls.Add(btn);
                    maTrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location =new Point(0, oldbtn.Location.Y + oldbtn.Height) ;
                oldbtn.Width = 0;
                oldbtn.Height = 0;        
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            if (btn.BackgroundImage != null)
                return;
            timer1.Stop();
            progressBar1.Value = 0;        
            mark(btn);
            changePlayer();
            timer1.Start();
            if (isEndGame(btn))
            {
                endGame();
            }
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\ok.wav");
            simpleSound.Play();      
        }

        public void mark(Button btn)
        {
            btn.BackgroundImage = pl[curenplayer].Mark;

            curenplayer = curenplayer == 0 ? 1 : 0;
        }
        public void changePlayer()
        {
            name.Text = pl[curenplayer].Name;
            name.ForeColor = Color.Red;
            pbxo.BackgroundImage = pl[curenplayer].Mark;
            pbxo.BackgroundImageLayout = ImageLayout.Stretch;   
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                endGame();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadBanCo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
