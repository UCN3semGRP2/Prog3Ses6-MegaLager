using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    public class OrderLineCtrl : IOrderLineCtrl
    {
        public OrderLine CreateOrderLine(int amount, Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderLine(OrderLine orderLine)
        {
            throw new NotImplementedException();
        }

        public OrderLine FindOrderLineById(int id)
        {
            throw new NotImplementedException();
        }

        public double GetSubTotal(IEnumerable<OrderLine> orderLines)
        {
            throw new NotImplementedException();
        }
    }
}
