﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_system.Model.Entity
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Birth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
