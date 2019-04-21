using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int giay = 0;
        int gio=0;
        int phut = 0;
        public int second;
        System.Windows.Threading.DispatcherTimer dispatcherTimer;


        public MainWindow()
        {
            InitializeComponent();
            tenchuongtrinh.Text = "Hẹn Giờ Tắt Máy";
            hour.Text = "Giờ";
            minute.Text = "Phút";
            tblgiay.Text = "Giây";

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            second--;
            pgb.Value=second;
            value.Text = second.ToString();
        }
        void shutdownmt(string code)
        {
            System.Diagnostics.Process.Start("shutdown", code);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gio++;
            txthour.Text = gio.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (gio <= 0)
                gio = 0;
            else
            gio--;

            txthour.Text = gio.ToString();
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (Int32.TryParse(txthour.Text, out gio) == false)
            {
                gio = 0;
                txthour.Text = "0";
            }
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            if (phut >= 60)
                phut = 60;
            else
                phut++;

            txtminute.Text = phut.ToString();
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            if (phut <= 0)
                phut = 0;
            else
                phut--;

            txtminute.Text = phut.ToString();
            
        }

        private void sup_Click(object sender, RoutedEventArgs e)
        {
            if (giay >= 60)
                giay = 60;
            else
                giay++;

            txtgiay.Text = giay.ToString();

        }

        private void sdown_Click(object sender, RoutedEventArgs e)
        {
            if (giay <= 0)
                giay = 0;
            else
                giay--;

            txtgiay.Text = giay.ToString();
        }

        private void txtminute_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Int32.TryParse(txtminute.Text, out phut) == false)
            {
                phut = 0;
                txtminute.Text = "0";
            }
            if (phut >= 60)
            {
                int tam = phut;
                phut = tam % 60;
                txtminute.Text = phut.ToString();
                gio += tam / 60;
                txthour.Text = gio.ToString();
            }
        }

        private void txtgiay_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Int32.TryParse(txtgiay.Text, out giay) == false)
            {
                giay = 0;
                txtgiay.Text = "0";
            }
            if(giay>=60)
            {
                int tam = giay;
                giay=tam%60;
                txtgiay.Text = giay.ToString();
                phut += tam/60;
                txtminute.Text = phut.ToString();
            }
        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            second = (gio * 3600 + phut * 60 + giay);
            shutdownmt("-r -t " + second.ToString());
            dispatcherTimer.Start();
            pgb.Maximum = second;
            pgb.Value = second;
            state.Text = "restart...";
        }

        private void shutdown_Click(object sender, RoutedEventArgs e)
        {
            second = (gio * 3600 + phut * 60 + giay);
            shutdownmt("-s -t " + second.ToString());
            dispatcherTimer.Start();
            pgb.Maximum = second;
            pgb.Value = second;
            state.Text = "shutdown...";
        }

        private void cancle_Click(object sender, RoutedEventArgs e)
        {
            shutdownmt("-a");
            dispatcherTimer.Stop();
            pgb.Value = 0;
            state.Text = "waiting...";
            value.Text = "0";

        }
       
    }
}
