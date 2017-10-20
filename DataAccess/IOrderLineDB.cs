using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IOrderLineDB : ICRUD<OrderLine>
    {
        void Update(OrderLine orderLine, int orderId);
    }
}
