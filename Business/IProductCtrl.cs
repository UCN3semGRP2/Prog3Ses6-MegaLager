using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    interface IProductCtrl
    {
        Product Create(string name, double price, int supply);
        IEnumerable<Product> FindByName(string name);
        IEnumerable<Product> FindByProductNo(int productNo);
        IEnumerable<Product> FindSoldOutProducts();
        void UpdateSupply(Product p, int newSupply);
        Product FindMostSoldProuct(DateTime start, DateTime end);
    }
}
