﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}
