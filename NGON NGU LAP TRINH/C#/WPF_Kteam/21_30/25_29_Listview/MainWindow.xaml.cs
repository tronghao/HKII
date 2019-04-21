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
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

namespace _25_29_Listview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool issort;
        List<Info> lv;
        public MainWindow()
        {
            InitializeComponent();
            issort = false;
            lv = new List<Info>()
            {
                new Info(){Name="Đổ Trọng Hảo", Age="19", Mail="110117051@sv.tvu.edu.vn", GT = SexType.Male},
                new Info(){Name="Nguyễn Khánh Duy", Age="18", Mail="110117047@sv.tvu.edu.vn",  GT = SexType.Male},
                new Info(){Name="Dương Quốc Tuấn", Age="20", Mail="110117065@sv.tvu.edu.vn",  GT = SexType.Male},
                new Info(){Name="Nguyễn Thùy Dương", Age="19", Mail="110117046@sv.tvu.edu.vn", GT = SexType.Female},
                new Info(){Name="Võ Minh Châu", Age="18", Mail="110117045@sv.tvu.edu.vn",  GT = SexType.Female}
            };   
            lsview.ItemsSource = lv;
            CollectionView view = (CollectionView) CollectionViewSource.GetDefaultView(lsview.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("GT");
            view.GroupDescriptions.Add(groupDescription);
            view.Filter = UserFilter;

        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = sender as GridViewColumnHeader;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsview.ItemsSource);
            if (issort)
            {
                //view.SortDescriptions.Remove(new SortDescription(header.Content.ToString(), ListSortDirection.Descending));
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription(header.Content.ToString(), ListSortDirection.Ascending));
            }
            else
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription(header.Content.ToString(), ListSortDirection.Descending));
            }
            issort = !issort;
        }
        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as Info).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lsview.ItemsSource).Refresh();
        }
    }
    public enum SexType { Male, Female };
    public class Info
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public SexType GT { get; set; }
    }

}
