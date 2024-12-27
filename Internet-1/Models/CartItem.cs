
namespace Internet_1.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // Link to Product model
        public Product Product { get; set; } // Navigation property
        public int Quantity { get; set; }
    }
}
