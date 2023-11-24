using System;
using System.Collections.Generic;

namespace ToyShop.Models
{
    public partial class Toy
    {
        public Toy()
        {
            Orderitems = new HashSet<Orderitem>();
        }

        public int Toyid { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public int Categoryid { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Orderitem> Orderitems { get; set; }
    }
}
