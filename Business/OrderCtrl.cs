using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Business
{
    class OrderCtrl : IOrderCtrl
    {
        private IOrderDB OrderDB;
        
        public OrderCtrl()
        {
            
        }
        public void AddOrderLine(OrderLine orderLine)
        {
            
        }

        public Order CreateOrder(State state)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;

            Order o = new Order();
            o.State = state;
            o.OrderDate = d;
            return o;
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Order FindOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void PrintTotalSales(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
