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
                entity = createCommercial(entity as Commercial);
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
                            cmd.CommandText = "INSERT INTO Customer (name, phone, customer_no, address, zip, account_no, type) VALUES(@name, @phone, @customer_no, @address, @zip, @account_no, @type)";
                            cmd.Parameters.AddWithValue("name", entity.Name);
                            cmd.Parameters.AddWithValue("phone", entity.Phone);
                            cmd.Parameters.AddWithValue("customerNo", entity.CustomerNo);
                            cmd.Parameters.AddWithValue("address", entity.Address);
                            cmd.Parameters.AddWithValue("zip", entity.Zip);
                            cmd.Parameters.AddWithValue("accountNo", entity.Zip);
                            cmd.Parameters.AddWithValue("type", "Private");
                            entity.Id = (int)cmd.ExecuteScalar();
                        }

                        using (SqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Commercial (customer_id) VALUES(@customer_id)";
                            cmd.Parameters.AddWithValue("customer_id", entity.Id);
                            cmd.ExecuteNonQuery();
                        }


                    }
                }
                scope.Complete();
            }

            return entity;
        }

        public Customer createCommercial(Commercial entity)
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
                            cmd.CommandText = "INSERT INTO Customer (name, phone, customer_no, address, zip, account_no, type) VALUES(@name, @phone, @customer_no, @address, @zip, @account_no, @type)";
                            cmd.Parameters.AddWithValue("name", entity.Name);
                            cmd.Parameters.AddWithValue("phone", entity.Phone);
                            cmd.Parameters.AddWithValue("customerNo", entity.CustomerNo);
                            cmd.Parameters.AddWithValue("address", entity.Address);
                            cmd.Parameters.AddWithValue("zip", entity.Zip);
                            cmd.Parameters.AddWithValue("accountNo", entity.Zip);
                            cmd.Parameters.AddWithValue("type", "Commercial");
                            entity.Id = (int)cmd.ExecuteScalar();
                        }

                        using (SqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Commercial (customer_id, cvr, ean) VALUES(@customer_id, @cvr, @ean)";
                            cmd.Parameters.AddWithValue("customer_id", entity.Id);
                            cmd.Parameters.AddWithValue("cvr", entity.Cvr);
                            cmd.Parameters.AddWithValue("ean", entity.Ean);
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
            using (SqlConnection connection = db.SqlConnection())
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Customer WHERE Id=@id";
                    cmd.Parameters.AddWithValue("id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Customer> FindAll()
        {
            throw new NotImplementedException();
        }

        public Customer FindByID(int id)
        {
            Customer customer = null;
            using (SqlConnection connection = db.SqlConnection())
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Customer WHERE id=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["type"].Equals("Commercial"))
                        {
                            using (SqlCommand cmdComm = connection.CreateCommand())
                            {
                                cmdComm.CommandText = "SELECT * FROM Commercial WHERE customer_id=@id";
                                cmdComm.Parameters.AddWithValue("customer_id", id);
                                var commReader = cmd.ExecuteReader();

                                while (commReader.Read())
                                {
                                    customer = new Commercial
                                    {
                                        Id = (int)reader["id"],
                                        Name = (string)reader["name"],
                                        Phone = (string)reader["phone"],
                                        Address = (string)reader["address"],
                                        Zip = (string)reader["zip"],
                                        AccountNo = (string)reader["account_no"],
                                        CustomerNo = (string)reader["customer_no"],
                                        Cvr = (string)commReader["cvr"],
                                        Ean = (string)commReader["ean"]
                                    };
                                }
                            }
                        }
                        else
                        {
                            customer = new Priv
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["name"],
                                Phone = (string)reader["phone"],
                                Address = (string)reader["address"],
                                Zip = (string)reader["zip"],
                                AccountNo = (string)reader["account_no"],
                                CustomerNo = (string)reader["customer_no"],
                            };
                        }
                    }
                }
            }

            return customer;
        }

        public Customer FindByCustomerNo(string customerNo)
        {
            Customer customer = null;
            using (SqlConnection connection = db.SqlConnection())
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Customer WHERE customer_no=@customer_no";
                    cmd.Parameters.AddWithValue("customer_no", customerNo);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["type"].Equals("Commercial"))
                        {
                            using (SqlCommand cmdComm = connection.CreateCommand())
                            {
                                cmdComm.CommandText = "SELECT * FROM Commercial WHERE customer_id=@customer_id";
                                cmdComm.Parameters.AddWithValue("customer_id", (int)reader["id"]);
                                var commReader = cmd.ExecuteReader();

                                while (commReader.Read())
                                {
                                    customer = new Commercial
                                    {
                                        Id = (int)reader["id"],
                                        Name = (string)reader["name"],
                                        Phone = (string)reader["phone"],
                                        Address = (string)reader["address"],
                                        Zip = (string)reader["zip"],
                                        AccountNo = (string)reader["account_no"],
                                        CustomerNo = (string)reader["customer_no"],
                                        Cvr = (string)commReader["cvr"],
                                        Ean = (string)commReader["ean"]
                                    };
                                }
                            }
                        }
                        else
                        {
                            customer = new Priv
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["name"],
                                Phone = (string)reader["phone"],
                                Address = (string)reader["address"],
                                Zip = (string)reader["zip"],
                                AccountNo = (string)reader["account_no"],
                                CustomerNo = (string)reader["customer_no"],
                            };
                        }
                    }
                }
            }

            return customer;
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
