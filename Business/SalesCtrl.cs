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
        private CustomerCtrl cCtrl;
        private OrderCtrl oCtrl; 
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
            Customer c = cCtrl.CreateComCustomer(name, phone, address, zip, accountNo, cvr, ean);
            return c; 
        }

        public void CreateOrder(State state)
        {
            oCtrl.CreateOrder(state);
        }

        public Customer CreatePrivateCustomer(string name, string phone, string address, string zip, string accountNo)
        {
            Customer c = cCtrl.CreatePrivateCustomer(name, phone, address, zip, accountNo);
            return c; 
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
