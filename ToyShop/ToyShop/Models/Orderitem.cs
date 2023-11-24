﻿using System;
using System.Collections.Generic;

namespace ToyShop.Models
{
    public partial class Orderitem
    {
        public int Orderitemid { get; set; }
        public int? Orderid { get; set; }
        public int? Toyid { get; set; }
        public int? Quantity { get; set; }
        public decimal? Unitprice { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Toy? Toy { get; set; }
    }
}
