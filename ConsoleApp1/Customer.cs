﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
