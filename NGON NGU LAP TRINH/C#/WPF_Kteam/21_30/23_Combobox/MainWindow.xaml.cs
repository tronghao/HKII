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

namespace _23_Combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        List<Food> lf;
        public MainWindow()
        {
            InitializeComponent();
            lf = new List<Food>()
            {
               new Food(){Name="Ếch Núp Lùm", Price = 200000f},
               new Food(){Name="Thỏ Nướng", Price = 300000f},
               new Food(){Name="Ếch chiên xù", Price = 50000f}
            };
            cbxfood.ItemsSource = lf;
            color.ItemsSource = typeof(Brushes).GetProperties();
        }
    }
    public class Food
    {
        private string name;

        public string Name
        {
             get { return name; }
             set { name = value; }
        }  

        private float price;

        public float Price
        {
             get { return price; }
             set { price = value; }
        }
    }
}
