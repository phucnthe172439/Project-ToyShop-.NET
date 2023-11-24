using System;
using System.Collections.Generic;

namespace ToyShop.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Userid { get; set; }
        public string Nickname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Address { get; set; }
        public string? Postalcode { get; set; }
        public string? Country { get; set; }
        public int Roleid { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
