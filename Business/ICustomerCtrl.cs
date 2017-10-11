using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ICustomerCtrl
    {
        Customer CreatePrivateCustomer(String name, String phone, String address, String zip, String accountNo);
        Customer CreateComCustomer(String name, String phone, String address, String zip, String accountNo, String cvr, String ean);
        Customer FindCustomer(String customerNo);
        void UpdatePrivateCustomer(Priv p, String name, String phone, String zip, String AccountNo, String address);
        void UpdateComCustomer(Commercial c, String name, String phone, String zip, String AccountNo, String address, String cvr, String ean); 
        void DeleteCustomer(Customer customer);
        
    }
}
