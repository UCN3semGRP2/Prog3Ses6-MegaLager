using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
   
    public class ProductDB : IProductDB
    {
        private db db;

        public ProductDB()
        {
            db = db.GetInstance;
        }
        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FindAll()
        {
            throw new NotImplementedException();
        }

        public Product FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
