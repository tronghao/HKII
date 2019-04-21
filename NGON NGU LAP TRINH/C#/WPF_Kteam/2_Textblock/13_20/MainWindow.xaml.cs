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

namespace _13_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            img.Source = new BitmapImage(new Uri(@"E:\GOC HOC TAP\Cong Nghe Thong Tin\HKII\NGON NGU LAP TRINH\C#\WPF_Kteam\2_Textblock\13_20\bin\Debug\04.jpg"));
        }
    }
}
