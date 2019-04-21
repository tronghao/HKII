using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace calculator
{
    public partial class Form1 : Form
    {
        Hashtable ht;
        List<List<Button>> data;
        public List<string> kq = new List<string>();
        public string show;
        public int kqshow;
        public int i=0;
        public bool isadd = false;
        public bool isnoadd = false;
        public bool isnhan = false;
        public bool ischia = false;
        public Form1()
        {
            InitializeComponent();
            loadBtn();
            createHT();
            setvalue();
           // data[0][0].Text = ht["12"].ToString();
       

          
            
        }
        void setvalue()
        {
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Count; j++)
                {
                    data[i][j].Text = ht[i.ToString() + j.ToString()].ToString();
                }
            }
            data[4][2].Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold);
            data[2][3].Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold);
        }
        void createHT()
        {
            ht = new Hashtable();
            ht.Add("00", "PI");
            ht.Add("01", "(");
            ht.Add("02", ")");
            ht.Add("03", "<=");
            ht.Add("04", "CE");
            ht.Add("10", "7");
            ht.Add("11", "8");
            ht.Add("12", "9");
            ht.Add("13", "+");
            ht.Add("14", "Ans");
            ht.Add("20", "4");
            ht.Add("21", "5");
            ht.Add("22", "6");
            ht.Add("23", "-");
            ht.Add("24", "X^3");
            ht.Add("30", "1");
            ht.Add("31", "2");
            ht.Add("32", "3");
            ht.Add("33", "*");
            ht.Add("34", "X^2");
            ht.Add("40", "+/-");
            ht.Add("41", "0");
            ht.Add("42", ".");
            ht.Add("43", "/");
            ht.Add("44", "=");
        }
       
        void loadBtn()
        {
            string keyht = "";
            data = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < cons.HEIGHT; i++)
            {
                data.Add(new List<Button>());
                for (int j = 0; j < cons.WIDTH; j++)
                {
                    keyht = i.ToString() + j.ToString();
                    Button btn = new Button()
                    {
                        Width = cons.WIDTH_SIZE,
                        Height = cons.HEIGHT_SIZE,
                        Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold)
                    };
                    if (j != 0) 
                        btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + cons.SPACE, oldbtn.Location.Y);
                    else
                        btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    data[i].Add(btn);
                    btn.Click += new EventHandler(btn_Click);
                    pnControl.Controls.Add(btn);
                    
                    //btn.Click += new EventHandler(btn_Click);
                    oldbtn = btn;
                }
                oldbtn = new Button()
                {
                    Location = new Point(0, oldbtn.Location.Y + cons.HEIGHT_SIZE + cons.SPACE),
                    Width = 0,
                    Height = 0
                };
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "=")
            {

            }
            else if (btn.Text == "<=")
            {
                if(kq.Count!=0)
                kq[kq.Count-1] = null;
                if (tbkq.Text == "0") ;
                else if (tbkq.Text[tbkq.Text.Length - 1] == 's')
                    tbkq.Text = tbkq.Text.Remove(tbkq.Text.Length - 3, 3);
                else if (tbkq.Text[tbkq.Text.Length - 1] == 'I')
                    tbkq.Text = tbkq.Text.Remove(tbkq.Text.Length - 2, 2);
                else
                    tbkq.Text = tbkq.Text.Remove(tbkq.Text.Length - 1, 1);
                
                //if(tbkq.Text == )
            }
            else if (btn.Text == "CE")
            {
                tbkq.Text = "0";
            }
            else if (btn.Text == "X^3")
            {

            }
            else if (btn.Text == "X^2")
            {

            }
            else if (btn.Text == "+/-")
            {
                if (tbkq.Text[0] == '-' && tbkq.Text[1] == '{')
                {
                    string k = tbkq.Text;
                    tbkq.Text = k.Remove(0, 2);
                    
                }
                else
                {
                    tbkq.Text = "-{" + tbkq.Text;
                }
            }
            else
            {
                if (tbkq.Text == "0")
                    tbkq.Text = "";
                kq.Add(btn.Text);
                show = kq[i];
                i++;
                tbkq.Text = tbkq.Text + show;
            }
           

        }

     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
