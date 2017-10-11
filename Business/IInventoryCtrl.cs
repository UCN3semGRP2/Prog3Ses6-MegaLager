using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IInventoryCtrl
    {
        void CreateProduct(string name, double price, int supply, List<Copy> copies, int productNumber);
        void UpdateStock(Product p, int newSupply);
        void UpdatePrice(Product p, double price);
        IEnumerable<Product> GetAllSoldoutProducts();

        IEnumerable<Product> FindProductByName(string name);
        IEnumerable<Product> FindProductByProductNo(int productNo);
    }
}
