using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class db
    {
        private static db instance;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public SqlConnection SqlConnection()
        {
            var conn = new SqlConnection(this.connectionString);
            return conn;
        }

        public static db GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new db();
                }
                return instance;
            }
        }
    }
}
