using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WcfService;

namespace InventoryGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static WcfService.IService1 proxy = new WcfService.Service1();

        public MainWindow()
        {
            InitializeComponent();

            ProductGrid.ItemsSource = proxy.FindProductByName(""); // TODO FindAllProducts
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("YO!");
        }
    }
}
