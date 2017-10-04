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
        IEnumerable<Product> findByName(string name);
        IEnumerable<Product> findByProductNo(int productNo);
        IEnumerable<Product> findSoldOutProducts();
        void UpdateSupply(Product p, int newSupply);
    }
}
