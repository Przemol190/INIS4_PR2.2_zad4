using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace zad4
{
    /// <summary>
    /// Logika interakcji dla klasy GroupWindow.xaml
    /// </summary>
    public partial class GroupWindow : Window
    {
        public GroupWindow(System.Xml.XmlElement group)
        {
            DataContext = group;
            Console.WriteLine(group);
            InitializeComponent();
        }

        private void ShowBrand(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox lista = (ListBox)parent.FindName("Brand");
            new BrandWindow((System.Xml.XmlElement)lista.SelectedItem).Show();
        }
    }
}
