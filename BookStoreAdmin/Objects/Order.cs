using System;
using System.Collections.Generic;

namespace BookStoreAdmin.Objects
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string OrderId { get; set; } = null!;
        public double? Total { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime? DateDelivery { get; set; }
        public string UserId { get; set; } = null!;
        public int Status { get; set; }

        public virtual UserAccount User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
