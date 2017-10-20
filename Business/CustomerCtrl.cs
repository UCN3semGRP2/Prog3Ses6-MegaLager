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
        private CustomerDb CDB;

        public CustomerCtrl()
        {
            CDB = CustomerDb.GetInstance; 
        }
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

            return CDB.Create(c); 
        }

        public Customer CreatePrivateCustomer(string name, string phone, string address, string zip, string accountNo)
        {
            Priv p = new Priv();
            p.Name = name;
            p.Phone = phone;
            p.CustomerNo = phone; 
            p.Address = address;
            p.Zip = zip;
            p.AccountNo = accountNo;

            return CDB.Create(p); 
            
        }

        public void DeleteCustomer(Customer customer)
        {

            CDB.Delete(customer);

        }

        public Customer FindCustomer(string customerNo)
        {
            return CDB.FindByCustomerNo(customerNo); 
        }

        public void UpdatePrivateCustomer(Priv p, String name, String phone, String zip, String AccountNo, String address)
        {
            Priv priv = p;
            p.Name = name;
            p.Phone = phone;
            p.Zip = zip; 
            p.AccountNo = AccountNo;
            p.Address = address;

            CDB.Update(p);
        }

        public void UpdateComCustomer(Commercial c, String name, String phone, String zip, String AccountNo, String address, String cvr, String ean)
        {
            Commercial commercial = c;
            c.Name = name;
            c.Phone = phone;
            c.Zip = zip;
            c.AccountNo = AccountNo;
            c.Address = address;
            c.Cvr = cvr;
            c.Ean = ean; 
            CDB.Update(c);
        }
    }
}
