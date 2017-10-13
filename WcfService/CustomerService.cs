using Business;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in both code and config file together.
    public class CustomerService : ICustomerService
    {
        private CustomerCtrl customerCtrl;
        public Customer CreateComCustomer(string name, string phone, string address, string zip, string accountNo, string cvr, string ean)
        {
            return customerCtrl.CreateComCustomer(name, phone, address, zip, accountNo, cvr, ean);
        }
        public Customer CreatePrivCustomer(String name, String phone, String address, String zip, String accountNo)
        {
            return customerCtrl.CreatePrivateCustomer(name, phone, address, zip, accountNo);
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
