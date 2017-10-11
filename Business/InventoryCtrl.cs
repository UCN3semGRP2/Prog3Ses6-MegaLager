using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    public class InventoryCtrl : IInventoryCtrl
    {
        private IProductCtrl productCtrl;
        
        public void CreateProduct(string name, double price, int supply, int productNumber)
        {
            productCtrl.Create(name, price, supply, productNumber); 
            // TODO: product controller need to take more parameters

        }

        public IEnumerable<Product> FindProductByName(string name)
        {
            return productCtrl.FindByName(name);
        }

        public IEnumerable<Product> FindProductByProductNo(int productNo)
        {
            return productCtrl.FindByProductNo(productNo);
        }

        public IEnumerable<Product> GetAllSoldoutProducts()
        {
            return productCtrl.FindSoldOutProducts();
        }

        public void UpdatePrice(Product p, double price)
        {
            throw new NotImplementedException();
        }

        public void UpdateStock(Product p, int newSupply)
        {
            productCtrl.UpdateSupply(p, newSupply);
        }
    }
}
