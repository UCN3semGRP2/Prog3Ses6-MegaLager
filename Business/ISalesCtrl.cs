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
        Customer CreatePrivateCustomer(String name, String phone, String address, String zip, String accountNo);
        Customer CreateComCustomer(String name, String phone, String address, String zip, String accountNo, String cvr, String ean);
        void AddCustomer(Customer customer);
        void CreateOrder(State state);
        void UpdateOrder();
        void AddOrderLine();

    }
}
