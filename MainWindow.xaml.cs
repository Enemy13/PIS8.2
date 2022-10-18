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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    class NameItemCollection
    {
        public bool Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
        public string Column9 { get; set; }
        public string Column10 { get; set; }
        public string Column11 { get; set; }
        public string Column12 { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Reestr.Items.Add(new NameItemCollection { Column1 = true, Column2 = "Test", Column3 = "Test", Column4 = "Test", Column5 = "Test", Column6 = "Test", Column7 = "Test", Column8 = "Test", Column9 = "Test", Column10 = "Test", Column11 = "Test", Column12 = "Test" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Reestr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
