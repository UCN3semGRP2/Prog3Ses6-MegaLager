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
        Customer CreateCustomer(String name, String phone, String customerNo, String address, String zip, String accountNo);
        Customer FindCustomer(String customerNo);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        
    }
}
