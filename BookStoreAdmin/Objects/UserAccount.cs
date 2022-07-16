using System;
using System.Collections.Generic;

namespace BookStoreAdmin.Objects
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            Orders = new HashSet<Order>();
        }

        public string UserId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public double Money { get; set; }
        public string Gmail { get; set; } = null!;
        public int RoleId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? Gender { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
