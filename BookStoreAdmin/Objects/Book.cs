namespace BookStoreAdmin.Objects
{
    public partial class Book
    {
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string BookId { get; set; } = null!;
        public string BookName { get; set; } = null!;
        public string Author { get; set; } = null!;
        public double Price { get; set; }
        public string Supplier { get; set; } = null!;
        public string Publisher { get; set; } = null!;
        public int Inventory { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; } = null!;
        public int Ratting { get; set; }
        public DateTime DatePublished { get; set; }
        public string Description { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
