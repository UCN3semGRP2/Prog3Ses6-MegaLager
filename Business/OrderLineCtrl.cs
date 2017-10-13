using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Business
{
    public class OrderLineCtrl : IOrderLineCtrl
    {
        private IOrderLineDB orderLineDB;

        public OrderLine CreateOrderLine(int amount, Product product)
        {
            OrderLine orderLine = new OrderLine
            {
                Product = product,
                Amount = amount
            };
            
            return orderLineDB.Create(orderLine);
        }

        public void DeleteOrderLine(OrderLine orderLine)
        {
            orderLineDB.Delete(orderLine);
        }

        public OrderLine FindOrderLineById(int id)
        {
            return orderLineDB.FindByID(id);
        }

        public double GetSubTotal(IEnumerable<OrderLine> orderLines)
        {
            double subtotal = 0;
            foreach (var ol in orderLines)
            {
                subtotal += ol.Amount * ol.Product.Price;
            }
            return subtotal;
        }

        public void updateReferences(OrderLine orderline, int orderId)
        {
            orderLineDB.Update(orderline, orderId);
        }
    }
}
