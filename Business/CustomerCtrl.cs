using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    public class CustomerCtrl : ICustomerCtrl
    {
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

            return c; 
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

            return p; 
            
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer FindCustomer(string customerNo)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
