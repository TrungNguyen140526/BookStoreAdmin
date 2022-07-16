using System;
using System.Collections.Generic;

namespace BookStoreAdmin.Objects
{
    public partial class Role
    {
        public Role()
        {
            UserAccounts = new HashSet<UserAccount>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}
