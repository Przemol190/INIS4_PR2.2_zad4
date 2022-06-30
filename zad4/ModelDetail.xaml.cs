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
    /// Logika interakcji dla klasy ModelDetail.xaml
    /// </summary>
    public partial class ModelDetail : Window
    {
        public ModelDetail(System.Xml.XmlElement detail)
        {
            DataContext = detail;
            InitializeComponent();
        }
    }
}
