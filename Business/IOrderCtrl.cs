using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    interface IOrderCtrl
    {
        Order CreateOrder(State state);
        Order FindOrderById(int id);
        void DeleteOrder(int id);
        // Order UpdateOrder(Order order);
        void AddOrderLine(OrderLine orderLine, Order order);
        double TotalSalesPriceInPeriod(DateTime start, DateTime end);
        IEnumerable<Order> FindOrdersWithProduct(Product product);
    }
}
