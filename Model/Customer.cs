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
        public String Phone { get; set; }
        public String CustomerNo { get; set; }
        public String Zip { get; set; }
        public String AccountNo { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
    }
}
