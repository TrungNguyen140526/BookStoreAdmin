using System.ComponentModel.DataAnnotations;

namespace BookStoreAdmin.Data
{
    public class Book
    {
        [Key]
        public String BookID { get; set; }

        [Required]
        public String BookName { get; set; }
        [Required]
        public String Author { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public String Supplier { get; set; }
        [Required]
        public String Publisher { get; set; }
        [Required]
        public int Inventory { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int Ratting { get; set; }
        [Required]
        public DateTime DatePublished { get; set; } = DateTime.Now;
        [Required]
        public String Description { get; set; }
    }
}
