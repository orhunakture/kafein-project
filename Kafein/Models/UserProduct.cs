﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kafein.Models
{
    public class UserProduct
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProductId { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
