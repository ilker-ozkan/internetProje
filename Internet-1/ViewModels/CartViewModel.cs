
using System.Collections.Generic;
using Internet_1.Models;

namespace Internet_1.ViewModels
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
