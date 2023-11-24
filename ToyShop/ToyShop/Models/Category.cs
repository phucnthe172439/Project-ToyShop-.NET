using System;
using System.Collections.Generic;

namespace ToyShop.Models
{
    public partial class Category
    {
        public Category()
        {
            Toys = new HashSet<Toy>();
        }

        public int Categoryid { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Toy> Toys { get; set; }
    }
}
