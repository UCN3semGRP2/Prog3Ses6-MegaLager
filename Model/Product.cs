using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Supply { get; set; }
        public List<Copy> Copies { get; set; }
        public int ProductNo { get; set; }
    }
}
