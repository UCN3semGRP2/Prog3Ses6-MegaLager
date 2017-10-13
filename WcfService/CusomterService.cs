using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Business;

namespace WcfService
{
    public class CusomterService : ICustomerService
    {
        private CustomerCtrl customerCtrl;
        public Customer CreateComCustomer(string name, string phone, string address, string zip, string accountNo, string cvr, string ean)
        {
            return customerCtrl.CreateComCustomer(name, phone, address, zip, accountNo, cvr, ean);
        }
        public Customer CreatePrivCustomer(String name, String phone, String address, String zip, String accountNo)
        {
            return customerCtrl.CreatePrivateCustomer(name, phone, address, zip , accountNo);
        }

        public void DeleteCustomer(Customer customer)
        {
            customerCtrl.DeleteCustomer(customer);
        }

        public void UpdateCustomer(string name, string phone, string CustomerNo, string Zip, string AccountNo, string address)
        {
            throw new NotImplementedException();
        }
    }
}
