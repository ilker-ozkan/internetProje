
using System.Collections.Generic;
using System.Linq;
using Internet_1.Models;

namespace Internet_1.Repositories
{
    public interface ICartRepository
    {
        List<CartItem> GetCartItems();
        void AddToCart(int productId, int quantity);
        void RemoveFromCart(int productId); // New method for removing item
    }

    public class CartRepository : ICartRepository
    {
        private static List<CartItem> _cartItems = new List<CartItem>();
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Klavye", Price = 220 },
            new Product { Id = 2, Name = "Mouse", Price = 300 },
            new Product { Id = 3, Name = "Sandalye", Price = 150 }
        };

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }

        public void AddToCart(int productId, int quantity)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product == null) return;

            var existingItem = _cartItems.FirstOrDefault(x => x.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    ProductId = product.Id,
                    Product = product,
                    Quantity = quantity
                });
            }
        }

        public void RemoveFromCart(int productId)
        {
            var item = _cartItems.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
            {
                _cartItems.Remove(item);
            }
        }
    }
}
