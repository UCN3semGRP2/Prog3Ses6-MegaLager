using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Transactions;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CustomerDb : ICustomerDB
    {
        private static CustomerDb instance;
        private db db;

        public CustomerDb()
        {
            db = db.GetInstance;
            db.SqlConnection();
        }
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
            if (entity.GetType() == typeof(Priv))
            {
                entity = createPrivate(entity);
            }
            else if (entity.GetType() == typeof(Commercial))
            {

            }

            return entity;
        }

        public Customer createPrivate(Customer entity)
        {
            TransactionOptions to = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead };
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, to))
            {
                using (SqlConnection connection = db.SqlConnection())
                {
                    connection.Open();
                    int amountOfCustomers;
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Count(*) FROM Customer WHERE customer_no == @customerNo";
                        cmd.Parameters.AddWithValue("customerNo", entity.CustomerNo);
                        amountOfCustomers = (int)cmd.ExecuteScalar();
                    }
                    if (amountOfCustomers == 0)
                    {
                        
                        using (SqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Customer (name, phone, customer_no, address, zip, account_no) VALUES(@name, @phone, @customer_no, @address, @zip, @account_no)";
                            cmd.Parameters.AddWithValue("name", entity.Name);
                            cmd.Parameters.AddWithValue("phone", entity.Phone);
                            cmd.Parameters.AddWithValue("customerNo", entity.CustomerNo);
                            cmd.Parameters.AddWithValue("address", entity.Address);
                            cmd.Parameters.AddWithValue("zip", entity.Zip);
                            cmd.Parameters.AddWithValue("accountNo", entity.Zip);
                            entity.Id = (int)cmd.ExecuteScalar();
                        }

                        using (SqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Private (customer_id) VALUES(@customer_id)";
                            cmd.Parameters.AddWithValue("customer_id", entity.Id);
                            cmd.ExecuteNonQuery();
                        }


                    }
                }
                scope.Complete();
            }

            return entity;
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
            using (SqlConnection connection = db.SqlConnection())
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Customer SET name=@name, phone=@phone, customer_no=@customer_no, address=@address, zip=@zip, account_no=@account_no WHERE id=@id";
                    cmd.Parameters.AddWithValue("name", entity.Name);
                    cmd.Parameters.AddWithValue("phone", entity.Phone);
                    cmd.Parameters.AddWithValue("customerNo", entity.CustomerNo);
                    cmd.Parameters.AddWithValue("address", entity.Address);
                    cmd.Parameters.AddWithValue("zip", entity.Zip);
                    cmd.Parameters.AddWithValue("accountNo", entity.Zip);
                    cmd.Parameters.AddWithValue("id", entity.Id);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
