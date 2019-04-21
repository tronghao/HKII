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
using OpenQA.Selenium.Chrome;
using System.IO;

namespace ToolXemDiem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromeDriver ch;
        List<Info> lv;
        public MainWindow()
        {
            ch = new ChromeDriver();

            ch.Url = "http://ttsv.tvu.edu.vn/default.aspx?page=nhapmasv&flag=XemDiemThi";
            ch.Navigate();
            ch.Manage().Window.Minimize();

            InitializeComponent();
            lv = new List<Info>()
            {
                new Info(){Name = "Đổ Trọng Hảo", Mssv = "110117051"},
                new Info(){Name = "Nguyễn Khánh Duy", Mssv = "110117047"},
                new Info(){Name = "Võ Lê Khánh Duy", Mssv = "110117048"},
                new Info(){Name = "Lê Hoàng Duy", Mssv = "110117049"},
                new Info(){Name = "Dương Quốc Tuấn", Mssv = "110117065"},
                new Info(){Name = "Phạm Huỳnh Việt Tú", Mssv = "110117064"},
                new Info(){Name = "Nguyễn Thùy Dương", Mssv = "110117046"},
                new Info(){Name = "Lê Nhất Sinh", Mssv = "110117029"},
                new Info(){Name = "Bùi Thanh Sơn", Mssv = "110117057"},
                new Info(){Name = "Lê Minh Trọng", Mssv = "110117062"},
                new Info(){Name = "Nguyễn Huỳnh Công Minh", Mssv = "110117076"},
                new Info(){Name = "Trần Quốc Việt", Mssv = "110117041"},

                new Info(){Name = "Nguyễn Tuấn Đạt", Mssv = "110416011"},
                new Info(){Name = "Nguyễn Nhựt Hào", Mssv = "110417012"},
                new Info(){Name = "Huỳnh Công Quí", Mssv = "111816030"},
                new Info(){Name = "Bùi Thị Cẩm Tú", Mssv = "115616074"},
                new Info(){Name = "Hồ Chí Trung", Mssv = "110116082"},
                new Info(){Name = "Thang Công Minh", Mssv = "110917024"},
                new Info(){Name = "Nguyễn Minh Chiến", Mssv = "110416008"},
                new Info(){Name = "Lê Công Trí", Mssv = "110416116"},
                new Info(){Name = "Nguyễn Hoàng Nhựt", Mssv = "210116033"}
            };
            cbx.ItemsSource = lv;
            cbx.DisplayMemberPath = "Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ChromeOptions option = new ChromeOptions();

            //option.AddArgument(@"C:\Users\TrongHao\AppData\Local\Temp\scoped_dir1296_26184");
            ch.Url = "http://ttsv.tvu.edu.vn/default.aspx?page=nhapmasv&flag=XemDiemThi";
            ch.Navigate();
            
            ch.Manage().Window.Maximize();
            

            var addtext = ch.FindElementById("ctl00_ContentPlaceHolder1_ctl00_txtMaSV");
            addtext.SendKeys(txbl.Text);

            var ok = ch.FindElementByXPath("//*[@id=\"ctl00_ContentPlaceHolder1_ctl00_btnOK\"]");
            ok.Click();

            var chon = ch.FindElementById("ctl00_ContentPlaceHolder1_ctl00_lnkChangeview2");
            chon.Click();
            
        }

        private void cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            txbl.Text = (cb.SelectedValue as Info).Mssv.ToString();
        }
        
    }
    public class Info
    {
        public string Name { get; set; }
        public string Mssv { get; set; }
    }
}
