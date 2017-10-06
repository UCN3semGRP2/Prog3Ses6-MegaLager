using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    interface ISalesCtrl
    {
        void CreateCustomer(String name, String phone, String customerNo, String address, String zip, String accountNo);
        void AddCustomer(Customer customer);
        void CreateOrder();
        void UpdateOrder();
        void AddOrderLine();

    }
}
