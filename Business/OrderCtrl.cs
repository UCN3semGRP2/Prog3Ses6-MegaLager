using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Business
{
    public class OrderCtrl : IOrderCtrl
    {
        private IOrderDB OrderDB;
        private IOrderLineCtrl orderLineCtrl;
        
        public OrderCtrl()
        {
            
        }
        public void AddOrderLine(OrderLine orderLine, int id)
        {
            IOrderLineCtrl.add(orderLine, id);
        }

        public Order CreateOrder(State state)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;

            
            Order o = new Order();
            o.State = state;
            o.OrderDate = d;
            return OrderDB.Create(o);
        }

        public void DeleteOrder(int id)
        {
            Order or = FindOrderById(id);
            OrderDB.Delete(or);
        }

        public Order FindOrderById(int id)
        {
            return OrderDB.FindByID(id);
        }

        public void PrintTotalSales(DateTime start, DateTime end)
        {
            List<Order> orList = (List<Order>)OrderDB.FindAll();
            int totalPrice = 0;
            foreach (var Order in orList)
            {
                if(start <= Order.OrderDate && Order.OrderDate <= end )
                {
                    totalPrice += IOrderLineCtrl.getPrice();
                }
            }
        }
    }
}
