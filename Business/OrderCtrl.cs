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
        public void AddOrderLine(OrderLine orderLine, Order o)
        {
            o.OrderLines.Add(orderLine);
            orderLineCtrl.updateReferences(orderLine, o.Id);
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

        public IEnumerable<Order> FindOrdersWithProduct(Product product)
        {
            // finds all orders where one of its orderlines contains a product id equal to product.id
            var orders = OrderDB.FindAll().ToList().FindAll(
                o => o.OrderLines.Find(ol => ol.Product.Id == product.Id) != null
            );
            return orders;
        }

        public double TotalSalesPriceInPeriod(DateTime start, DateTime end)
        {
            List<Order> orList = OrderDB.FindAll().ToList();
            double totalPrice = 0;
            foreach (var Order in orList)
            {
                if(start <= Order.OrderDate && Order.OrderDate <= end )
                {
                   
                    totalPrice += orderLineCtrl.GetSubTotal(Order.OrderLines);
                }
            }
            return totalPrice;
        }
    }
}
