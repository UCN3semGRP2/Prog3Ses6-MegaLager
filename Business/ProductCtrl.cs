using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Business
{
    public class ProductCtrl : IProductCtrl
    {
        private IProductDB productDB;
        private IOrderCtrl orderCtrl;
        public ProductCtrl()
        {
            
        }
        public Product Create(string name, double price, int supply, int productNumber)
        {
            var p = new Product { Name = name, Price = price, Supply = supply, ProductNo = productNumber };
            return productDB.Create(p);
        }

        public IEnumerable<Product> FindByName(string name)
        {
            var all = productDB.FindAll();
            return all.ToList().FindAll(x => x.Name == name);
        }

        public IEnumerable<Product> FindByProductNo(int productNo)
        {
            var all = productDB.FindAll();
            return all.ToList().FindAll(x => x.ProductNo == productNo);
        }

        public Product FindMostSoldProduct(DateTime start, DateTime end)
        {
            var all = productDB.FindAll().ToList();
            Product mostSoldProduct = null;
            int nMostSold = 0;
            foreach (var product in all)
            {
                

                var orders = orderCtrl.FindOrdersWithProduct(product);
                var nSold = 0;
                foreach (var o in orders)
                {
                    var n = o.OrderLines.Find(x => x.Product.Id == product.Id).Amount;
                    nSold += n;
                }

                if (mostSoldProduct == null)
                {
                    mostSoldProduct = product;
                    nMostSold = nSold;
                }
                else if (nSold > nMostSold)
                {
                    mostSoldProduct = product;
                    nMostSold = nSold;
                }
                

            }
            return mostSoldProduct;
            
        }

        public IEnumerable<Product> FindSoldOutProducts()
        {
            List<Product> soldOut = new List<Product>();
            var all = productDB.FindAll();
            foreach (var p in all)
            {
                if (p.Supply == 0)
                {
                    soldOut.Add(p);
                }
            }
            return soldOut;
        }

        public void UpdatePrice(Product p, double price)
        {
            p.Price = price;
            productDB.Update(p);
        }

        public void UpdateSupply(Product p, int newSupply)
        {
            p.Supply = newSupply;
            productDB.Update(p);
        }
    }
}
