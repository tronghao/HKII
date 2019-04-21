using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadlich();
        }
        public List<string> dayofweek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public List<List<Button>> data; 
        void loadlich()
        {
            data = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(0 - 2, 0) };
            for (int i = 0; i < cons.HEIGHT; i++)
            {
                data.Add(new List<Button>());
                for (int j = 0; j < cons.WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = cons.WIDTH_SIZE,
                        Height = cons.HEIGHT_SIZE,

                    };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + cons.SPACE, oldbtn.Location.Y);
                    data[i].Add(btn);
                    pnlich.Controls.Add(btn);

                    //btn.Click += new EventHandler(btn_Click);
                    oldbtn = btn;
                }
                oldbtn = new Button()
                {
                    Location = new Point(0 - 2, oldbtn.Location.Y + cons.HEIGHT_SIZE),
                    Width = 0,
                    Height = 0
                };
            }
            addTextBtn(DateTime.Now);
        }
        void clear()
        {
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Count; j++)
                {
                    data[i][j].Text = "";
                    data[i][j].BackColor = Color.Silver;
                    data[i][j].Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
                }
            }
        }
        void setday()
        {
            dateTimePicker1.Value = DateTime.Now;
        }
        void addTextBtn(DateTime date)
        {
            clear();
            bool issunday1 = false;
            int line = 0;
            DateTime dt = new DateTime(date.Year, date.Month, 1);
            if (dayofweek.IndexOf(dt.DayOfWeek.ToString()) == 0)
            {
                issunday1 = true;
                line++;
            }
           
           
            for (int i = 1; i <= dayofmonth(dt); i++)
            {
                int column = dayofweek.IndexOf(dt.DayOfWeek.ToString());
                if (dayistrue(dt, DateTime.Now))
                {
                    data[line][column].Text = dt.Day.ToString();
                    data[line][column].BackColor = Color.Yellow;
                    data[line][column].ForeColor = Color.Purple;
                    data[line][column].Font = new Font("Microsoft Sans Serif", 8.25f ,FontStyle.Bold);
                }
                else if (dayistrue(dt, dateTimePicker1.Value))
                {
                    data[line][column].Text = dt.Day.ToString();
                    data[line][column].BackColor = Color.White;
                    data[line][column].ForeColor = Color.Purple;
                    data[line][column].Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                }
                else
                {
                    data[line][column].Text = dt.Day.ToString();
                    data[line][column].BackColor = Color.SkyBlue;
                    data[line][column].ForeColor = Color.Purple;
                }
                
                dt = dt.AddDays(1);
                if (column >= 6) 
                    line++;
            }
        }

        public bool dayistrue(DateTime dta, DateTime dtb)
        {
            return dta.Day == dtb.Day && dta.Month == dtb.Month && dta.Year == dtb.Year;
        }
        public int dayofmonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
                
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn =sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            addTextBtn((sender as DateTimePicker).Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setday();
            addTextBtn(dateTimePicker1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
 
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
        }
        
    }
}
