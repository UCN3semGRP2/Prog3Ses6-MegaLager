using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    class SalesCtrl : ISalesCtrl
 
    {
        private CustomerCtrl cctrl;
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void AddOrderLine()
        {
            throw new NotImplementedException();
        }

        public Customer CreateComCustomer(string name, string phone, string address, string zip, string accountNo, string cvr, string ean)
        {
            Customer c = cctrl.CreateComCustomer(name, phone, address, zip, accountNo, cvr, ean);
            return c; 
        }

        public void CreateOrder(State state)
        {
            OrderCtrl.CreateOrder(state);
        }

        public Customer CreatePrivateCustomer(string name, string phone, string address, string zip, string accountNo)
        {
            Customer c = cctrl.CreatePrivateCustomer(name, phone, address, zip, accountNo);
            return c; 
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
