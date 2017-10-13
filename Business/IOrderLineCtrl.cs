using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    interface IOrderLineCtrl
    {
        OrderLine CreateOrderLine(int amount, Product product);
        OrderLine FindOrderLineById(int id);
        void DeleteOrderLine(OrderLine orderLine);
        
        double GetSubTotal(IEnumerable<OrderLine> orderLines);
        void updateReferences(OrderLine orderline, int orderId);
    }
}
