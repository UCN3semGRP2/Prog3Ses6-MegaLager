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
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        
    }
}
