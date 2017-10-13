using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Business
{
    public class CustomerCtrl : ICustomerCtrl
    {
        private ICustomerDB customerDB;
        public Customer CreateComCustomer(string name, string phone, string address, string zip, string accountNo, string cvr, string ean)
        {
            Commercial c = new Commercial();

            c.Name = name;
            c.Phone = phone;
            c.Address = address;
            c.Zip = zip;
            c.AccountNo = accountNo;
            c.Cvr = cvr; 
            c.CustomerNo = cvr;
            c.Ean = ean;  

            return customerDB.Create(c); 
        }

        public Customer CreatePrivateCustomer(string name, string phone, string address, string zip, string accountNo)
        {
            Private p = new Private();
            p.Name = name;
            p.Phone = phone;
            p.CustomerNo = phone; 
            p.Address = address;
            p.Zip = zip;
            p.AccountNo = accountNo;

            return customerDB.Create(p); 
            
        }

        public void DeleteCustomer(Customer customer)
        {
            customerDB.Delete(customer);
        }

        public Customer FindCustomer(string customerNo)
        {
            var allCustomers = customerDB.FindAll().ToList();
            return allCustomers.Find(x => x.CustomerNo == customerNo);
        }

        public void UpdateCustomer(Customer customer)
        {
            customerDB.Update(customer);
        }
    }
}
