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
using Business;
using Model;

namespace CustomerGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceReference.ICustomerService srv = new ServiceReference.CustomerServiceClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cb_Commercial_Checked(object sender, RoutedEventArgs e)
        {
            tb_Cvr.IsEnabled = true;
            tb_Ean.IsEnabled = true;
        }

        private void cb_Commercial_Unchecked(object sender, RoutedEventArgs e)
        {
            tb_Cvr.IsEnabled = false;
            tb_Ean.IsEnabled = false;
        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = null;
            if (cb_Commercial.IsChecked == true)
            {
                customer = srv.CreateComCustomer(tb_Name.Text, tb_Phone.Text, tb_Address.Text, tb_Zip.Text, tb_AccNo.Text, tb_Cvr.Text, tb_Ean.Text);
            }
            else if (cb_Commercial.IsChecked == false)
            {
                customer = srv.CreatePrivCustomer(tb_Name.Text, tb_Phone.Text, tb_Address.Text, tb_Zip.Text, tb_AccNo.Text);
            }
            else
            {
                MessageBox.Show("HVA FUCK!?");
            }

            MessageBox.Show(customer.ToString());
        }

        private void btn_findByCustomerNo_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void btn_findByCustomerNo_Click(object sender, RoutedEventArgs e)
        //{
        //    Customer customer = cCtrl.FindCustomer(tb_findByCustomerNo.Text);
        //    MessageBox.Show("Customer found: " + customer.ToString());
        //}
    }
}
