﻿using System;
using System.Collections.Generic;

namespace OnlineShoppingServices.Models.DB
{
    public partial class Customer
    {
        public Customer()
        {
            Ordertable = new HashSet<Ordertable>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public ICollection<Ordertable> Ordertable { get; set; }
    }
}
