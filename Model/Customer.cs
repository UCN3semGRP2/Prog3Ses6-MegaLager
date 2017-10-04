using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Customer
    {
        public int Id { get; set; }
        public int Phone { get; set; }
        public int CustomerNo { get; set; }
        public int Zip { get; set; }
        public int AccountNo { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
    }
}
