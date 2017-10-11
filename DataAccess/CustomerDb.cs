using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
   public class CustomerDb : ICustomerDB
    {
        private static CustomerDb instance; 

        public static CustomerDb GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDb();
                }
                return instance;
            }
        }

        public Customer Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> FindAll()
        {
            throw new NotImplementedException();
        }

        public Customer FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public Customer FindByCustomerNo(string customerNo)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
