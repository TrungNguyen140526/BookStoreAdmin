using System;
using System.Collections.Generic;

namespace BookStoreAdmin.Objects
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        public string BookId { get; set; } = null!;
        public int Quantity { get; set; }
        public double TotalUnit { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
