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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread th = new Thread(playback);
            th.IsBackground = true;
            th.Start();
            
            
            
        }
        public void playback()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + "\\start.wav");
            simpleSound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Notify Calendar.wav");
        }

      
    }
}
