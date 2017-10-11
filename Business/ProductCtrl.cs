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
        public Product Create(string name, double price, int supply, int productNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FindByProductNo(int productNo)
        {
            throw new NotImplementedException();
        }

        public Product FindMostSoldProuct(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FindSoldOutProducts()
        {
            throw new NotImplementedException();
        }

        public void UpdatePrice(Product p, double price)
        {
            throw new NotImplementedException();
        }

        public void UpdateSupply(Product p, int newSupply)
        {
            throw new NotImplementedException();
        }
    }
}
